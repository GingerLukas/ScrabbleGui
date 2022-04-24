using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrabbleGui
{
    public partial class Form1 : Form
    {
        private readonly OpenFileDialog _openFileDialog = new OpenFileDialog();
        private WordNode _rootNode = null;
        public Form1()
        {
            InitializeComponent();
            _lblResult.Text = "";
            _txtUsableChars.MaxLength = 10;
        }

        private void _btnLoadDictionary_Click(object sender, EventArgs e)
        {
            var result = _openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadDictionary(_openFileDialog.FileName);
            }
        }

        private void LoadDictionary(string path)
        {
            string[] words = File.ReadAllLines(path);
            _lblWordsLoaded.Text = words.Length.ToString();
            _rootNode = WordNode.CreateTree(words);
        }

        private void _txtUsableChars_TextChanged(object sender, EventArgs e)
        {
            if (_rootNode == null)
            {
                MessageBox.Show("Nejdříve prosím načti slovník :)");
                return;
            }
            string result = "";
            _rootNode.Search(_txtUsableChars.Text.ToLower().ToCharArray().ToList(),ref result);
            if (!string.IsNullOrEmpty(result))
            {
                _lblResult.Text = result;
            }
            else
            {
                _lblResult.Text = "";
            }
        }
    }
}