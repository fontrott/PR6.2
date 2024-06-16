using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._2
{
    public class ResearchClass
    {
        public string VirusType(int VirusInfectionCount, int RateInfection, string VirusName)
        {
            if (VirusInfectionCount > 100000 && RateInfection > 2000) return $"Вирус {VirusName} является пандемией.";
            else return $"Вирус {VirusName} является эпидемией.";
        }

        public string Vaccine(int VirusInfectionCount, int RateInfection)
        {
            if (VirusInfectionCount < RateInfection)
            {
                MessageBox.Show("Количество заболевающих в день не может быть больше количества заболевших!");
                return "";
            }
            else if (VirusInfectionCount > 100000 && RateInfection > 2000) return "На разработку вакцины от вируса понадобится от 5 до 10 лет.";
            else return $"На разработку вакцины от вируса понадобится 1 года до 5 лет.";
        }
    }
}
