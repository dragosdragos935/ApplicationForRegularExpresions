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

        private void Button_Click(object sender, EventArgs e)
        {
            string pattern = textBox1.Text;
            string text = textBox2.Text;

            // Verificăm dacă pattern-ul este valid
            if (IsValidRegex(pattern))
            {
                MessageBox.Show("Este un text normal, nu un pattern.", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Verificăm dacă textul este gol
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Introduceți textul în câmpul corespunzător.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Separăm textul în linii
            string[] lines = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            bool patternFound = false;
            for (int i = 0; i < lines.Length; i++)
            {
                // Verificăm dacă linia curentă are match cu pattern-ul
                Match match = Regex.Match(lines[i], pattern);
                if (match.Success)
                {
                    patternFound = true;
                    int lineIndex = i + 1; // Indexul liniei (începând de la 1)
                    int columnIndex = match.Index + 1; // Indexul coloanei (începând de la 1)
                    MessageBox.Show($"Pattern-ul a fost găsit în linia {lineIndex}, coloana {columnIndex}: {lines[i]}", "Rezultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Dacă nu s-a găsit niciun pattern în nicio linie
            if (!patternFound)
            {
                MessageBox.Show($"Pattern-ul \"{pattern}\" nu a fost găsit în text.", "Rezultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool IsValidRegex(string pattern)
        {
            // Verificăm dacă șablonul este gol sau este un text simplu
            if (string.IsNullOrWhiteSpace(pattern) || !Regex.IsMatch(pattern, @"^[\w\s]*$"))
            {
                return false;
            }

            // Verificăm dacă șablonul este valid
            try
            {
                Regex.IsMatch("", pattern);
                return true;
            }
            catch
            {
                // Dacă există o eroare, expresia regulată este invalidă
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // La fiecare modificare a textului din textBox1, verificăm dacă noul text este un pattern valid
            string pattern = textBox1.Text;
            if (!IsValidRegex(pattern))
            {
                MessageBox.Show("Este un text normal, nu un pattern.", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
