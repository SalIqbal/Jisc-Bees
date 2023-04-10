using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bees_Jisc
{
    public partial class BeeSimulatorForm : Form
    {
        private BeeSimulator beeSim;
        private Button btnDamage;

        public BeeSimulatorForm()
        {
            InitializeComponent();
            beeSim = new BeeSimulator();

            // Display initial bee status
            DisplayBeeStatus();
        }


        private void BeeSimulatorForm_Load(object sender, EventArgs e)
        {
            beeSim = new BeeSimulator();

            DisplayBeeStatus();

            // Add  button to  form
            this.Controls.Add(btnDamage);
        }


        private void btnDamage_Click(object sender, EventArgs e)
        {
            // Simulate damage to the bees
            beeSim.RandomDamage();

            // Display updated bee status
            DisplayBeeStatus();
        }

        private void DisplayBeeStatus()
        {
            BeeList.Items.Clear();
            foreach (IBee bee in beeSim.Bees)
            {
                //print line
                BeeList.Items.Add($"Bee Type: {bee.GetType().Name},     Health: {bee.Health},     Status: {(bee.Dead ? "Dead" : "Alive")}");
            }
        }

        private void BeeSimulatorForm_Resize(object sender, EventArgs e)
        {
            BeeList.Height = this.ClientSize.Height - this.btnDamage.Height - 20;
        }

        private void BeeSimulatorForm_Load_1(object sender, EventArgs e)
        {

        }

        private void BeeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
