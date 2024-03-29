﻿using System;
using System.Windows.Forms;

namespace ProgrammersDictionary
{
    public partial class TrainingForm : Form
    {
        private Data _data;
        private int _score = 0;
        private string[] _words;
        private int _currentIndex = 0;
        private const string _messageEndTest = "The test is passed!";
        private Random _random;

        public TrainingForm(Data data)
        {
            InitializeComponent();
            _data = data;
            _random = new Random();

            labelScore.Text = _score.ToString();
            _words = _data.GetWords().ToArray();
            labelNumberWords.Text = _words.Length.ToString();
            ShuffleArry(_words);
            labelWord.Text = _data.GetTranslation(_words[_currentIndex]);
        }

        private void textBoxAnswer_TextChanged(object sender, EventArgs e)
        {
            if ( labelWord.Text.ToLower() == _data.GetTranslation(textBoxAnswer.Text.Trim().ToLower()) )
            {
                labelScore.Text = (++_score).ToString();
                _currentIndex++;
                if (_currentIndex >= _words.Length)
                {
                    MessageBox.Show(_messageEndTest);
                    Close();
                }
                else
                {
                    labelWord.Text = _data.GetTranslation(_words[_currentIndex]);
                    textBoxAnswer.Text = string.Empty;
                }
            }
        }

        private void ShuffleArry(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                int begin = _random.Next(0, words.Length),
                end = _random.Next(0, words.Length);

                string temp = words[end];
                words[end] = words[begin];
                words[begin] = temp;
            }
        }

    }
}
