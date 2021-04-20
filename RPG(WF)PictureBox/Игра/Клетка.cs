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
    public class Клетка1 : PictureBox
    {
        public bool проходимость { get; set; }
        public int Труднопроходимость { get; set; }
        public Клетка1()
        {
            проходимость = true;
        }
    }
}
