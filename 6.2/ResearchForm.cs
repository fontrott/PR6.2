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
    public partial class ResearchForm : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        public ResearchForm()
        {
            InitializeComponent();
        }

        private void virusName2_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_VirusName.Parent = pictureBox1;
            lbl_VirusName.BackColor = Color.Transparent;
            lbl_VirusInfectionCount.Parent = pictureBox1;
            lbl_VirusInfectionCount.BackColor = Color.Transparent;
            lbl_RateInfectrion.Parent = pictureBox1;
            lbl_RateInfectrion.BackColor = Color.Transparent;
        }
        public void StopResearch()
        {
            if (MessageBox.Show("Вы уверены, что хотите прекратить исследование?", "Предупреждение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MessageBox.Show("Вы точно уверены в своем решении!?", "Предупреждение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Зря вы это сделали...", "Wasted", MessageBoxButtons.OK);
                    Application.Exit();
                }
            }
        }
        private void btn_StopResearch2_Click(object sender, EventArgs e)
        {
            StopResearch();
        }
        private void btn_ContinueResearch_Click(object sender, EventArgs e)
        {
            uint VirusInfectionCount;
            if (!uint.TryParse(txt_VirusInfectionCount.Text, out VirusInfectionCount))
            {
                MessageBox.Show("Пожалуйста, введите корректное значение.");
                txt_VirusInfectionCount.Text = "";
            }
            else if (MessageBox.Show("Хм.. Нам кажется, что недостаточно данных.", "", MessageBoxButtons.OK) == DialogResult.OK)
            {
                txt_VirusName1.Visible = true;
                txt_VirusInfectionCount.Visible = true;
                txt_RateInfection.Visible = true;
                lbl_RateInfectrion.Visible = true;
                btn_ContinueResearch.Visible = false;
                btn_ContinueResearch2.Visible = true;
            }
        }
        private void lbl_VirusName_Click(object sender, EventArgs e)
        {

        }
        private void btn_ContinueResearch2_Click(object sender, EventArgs e)
        {
            uint RateInfection;
            if (!uint.TryParse(txt_RateInfection.Text, out RateInfection))
            {
                MessageBox.Show("Пожалуйста, введите корректное значение.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_RateInfection.Text = "";
            }
            else
            {
                string virusInfectionCount = txt_VirusInfectionCount.Text;
                string rateInfection = txt_RateInfection.Text;
                string virusName = txt_VirusName1.Text;
                VirusFacade researchCenter = new VirusFacade();
                if (Convert.ToInt32(virusInfectionCount) < Convert.ToInt32(rateInfection))
                {
                    MessageBox.Show("Количество заболевающих в день не может быть больше количества заболевших!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    string virusType = researchCenter.VirusType(virusInfectionCount, rateInfection, virusName);
                    string vaccine = researchCenter.Vaccine(virusInfectionCount, rateInfection);
                    txt_VirusType.Text = virusType;
                    txt_Vaccine.Text = vaccine;
                }
                if (MessageBox.Show("Пожалуй, этих данных должно хватить!", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    txt_VirusName1.Visible = false;
                    txt_VirusInfectionCount.Visible = false;
                    txt_RateInfection.Visible = false;
                    lbl_RateInfectrion.Visible = false;
                    lbl_VirusName.Visible = false;
                    lbl_VirusInfectionCount.Visible = false;
                    btn_ContinueResearch.Visible = false;
                    btn_ContinueResearch2.Visible = false;
                    txt_VirusType.Visible = true;
                    txt_Vaccine.Visible = true;
                    btn_StopResearch2.Visible = false;
                    btn_StopResearch3.Visible = true;
                    btn_Experiment.Visible = true;
                }
            }
        }
        private void btn_Experiment_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int eventNumber = rnd.Next(1, 7);
            switch (eventNumber)
            {
                case 1:
                    MessageBox.Show("Лаборатория сгорела!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                    break;
                case 2:
                    MessageBox.Show("В лабораторию проник неизвестный вирус!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                    break;
                default:
                    Hide();
                    ExperimentForm experimentForm2 = new ExperimentForm();
                    experimentForm2.ShowDialog();
                    break;
            }
        }
        private void btn_StopResearch3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены в этом? Нам ведь нужно провести эксперименты.", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (MessageBox.Show("Вы точно не хотите?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show("Эххх, ну ладно..", "", MessageBoxButtons.OK);
                    Application.Exit();
                }
            }
        }
    }
}
