using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVSJPcApp.Classes;

namespace MVSJPcApp.NewFolder1
{
    class PcModel : UserPcInheritance
    {
        public string Model { get; set; }
        public DateTime DateTime  { get; set; }

        public PcModel(string lokation, string brugerType, string model, DateTime dateTime) : base(lokation, brugerType)
        {
            Model = model;
            DateTime = DateTime.Date;
            Model = model;
            BrugerType = brugerType;

        }
    }
}
