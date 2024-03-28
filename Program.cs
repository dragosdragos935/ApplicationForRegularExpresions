using System;
using System.Windows.Forms;

namespace Aplicatie_Matei_Dragos_Catalin_LFA
{
    static class Program
    {
        /// <summary>
        /// Punctul de intrare principal pentru aplicație.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Creăm o instanță a formularului principal
            Form1 mainForm = new Form1();

            // Verificăm dacă formularul a fost creat cu succes și încercăm să-l afișăm
            if (mainForm != null)
            {
                Application.Run(mainForm);
            }
            else
            {
                // Dacă formularul nu a putut fi creat, afișăm un mesaj de eroare
                MessageBox.Show("Formularul principal nu a putut fi creat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
