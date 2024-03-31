using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Aplicatie_Matei_Dragos_Catalin_LFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string pattern = textBox1.Text;
            string text1 = textBox2.Text;
            string text2 = textBox3.Text;

            // Ensure all text boxes are completed
            if (!IsValidRegex(pattern, text1, text2))
            {
                return;
            }

            // Split the texts into lines
            string[] lines1 = text1.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            string[] lines2 = text2.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            // Check text1 lines against the pattern
            for (int i = 0; i < lines1.Length; i++)
            {
                if (Regex.IsMatch(lines1[i], pattern))
                {
                    int lineIndex = i + 1; // Line index (starting from 1)
                    MessageBox.Show($"Pattern-ul a fost găsit în textul 1, linia {lineIndex}: {lines1[i]}", "Rezultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int lineIndex = i + 1; // Line index (starting from 1)
                    MessageBox.Show($"Pattern-ul nu a fost găsit în textul 1, linia {lineIndex}: {lines1[i]}", "Rezultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Check text2 lines against the pattern
            for (int i = 0; i < lines2.Length; i++)
            {
                if (Regex.IsMatch(lines2[i], pattern))
                {
                    int lineIndex = i + 1; // Line index (starting from 1)
                    MessageBox.Show($"Pattern-ul a fost găsit în textul 2, linia {lineIndex}: {lines2[i]}", "Rezultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int lineIndex = i + 1; // Line index (starting from 1)
                    MessageBox.Show($"Pattern-ul nu a fost găsit în textul 2, linia {lineIndex}: {lines2[i]}", "Rezultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool IsValidPattern(string pattern)
        {
            // Check if the pattern is empty
            if (string.IsNullOrWhiteSpace(pattern))
            {
                MessageBox.Show("Introduceți un șablon de expresie regulată.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the pattern contains special characters
            if (!Regex.IsMatch(pattern, @"[*+?|()\[\]{}\\.]"))
            {
                MessageBox.Show("Introduceți un șablon de expresie regulată valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the pattern is a valid regular expression
            try
            {
                // Attempt to compile the regular expression
                Regex.Match("", pattern);
                return true;
            }
            catch (ArgumentException)
            {
                // If an ArgumentException is thrown, the pattern is invalid
                MessageBox.Show("Introduceți un șablon de expresie regulată valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool IsValidText(string text)
        {
            // Check if the text is empty
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            // You can add more specific validation logic for the text if needed
            // For now, let's assume any non-empty text is considered valid
            return true;
        }

        private bool IsValidRegex(string pattern, string text1, string text2)
        {
            // Check if the pattern is valid
            if (!IsValidPattern(pattern))
            {
                return false;
            }

            // Check if the texts are valid
            if (!IsValidText(text1) || !IsValidText(text2))
            {
                MessageBox.Show("Introduceți text valid în ambele casete de text.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // At this point, the pattern and texts are valid
            return true;
        }
    }
}