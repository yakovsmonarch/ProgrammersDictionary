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
    }
}
