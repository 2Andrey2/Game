﻿using System;
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
    public class Error1
    {
        public static bool move(int oo, int rr)
        {
            if (oo <= 20 && oo >= 0)
            { if (rr <= 20 && rr >= 0) { return true; } }
            return false;
        }
    }
}
