﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoolandia
{
    class Species : Taxonomy
    {
        private Genus _genus;

        public Genus genus
        {
            get
            {
                return _genus;
            }
            set
            {
                _genus = value;
            }
        }
    }
}
