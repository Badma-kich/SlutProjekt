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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double batteryLevel = Convert.ToDouble(batteryLevelTextBox.Text); // Konverterar batterinivån från sträng till decimaltal
            int selectedSpeed = int.Parse(speedComboBox.SelectedItem.ToString().Split(' ')[0]); // Hämtar den valda hastigheten från ComboBox, konverterar den från sträng till heltal
            int temperature = int.Parse(temperatureTextBox.Text); // Konverterar temperaturen från sträng till heltal

            double consumption = CalculateConsumption(selectedSpeed, temperature); // Beräknar förbrukningen baserat på vald hastighet och temperatur
            double remainingRange = CalculateRemainingRange(batteryLevel, consumption); // Beräknar kvarvarande räckvidd baserat på batterinivå och förbrukning

            if (remainingRange >= 30) // Kontrollerar om kvarvarande räckvidd är större än eller lika med 30
            {
                resultLabel.Text = $"Du kan köra ca {remainingRange} km innan du behöver ladda."; 
            }
            else
            {
                resultLabel.Text = "Du behöver ladda snart!";
            }
        }

        private double CalculateConsumption(int speed, int temperature) // Metod för att beräkna förbrukning
        {
            double consumption = 0; // Variabel för att lagra beräknad förbrukning
            if (speed == 80) // Kontrollerar om hastigheten är 80
            {
                consumption = -temperature / 3.0 + 18; // Beräknar förbrukningen baserat på hastigheten och temperaturen
            }
            else if (speed == 100) // Kontrollerar om hastigheten är 100
            {
                consumption = -temperature / 3.0 + 22; // Beräknar förbrukningen baserat på hastigheten och temperaturen
            }
            return consumption; // Returnerar beräknad förbrukning
        }

        private double CalculateRemainingRange(double batteryLevel, double consumption) // Metod för att beräkna kvarvarande räckvidd
        {
            double maxRange = (batteryLevel * 100) / consumption; // Beräknar maximal räckvidd baserat på batterinivå och förbrukning
            return maxRange; // Returnerar maximal räckvidd
        }
    }
}
