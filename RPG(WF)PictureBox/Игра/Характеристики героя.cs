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
    public class Характеристики_героя
    {
        public int Здоровье { get; set; }
        public int Атака { get; set; }
        public int Броня { get; set; }
        public int Усталость { get; set; }
        public Характеристики_героя()
        {
            Здоровье = 20;
            Атака = 5;
            Броня = 10;
            Усталость = 0;
        }
    }
}
