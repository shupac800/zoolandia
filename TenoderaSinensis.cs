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
    class TenoderaSinensis : Species
    {
        public TenoderaSinensis()
        {
            this.url = "https://en.wikipedia.org/wiki/Chinese_mantis";
            this.genus = new Tenodera("Asia");
            this.scientificName = "Tenodera sinensis";
            this.commonName = "Chinese Mantis";
        }
    }
}
