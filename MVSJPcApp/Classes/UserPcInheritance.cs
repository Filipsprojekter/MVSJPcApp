using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVSJPcApp.Classes
{
    class UserPcInheritance
    {
        public string Lokation { get; set; }
        public string BrugerType { get; set; }

        public UserPcInheritance(string lokation, string brugerType)
        {
            Lokation = lokation;
            BrugerType = brugerType;
        }
    }
}
