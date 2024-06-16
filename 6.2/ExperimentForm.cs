using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._2
{
    public partial class ExperimentForm : Form
    {
        public ExperimentForm()
        {
            InitializeComponent();
        }

        private void btn_Rat_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int eventNumber = random.Next(1, 3);
            switch (eventNumber)
            {
                case 1:
                    MessageBox.Show("После намеренного внедрения вируса в организм крысы она выжила!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("После намеренного внедрения вируса в организм крысы она умерла...", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void btn_Rabbit_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int eventNumber = random.Next(1, 3);
            switch (eventNumber)
            {
                case 1:
                    MessageBox.Show("После намеренного внедрения вируса в организм кролика он выжил!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("После намеренного внедрения вируса в организм кролика он умер...", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void btn_Pig_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int eventNumber = random.Next(1, 3);
            switch (eventNumber)
            {
                case 1:
                    MessageBox.Show("После намеренного внедрения вируса в организм свиньи она выжила!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("После намеренного внедрения вируса в организм свиньи она умерла...", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
        public void StopExperiment()
        {
            if (MessageBox.Show("Ура! Мы наконец-то закончили!", "", MessageBoxButtons.OK) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void btn_StopExperiment_Click(object sender, EventArgs e)
        {
            StopExperiment();
        }
    }
}