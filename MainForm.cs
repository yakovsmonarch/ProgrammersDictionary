using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProgrammersDictionary
{
    public partial class MainForm : Form
    {
        private Data _data;
        private const string _FILENAME = "data.dat";
        private const string _messageAbout = "An application for creating your own dictionary.";
        private const string _messageErrorSelectListBox = "The word from the list is not selected.";

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            FormWord formWord = new FormWord();
            if (formWord.ShowDialog() != DialogResult.OK) 
                return;
            if (formWord.Word.Trim() == string.Empty)
                return;

            _data.Add(formWord.Word, formWord.Translation);
            listBoxWords.Items.Add(formWord.Word);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(_FILENAME) == false)
            {
                _data = new Data();
                return;
            }

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(_FILENAME, FileMode.OpenOrCreate))
            {
                _data = (Data)binaryFormatter.Deserialize(fs);
            }

            listBoxWords.Items.AddRange(_data.GetWords().ToArray());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(_FILENAME, FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, _data);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_messageAbout);
        }

        private void listBoxWords_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void listBoxWords_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditWord();
        }

        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddButton_Click(new Object(), e);
        }

        private void deleteWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxWords.SelectedIndex;
            if (selectedIndex < 0)
            {
                MessageBox.Show(_messageErrorSelectListBox);
                return;
            }

            string word = listBoxWords.Items[selectedIndex].ToString();
            _data.Delete(word);
            listBoxWords.Items.RemoveAt(selectedIndex);
        }

        private void editWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditWord();
        }

        private void EditWord()
        {
            if (listBoxWords.SelectedIndex < 0)
            {
                MessageBox.Show(_messageErrorSelectListBox);
                return;
            }

            string word = listBoxWords.Items[listBoxWords.SelectedIndex].ToString();
            FormWord formWord = new FormWord(word, _data.GetTranslation(word));
            if (formWord.ShowDialog() != DialogResult.OK)
                return;

            _data.Edit(word, formWord.Translation);
            listBoxWords.Items.Clear();
            listBoxWords.Items.AddRange(_data.GetWords().ToArray());
        }

        private void testingOfLearnedWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            TrainingForm trainingForm = new TrainingForm(_data);
            trainingForm.ShowDialog();
            Visible = true;
        }
    }
}
