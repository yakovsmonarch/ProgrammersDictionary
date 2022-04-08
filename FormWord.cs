using System.Windows.Forms;

namespace ProgrammersDictionary
{
    public partial class FormWord : Form
    {
        public string Word
        {
            get
            {
                return textBoxWord.Text.Trim();
            }
            private set
            {
                textBoxWord.Text = value.Trim();
            }
        }
        public string Translation
        {
            get
            {
                return textBoxTranslation.Text.Trim();
            }
            private set
            {
                textBoxTranslation.Text = value.Trim();
            }
        }

        public FormWord()
        {
            InitializeComponent();
        }

        public FormWord(string word, string translation)
        {
            InitializeComponent();

            Word = word;
            Translation = translation;
        }
    }
}
