using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVSJPcApp.Classes;

namespace MVSJPcApp
{
    class User : UserPcInheritance
    {
        public string  Navn { get; set; }
        public string Wrx { get; set; }

        public User(string lokation, string brugerType, string navn, string wrx) : base(lokation, brugerType)
        {
            Navn = navn;
            Wrx = wrx;
            Lokation = lokation;
            BrugerType = brugerType;
        }
        
    }
}
