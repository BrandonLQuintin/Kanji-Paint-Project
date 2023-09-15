using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Kanji_Paint_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            richTextBox1.Font = new Font("Takao Gothic", 12);

        }

        public void sortDictionary(Dictionary<string, string> inputDictionary) // Big O(n)
        {

            // This is from the user "caryden" on https://stackoverflow.com/questions/289/how-do-you-sort-a-dictionary-by-value
            var sortedDict = from entry in inputDictionary orderby int.Parse(entry.Value) descending select entry;
            listBox1.Items.Clear();
            foreach (var item in sortedDict)
            {
                listBox1.Items.Add(item.Key);
            }
        }


        public void sortDictionaryAscend(Dictionary<string, string> inputDictionary) // Big O(n)
        {
            // This is from the user "caryden" on https://stackoverflow.com/questions/289/how-do-you-sort-a-dictionary-by-value
            var sortedDict = from entry in inputDictionary orderby int.Parse(entry.Value) ascending select entry;
            listBox1.Items.Clear();
            foreach (var item in sortedDict)
            {
                listBox1.Items.Add(item.Key);
            }
        }

        Dictionary<string, string> kanjiPhoto = new Dictionary<string, string>();
        Dictionary<string, string> kanjiText = new Dictionary<string, string>();
        Dictionary<string, string> kanjiStrokes = new Dictionary<string, string>();
        Dictionary<string, string> kanjiWordCount = new Dictionary<string, string>();
        public void openFiles(List<string> list) // Big O(n) - When I measured it,
                                                 // the runtime of this function took around 135 milliseconds on my school laptop
                                                 // to execute about 10 files and 10 jpg images
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) // The OpenFileDialog was made by ChatGPT.
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    String kanjiName;

                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        kanjiName = File.ReadAllText(fileName);
                        kanjiName = kanjiName.Trim('[', ']');
                        string[] parsedKanji = kanjiName.Split(',');


                        list.Add(parsedKanji[1]);
                        // OLD CODE REPLACED BY NEW CODE BELOW
                        // kanjiPhoto.Add(parsedKanji[1], parsedKanji[0].Trim('"')); // 1 is the name of kanji, and 0 is the jpg location
                        kanjiPhoto.Add(parsedKanji[1], fileName.Remove(fileName.Length - 4) + ".jpg");
                        kanjiText.Add(parsedKanji[1], parsedKanji[2].Trim('"')); // 2 is the kanji description
                        kanjiStrokes.Add(parsedKanji[1], parsedKanji[3].Trim('"')); // 3 is the stroke amount


                        string WordCount = parsedKanji[4].Substring(0, parsedKanji[4].Length - 4); // KanjiWordCount was bugged, so this is a quick fix.
                        WordCount = WordCount.Substring(1);

                        kanjiWordCount.Add(parsedKanji[1], WordCount);

                    }

                }
            }
            foreach (string kanji in list)
            {
                listBox1.Items.Add(kanji);
            }
        }

        private void Form2_Load(object sender, EventArgs e) // Big O(n)
        {
            List<string> lines = new List<string>();

            openFiles(lines);

        }
        string pictureBoxJpg = "";
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) // Big O(1)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string Kanji = listBox1.Items[listBox1.SelectedIndex].ToString();
                pictureBoxJpg = kanjiPhoto[Kanji];

                richTextBox2.Text = kanjiStrokes[Kanji] + " strokes";
                richTextBox3.Text = kanjiWordCount[Kanji] + " words";
                richTextBox1.Text = "DESCRIPTION\n --------------\n" + kanjiText[Kanji];

                pictureBox1.Image = Image.FromFile(pictureBoxJpg);
            }


        }

        private void mostStrokesBtn_Click(object sender, EventArgs e)
        {
            sortDictionary(kanjiStrokes);
        }

        private void sortBiggestDescriptionBtn_Click(object sender, EventArgs e)
        {
            sortDictionary(kanjiWordCount);
        }

        private void sortLeastStrokesBtn_Click(object sender, EventArgs e)
        {
            sortDictionaryAscend(kanjiStrokes);
        }

        private void sortSmallestDescriptionBtn_Click(object sender, EventArgs e)
        {
            sortDictionaryAscend(kanjiWordCount);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
