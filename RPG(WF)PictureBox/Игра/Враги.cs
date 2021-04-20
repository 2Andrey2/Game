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
    public class Враги
    {
        public int Здоровье { get; set; }
        public int Атака { get; set; }
        public int Броня { get; set; }
        public bool Существование { get; set; }
        public Враги()
        {
            Здоровье = 20;
            Random l = new Random();
            int n = l.Next(1, 20);
            Атака = n;
            int o = l.Next(1, 20);
            Броня = o;
            Атака = n;
            Броня = o;
        }
    }
}
