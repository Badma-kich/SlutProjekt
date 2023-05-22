using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlutUppgift
{
    public partial class Form5 : Form
    {
        private List<int> primeNumbers; // Deklarerar en variabel för primtalslistan
        private Stopwatch stopwatch; // Deklarerar en variabel för stopwatch
        public Form5()
        {
            InitializeComponent();
            primeNumbers = new List<int>(); // Skapar en ny lista för primtalen
            stopwatch = new Stopwatch(); // Skapar en ny stopwatch
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            primeNumbers.Clear(); // Rensar primtalslistan
            int upperLimit;
            if (!int.TryParse(upperLimitTextBox.Text, out upperLimit)) // Försöker konvertera det övre gränsvärdet till ett heltal
            {
                runResultLabel.Text = "Invalid upper limit!"; // Visar ett felmeddelande om konverteringen misslyckades
                return;
            }

            stopwatch.Reset(); // Återställer stopwatch
            stopwatch.Start(); // Startar stopwatch
            for (int i = 2; i <= upperLimit; i++) // Utför en loop från 2 till det övre gränsvärdet för att hitta primtal
            {
                if (IsPrime(i)) // Kontrollerar om ett tal är ett primtal
                {
                    primeNumbers.Add(i); // Lägger till primtalet i primtalslistan
                }
            }

            stopwatch.Stop(); // Stoppar stopwatch
            runResultLabel.Text = $"Time elapsed: {stopwatch.ElapsedMilliseconds} ms. Found {primeNumbers.Count} primes.";
            // Uppdaterar resultatet i runResultLabel med tiden det tog och antalet hittade primtal
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            int testNumber;
            if (!int.TryParse(testNumberTextBox.Text, out testNumber)) // Försöker konvertera det testade numret till ett heltal
            {
                testResultLabel.Text = "Invalid number to test!"; // Visar ett felmeddelande om konverteringen misslyckades
                return;
            }

            bool isPrime = IsPrime(testNumber); // Kontrollerar om det testade numret är ett primtal
            testResultLabel.Text = $"{testNumber} is {(isPrime ? "" : "not ")}a prime number.";
            // Uppdaterar resultatet i testResultLabel med om det testade numret är ett primtal eller inte
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            int index;
            if (!int.TryParse(indexTextBox.Text, out index)) // Försöker konvertera indexet till ett heltal
            {
                showResultLabel.Text = "Invalid index!"; // Visar ett felmeddelande om konverteringen misslyckades
                return;
            }
            if (index >= 0 && index < primeNumbers.Count) // Kontrollerar om indexet är inom primtalslistans gränser
            {
                showResultLabel.Text = $"Prime number at position {index} is {primeNumbers[index]}";
                // Uppdaterar resultatet i showResultLabel med det primtal som finns på den angivna positionen i primtalslistan
            }
            else
            {
                showResultLabel.Text = "Invalid index."; // Visar ett felmeddelande om indexet är ogiltigt
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            allPrimesRichTextBox.Text = string.Join(", ", primeNumbers);
            // Uppdaterar innehållet i allPrimesRichTextBox med alla primtal från primtalslistan
        }
        private static bool IsPrime(int number) // Statisk metod för att kontrollera om ett tal är ett primtal
        {
            if (number < 2) // Kontrollerar om talet är mindre än 2
            {
                return false; // Returnerar false eftersom primtal är större än eller lika med 2
            }
            for (int i = 2; i <= Math.Sqrt(number); i++) // Utför en loop från 2 till kvadratroten av talet
            {
                if (number % i == 0) // Kontrollerar om talet är jämnt delbart med i
                {
                    return false; // Returnerar false eftersom talet inte är ett primtal
                }
            }
            return true; // Returnerar true eftersom talet är ett primtal
        }

    }
}
