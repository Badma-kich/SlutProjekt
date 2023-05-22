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
    public partial class Form4 : Form
    {
        private int[] userNumbers; // Deklarerar en variabel för användarens valda nummer
        private int[] lottoNumbers; // Deklarerar en variabel för lottonummer
        private int userNumberCount; // Deklarerar en variabel för antalet nummer som användaren har valt
        public Form4()
        {
            InitializeComponent();
            ResetGame(); // Återställer spelet 
        }

        private void NumberButtonClicked(object sender, EventArgs e)
        {
            if (this.userNumberCount >= 7) // Kontrollerar om användaren redan har valt 7 nummer
            {
                MessageBox.Show("Du har redan valt 7 nummer!"); // Visar ett meddelande om att användaren redan har valt maximalt antal nummer
                return;
            }

            Button clickedButton = (Button)sender; // Hämtar den klickade knappen
            int chosenNumber = int.Parse(clickedButton.Text); // Konverterar texten på knappen till ett heltal
            if (this.userNumbers.Contains(chosenNumber)) // Kontrollerar om användaren redan har valt det här numret
            {
                MessageBox.Show("Du har redan valt detta nummer!"); // Visa ett meddelande om att användaren redan har valt detta nummer
                return;
            }

            this.userNumbers[this.userNumberCount++] = chosenNumber; // Lägger till det valda numret i användarens nummerarray och ökar räknaren
            clickedButton.Enabled = false; // Inaktiverar knappen för det valda numret
            if (this.userNumberCount == 7) // Kontrollerar om användaren har valt 7 nummer
            {
                this.drawButton.Enabled = true; // Aktiverar knappen för att dra lottoraden
                this.simulateButton.Enabled = true; // Aktiverar knappen för att simulera dragningar
            }
        }
        private void simulateButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(this.simulationsTextBox.Text, out int numSimulations)) // Försöker konvertera antalet simuleringar till ett heltal
            {
                MessageBox.Show("Invalid number of simulations!"); // Visar ett felmeddelande om konverteringen misslyckades
                return;
            }

            int[] correctCounts = new int[8]; // Skapar en array för att räkna antalet rätt gissade nummer
            for (int i = 0; i < numSimulations; i++) // Utför simuleringen det angivna antalet gånger
            {
                this.GenerateLottoNumbers(); // Genererar en ny lottorad
                int correctNumbers = this.userNumbers.Intersect(this.lottoNumbers).Count(); // Räknar antalet rätt gissade nummer
                correctCounts[correctNumbers]++; // Ökar räknaren för antalet rätt gissade nummer
            }

            this.resultLabel.Text = $"Simulations: {numSimulations}\n" +
                                    $"7 correct: {correctCounts[7]}\n" +
                                    $"6 correct: {correctCounts[6]}\n" +
                                    $"5 correct: {correctCounts[5]}"; // Uppdaterar resultatet i resultLabel med antalet rätt gissade nummer
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.ResetGame(); // Återställer spelet till sitt ursprungliga tillstånd
        }
        private void GenerateLottoNumbers()
        {
            Random random = new Random(); // Skapar en ny slumpgenerator
            for (int i = 0; i < 7; i++) // Utför loopen 7 gånger för att generera 7 lottonummer
            {
                int randNum;
                do
                {
                    randNum = random.Next(1, 36); // Genererar ett slumpmässigt nummer mellan 1 och 35
                }
                while (this.lottoNumbers.Contains(randNum)); // Upprepa tills ett unikt nummer genereras

                this.lottoNumbers[i] = randNum; // Lägger till det genererade numret i lottonummerarrayen
            }
        }
        private void ResetGame()
        {
            this.userNumbers = new int[7]; // Skapar en ny array för användarens nummer
            this.lottoNumbers = new int[7]; // Skapar en ny array för lottonummer
            this.userNumberCount = 0; // Återställer räknaren för antalet valda nummer
            this.drawButton.Enabled = false; // Inaktiverar knappen för att dra lottoraden
            this.simulateButton.Enabled = false; // Inaktiverar knappen för att simulera dragningar
            foreach (Button button in this.Controls.OfType<Button>()) // Loopar genom alla knappar på formuläret
            {
                button.Enabled = true; // Aktiverar alla knappar
            }
            this.resultLabel.Text = ""; // Återställer resultatet i resultLabel
        }

        private void DrawButtonClicked(object sender, EventArgs e)
        {
            this.GenerateLottoNumbers(); // Genererar en ny lottorad
            int correctNumbers = this.userNumbers.Intersect(this.lottoNumbers).Count(); // Räknar antalet rätt gissade nummer
            this.resultLabel.Text = $"Du fick {correctNumbers} rätt!"; // Uppdaterar resultatet i resultLabel
        }
    }
}
