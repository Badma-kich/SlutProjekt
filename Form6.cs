using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlutUppgift
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int number; // Deklarerar en variabel för det decimala talet som ska konverteras
            if (!int.TryParse(decimalTextBox.Text, out number)) // Försöker konvertera innehållet i decimalTextBox till ett heltal
            {
                MessageBox.Show("Invalid decimal number!"); // Visar ett felmeddelande om konverteringen misslyckades
                return;
            }

            int targetBase; // Deklarerar en variabel för målbasen för konverteringen
            if (!int.TryParse(baseTextBox.Text, out targetBase)) // Försöker konvertera innehållet i baseTextBox till ett heltal
            {
                MessageBox.Show("Invalid target base!"); // Visar ett felmeddelande om konverteringen misslyckades
                return;
            }

            if (targetBase < 2 || targetBase > 9) // Kontrollerar om målbasen är utanför intervallet 2-9
            {
                MessageBox.Show("Target base must be between 2 and 9."); // Visar ett felmeddelande om målbasen är ogiltig
                return;
            }

            string convertedNumber = ConvertToBase(number, targetBase); // Konverterar det decimala talet till målbasen
            resultLabel.Text = $"Converted number: {convertedNumber}"; // Uppdaterar resultatet i resultLabel
        }
        private string ConvertToBase(int number, int targetBase) // Metod för att konvertera ett decimaltal till en annan bas
        {
            string convertedNumber = ""; // Skapar en tom sträng för att lagra det konverterade talet
            while (number > 0) // Utför loopen så länge det decimala talet är större än noll
            {
                int remainder = number % targetBase; // Beräknar resten av divisionen
                convertedNumber = remainder.ToString() + convertedNumber; // Lägger till resten i början av strängen
                number /= targetBase; // Uppdaterar det decimala talet genom att dela med målbasen
            }
            return convertedNumber; // Returnera det konverterade talet
        }
    }
}
