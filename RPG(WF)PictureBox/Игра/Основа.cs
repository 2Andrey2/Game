using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Игра
{
    public partial class Основа : Form
    {
        public Основа()
        {
            InitializeComponent();
        }
        public static Bitmap trava = new Bitmap(@"C:\Documents and Settings\Admin\Рабочий стол/Игра/Картинки/Трава.jpg");
        public static Bitmap knight = new Bitmap(@"C:\Documents and Settings\Admin\Рабочий стол/Игра/Картинки/Рыцарь.jpg");
        public static Bitmap mountain = new Bitmap(@"C:\Documents and Settings\Admin\Рабочий стол/Игра/Картинки/Гора.jpg");
        public static Bitmap sea = new Bitmap(@"C:\Documents and Settings\Admin\Рабочий стол/Игра/Картинки/Море.jpg");
        public static Bitmap forest = new Bitmap(@"C:\Documents and Settings\Admin\Рабочий стол/Игра/Картинки/Лес.jpg");
        public static Bitmap Враг = new Bitmap(@"C:\Documents and Settings\Admin\Рабочий стол/Игра/Картинки/Враг.jpg");
        public static Bitmap Доп_атака = new Bitmap(@"C:\Documents and Settings\Admin\Рабочий стол/Игра/Картинки/Доп_атака.jpg");
        public static Bitmap Доп_защита = new Bitmap(@"C:\Documents and Settings\Admin\Рабочий стол/Игра/Картинки/Доп_защита.jpg");
        public Клетка1[,] mass = new Клетка1[200, 200];// массив картинок
        public PictureBox[,] массив_врагов = new PictureBox[200, 200];
        public PictureBox[,] массив_предметов = new PictureBox[200, 200];
        public static int o = 0;// стороки
        public static int r = 0;// ряды
        public int j = 0; // Хендел
        public int a;
        public int s;
        static public int результат_атаки;// Результат атаки между формами
        static public int атака_отступлеие;// атака или отступление
        public int z; // Результат атаки для перемещения
        PictureBox First = new PictureBox();
        static public Характеристики_героя хар = new Характеристики_героя();
        static public Враги [,]вар = new Враги[100,100];
        Предметы [,]предметы = new Предметы [100,100];
        public class Клетка : PictureBox
        {
            public int avbl {get;set;}
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            //TopMost = true;
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
        }
        // Создание кнопок управления перемещения
        private void button4_Click(object sender, EventArgs e)//Вверх
        {
            int ii = o; ii = ii - 1;
            if (!Error1.move(ii, o)) return;
            int i = 3;
            Перемещение_на_клетку(i);
        }

        private void button3_Click(object sender, EventArgs e)//Влево
        {
            int ii = r; ii = ii - 1;
            if (!Error1.move(o, ii)) return;
            int i = 2;
            Перемещение_на_клетку(i);
        }

        private void button1_Click(object sender, EventArgs e)//Вниз
        {
            int ii = o; ii = ii + 1;
            if (!Error1.move(ii, r)) return;
            int i = 4;
            Перемещение_на_клетку(i);
        }

        public void button2_Click(object sender, EventArgs e)//Вправо
        {
            int ii = r; ii = ii + 1;
            if (!Error1.move(o, ii)) return;
            int i = 1;
            Перемещение_на_клетку(i);
        }
        public void Перемещение_на_клетку(int i) // Перемещение_на_клетку
        {
            Point location = new Point();
            if (r == 0)
            {
                if (mass[o, r + 1].проходимость == true && mass[o+1, r].проходимость == true)
                {
                    First.Dispose();
                    mass[0, 0].Visible = true;
                }
            }
            if (i == 1)
            {
                if (mass[o, r+1].проходимость == false)
                {
                    MessageBox.Show("Прохода нет");
                    return;
                }
                if (хар.Усталость + mass[o, r+1].Труднопроходимость > 500) { MessageBox.Show("Больше мне не пройти"); return; }
                else { хар.Усталость = хар.Усталость + mass[o, r+1].Труднопроходимость; }
                r = r + 1;
            }
            if (i == 2)
            {
                if (mass[o, r-1].проходимость == false)
                {
                    MessageBox.Show("Прохода нет");
                    return;
                }
                if (хар.Усталость + mass[o, r-1].Труднопроходимость > 500) { MessageBox.Show("Больше мне не пройти"); return; }
                else { хар.Усталость = хар.Усталость + mass[o, r-1].Труднопроходимость; }
                r = r - 1;
            }
            if (i == 3)
            {
                if (mass[o-1, r].проходимость == false)
                {
                    MessageBox.Show("Прохода нет");
                    return;
                }
                if (хар.Усталость + mass[o-1, r].Труднопроходимость > 500) { MessageBox.Show("Больше мне не пройти"); return; }
                else { хар.Усталость = хар.Усталость + mass[o-1, r].Труднопроходимость; }
                o = o - 1;
            }
            if (i == 4)
            {
                if (mass[o+1, r].проходимость == false)
                {
                    MessageBox.Show("Прохода нет");
                    return;
                }
                if (хар.Усталость + mass[o+1, r].Труднопроходимость > 500) { MessageBox.Show("Больше мне не пройти"); return; }
                else { хар.Усталость = хар.Усталость + mass[o+1, r].Труднопроходимость; }
                o = o + 1;
            }
            location = mass[o, r].Location;
            if (массив_врагов[o, r].Image == Враг && вар[o, r].Существование == true)
            {
                Если_враг();
                if (z == 0)
                {
                    if (i == 1) { r = r - 1; } if (i == 2) { r = r + 1; }
                    if (i == 3) { o = o + 1; } if (i == 4) { o = o - 1; }
                    return;
                }
            }
            if (предметы[o, r].Существование == true)
            {
                если_предмет();
            }
            if ((panel3.Controls["pctdd"] as PictureBox) != null)
            {
                (panel3.Controls["pctdd"] as PictureBox).Dispose();
            }
            PictureBox avbl = new PictureBox();
            avbl.Location = location;
            avbl.Height = 100;
            avbl.Width = 100;
            avbl.Name = "pctdd";
            avbl.MouseEnter += new EventHandler(Клик_на_героя);
            avbl.Parent = panel3;
            avbl.Image = Основа.knight;
            avbl.BringToFront();
        }
        public void Если_враг() // Если_враг
        {
            DialogResult результат = new DialogResult();
            Окно_боя окно = new Окно_боя();
            окно.заполнение();
            результат = окно.ShowDialog();
            if (атака_отступлеие == 2)
            {
                z = 0;
                return;
            }
            if (атака_отступлеие == 1)
            {
                if (результат_атаки == 2)
                {
                    MessageBox.Show("Вы погибли");
                    (panel3.Controls["pctdd"] as PictureBox).Dispose();
                    z = 0;
                    return;
                }
                if (результат_атаки == 1)
                {
                    MessageBox.Show("Вы победили");
                    массив_врагов[o, r].Dispose();
                    вар[o, r].Существование = false;
                    z = 1;
                }
            }
        }
        public void если_предмет()// Если предмет
        {
            if (предметы[o, r].тип_предмета == 1)
            {
                хар.Атака = хар.Атака + предметы[o, r].увеличение;
            }
            if (предметы[o, r].тип_предмета == 2)
            {
                хар.Броня =хар.Броня + предметы[o, r].увеличение;
            }
            массив_предметов[o, r].Dispose();
            предметы[o, r].Существование = false;
        }
        public void Клик_на_героя(object send, EventArgs e) // Клик_на_героя
        {
            toolTip1.SetToolTip((panel3.Controls["pctdd"] as PictureBox),
            "Здорвье="+хар.Здоровье+"\nАтака="+хар.Атака+
            "\nУсталость="+хар.Усталость+"\nБроня="+хар.Броня);
            toolTip1.Active = true;
        }
        public void Клик_на_врага(object send, EventArgs e) // Клик_на_врага
        {
            PictureBox my = send as PictureBox;
            for (int i = 0; i <= 20; i = i + 1)
            {
                for (int j = 0; j <= 20; j = j + 1)
                {
                    if (my == массив_врагов[i, j])
                    {
                        a = i;
                        s = j;
                        goto too;
                    }
                }
            }
        too:
            toolTip1.SetToolTip(my, "Здорвье=" + вар[a, s].Здоровье + "\nАтака=" + вар[a, s].Атака + "\nБроня=" + вар[a, s].Броня);
            toolTip1.Active = true;
        }
        public void Клик_на_предмет(object send, EventArgs e) // Клик_на_предмет
        {
            PictureBox my = send as PictureBox;
            for (int i = 0; i <= 20; i = i + 1)
            {
                for (int j = 0; j <= 20; j = j + 1)
                {
                    if (my == массив_предметов[i, j])
                    {
                        a = i;
                        s = j;
                        goto too;
                    }
                }
            }
        too:
            toolTip1.SetToolTip(my, "Увеличение" + предметы[a,s].увеличение);
            toolTip1.Active = true;
        }
        public void Генерация_Click(object sender, EventArgs e) // Создание поля
        {
            Random l = new Random();
            int x, y;
            x = 0;
            y = 0;
            for (int i = 0; i <= 20; i = i + 1)
            {
                for (int j = 0; j <= 20; j = j + 1)
                {
                    int n = l.Next(0, 20);
                    mass[i, j] = new Клетка1();
                    mass[i, j].Location = new Point(x, y);
                    mass[i, j].Height = 100;
                    mass[i, j].Width = 100;
                    mass[i, j].Name = "PictureBox" + i + j;
                    mass[i, j].Click += new EventHandler(massClikc);
                    mass[i, j].Parent = panel3;
                    if (n > 10 && n < 19)
                    {
                        mass[i, j].Image = forest;
                        mass[i, j].Труднопроходимость = 100;
                    }
                    else
                    {
                        if (n > 7 && n < 10 && x != 0 && y != 0)
                        {
                            mass[i, j].Image = mountain;
                            mass[i, j].проходимость = false;
                        }
                        else
                        {
                            mass[i, j].Image = trava;
                            mass[i, j].Труднопроходимость = 50;
                        }
                    }
                    x = x + 100;
                }
                y = y + 100;
                x = 0;
            }
            First.Location = new Point(0, 0);
            First.Height = 100;
            First.Width = 100;
            First.Name = "pctdd";
            First.MouseEnter += new EventHandler(Клик_на_героя);
            First.Parent = panel3;
            First.Image = knight;
            mass[o, r].Visible = false;
            создание_обьектов();
        }
        public void создание_обьектов() // создание_врагов и предметов
        {
            Random l = new Random();
            int x, y;
            x = 0;
            y = 0;
            for (int i = 0; i <= 20; i = i + 1)
            {
                for (int j = 0; j <= 20; j = j + 1)
                {
                    int n = l.Next(0, 20);
                    массив_врагов[i, j] = new PictureBox();
                    массив_врагов[i, j].Location = new Point(x, y);
                    предметы[i, j] = new Предметы();
                    if (n > 1 && n < 5 && x!= 0 && y!= 0)
                    {
                        массив_врагов[i, j] = new PictureBox();
                        массив_врагов[i, j].Location = new Point(x, y);
                        массив_врагов[i, j].Height = 100;
                        массив_врагов[i, j].Width = 100;
                        массив_врагов[i, j].Name = "PictureBox" + i + j;
                        массив_врагов[i, j].MouseEnter += new EventHandler(Клик_на_врага);
                        массив_врагов[i, j].Parent = panel3;
                        массив_врагов[i, j].Image = Враг;
                        массив_врагов[i, j].BringToFront();
                        вар[i, j] = new Враги();
                        вар[i, j].Существование = true;
                    }
                    if (n > 6 && n < 10 && x!= 0 && y!= 0)
                    {
                        предметы[i, j] = new Предметы();
                        предметы[i, j].Существование = true;
                        массив_предметов[i, j] = new PictureBox();
                        массив_предметов[i, j].Location = new Point(x, y);
                        массив_предметов[i, j].Height = 100;
                        массив_предметов[i, j].Width = 100;
                        массив_предметов[i, j].Name = "PictureBox" + i + j;
                        массив_предметов[i, j].MouseEnter += new EventHandler(Клик_на_предмет);
                        массив_предметов[i, j].Parent = panel3;
                        if (n > 6 && n <= 8 && x != 0 && y != 0)
                        {
                            массив_предметов[i, j].Image = Доп_атака;
                            предметы[i, j].тип_предмета = 1;
                        }
                        if (n > 8 && n <= 10 && x != 0 && y != 0)
                        {
                            массив_предметов[i, j].Image = Доп_защита;
                            предметы[i, j].тип_предмета = 2;
                        }
                        массив_предметов[i, j].BringToFront();
                    }
                    x = x + 100;
                }
                y = y + 100;
                x = 0;
            }
        }
        private void button2_Click_1(object sender, EventArgs e) // Выход
        {
            Application.Exit();
        }

        public void massClikc(object send, EventArgs e) // Перемещение по нажатию
        {
            a = 0;
            s = 0;
            PictureBox my = send as PictureBox;
            for (int i = 0; i <= 20; i = i + 1)
            {
                for (int j = 0; j <= 20; j = j + 1)
                {
                    if (my == mass[i, j])
                    {
                        a = i;
                        s = j;
                        goto too;
                    }
                }
            }
        too:
            int h = Math.Abs(a - o);
            int y = Math.Abs(s - r);
            timer1.Start();
        }
        int f;// отновится к timer1_Tick
        int i;// отновится к timer1_Tick
        public void timer1_Tick(object sender, EventArgs e)
        {
            // Если вправо
                if (f == 1)
                {
                    f = 0;
                    i = 4;
                    Перемещение_на_клетку(i);
                    return;
                }
                if (f == 2)
                {
                    f = 0;
                    i = 3;
                    Перемещение_на_клетку(i);
                    return;
                }
                if (s < r)
                {
                    i = 2;
                    Перемещение_на_клетку(i);
                    if (o < a)
                    {
                        f = 1;
                    }
                    if (o > a)
                    {
                        f = 2;
                    }
                    return;
                }
                if (s > r)
                {
                    i = 1;
                    Перемещение_на_клетку(i);
                    if (o < a)
                    {
                        f = 1;
                    }
                    if (o>a)
                    {
                        f = 2;
                    }
                    return;
                }
                if (a < o)
                {
                    i = 3;
                    Перемещение_на_клетку(i);
                    return;
                }
                if (a > o)
                {
                    i = 4;
                    Перемещение_на_клетку(i);
                    return;
                }
            if (o == a && r == s)
            {
                timer1.Stop();
            }
        }

        private void Отдых_Click(object sender, EventArgs e)
        {
            хар.Усталость = 0;
        }
    }
}
