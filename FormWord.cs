using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammersDictionary
{
    public partial class FormWord : Form
    {
        public string Word => textBoxWord.Text;
        public string Translation => textBoxTranslation.Text;

        public FormWord()
        {
            InitializeComponent();
        }
    }
}
