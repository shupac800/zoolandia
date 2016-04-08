using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoolandia
{
    /*
      Species of Tenodera
     */
    class TenoderaAngustipennis : Species
    {
        public TenoderaAngustipennis()
        {
            this.url = "https://en.wikipedia.org/wiki/Tenodera_angustipennis";
            this.genus = new Tenodera("Asia");
            this.scientificName = "Tenodera angustipennis";
            this.commonName = "Japanese Mantis";
        }
    }
}
