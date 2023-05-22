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
    public partial class Form3 : Form
    {
        List<int> rolls = new List<int>(); // Skapar en ny lista för att lagra resultaten av tärningskast
        Random random = new Random();  // Skapar en ny instans av Random-klassen för att generera slumpmässiga tal
        public Form3()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            rolls.Clear();  // Tömmer listan med tärningskast
            resultsListBox.Items.Clear();  // Tömmer resultsListBox
            int numberOfRolls = (int)numberOfRollsNumericUpDown.Value;  // Tar värdet från numericUpDown1 och castar det till en heltal

            for (int i = 0; i < numberOfRolls; i++)  // En loop som kör ett antal gånger lika med antalet tärningskast som användaren vill göra
            {
                int roll = random.Next(1, 7);  // Genererar ett slumpmässigt tal mellan 1 och 6
                rolls.Add(roll);  // Lägger till det slumpmässiga talet till listan över tärningskast
            }

            var rollGroups = rolls.GroupBy(r => r).OrderBy(r => r.Key);  
            // Grupperar listan över tärningskast baserat på tärningsresultatet och sorteras i ordning

            foreach (var group in rollGroups)  // Loopar igenom varje grupp av tärningskast
            {
                double probability = (double)group.Count() / numberOfRolls;  // Räknar ut sannolikheten för varje grupp
                resultsListBox.Items.Add($"Antal {group.Key}: {group.Count()}, Sannolikhet: {probability.ToString("P2")}");
                // Lägger till resultaten till listBox1
            }
        }
    }
}
