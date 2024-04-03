using System.Text.RegularExpressions;

namespace Aplicatie_Matei_Dragos_Catalin_LFA
{
    public partial class Form1 : Form
    {
        // Definirea variabilelor de instanță pentru pattern, text1 și text2
        private string pattern;
        private string text1;
        private string text2;

        public Form1()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Actualizarea valorilor pentru pattern, text1 și text2
            pattern = textBox1.Text;
            text1 = textBox2.Text;
            text2 = textBox3.Text;

            // Ensure all text boxes are completed
            if (!IsValidRegex(pattern, text1, text2))
            {
                return;
            }

            // Check if pattern exists in text1
            DisplayMatches(text1, pattern, "textul 1");

            // Check if pattern exists in text2
            DisplayMatches(text2, pattern, "textul 2");
        }

        private void DisplayMatches(string text, string pattern, string textName)
        {
            MatchCollection matches = Regex.Matches(text, pattern);
            Console.WriteLine(matches.ToString());
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    MessageBox.Show($"Pattern-ul a fost găsit în {textName} la poziția {match.Index} și conține '{match.Value}'", "Rezultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"Pattern-ul nu a fost găsit în {textName}.", "Rezultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
