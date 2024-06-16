using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _6._2.VirusFacade;

namespace _6._2
{
    public class VirusFacade
    {
        private ResearchClass virusResearcher;

        public VirusFacade()
        {
            virusResearcher = new ResearchClass();
        }
        public string VirusType(string VirusInfectionCount, string RateInfection, string VirusName)
        {
            return virusResearcher.VirusType(Convert.ToInt32(VirusInfectionCount), Convert.ToInt32(RateInfection), VirusName);
        }
        public string Vaccine(string VirusInfectionCount, string RateInfection)
        {
            return virusResearcher.Vaccine(Convert.ToInt32(VirusInfectionCount), Convert.ToInt32(RateInfection));
        }
    }
}
