using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игра
{
    class Предметы
    {
        public bool Существование { get; set; }
        public int тип_предмета { get; set; }
        public int увеличение { get; set; }
        public Предметы()
        {
                Random l = new Random();
                int n = l.Next(1, 5);
                увеличение = n;
        }
    }
}
