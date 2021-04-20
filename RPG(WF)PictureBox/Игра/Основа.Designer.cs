namespace Игра
{
    partial class Основа
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Отдых = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Генерация = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Вверх = new System.Windows.Forms.Button();
            this.Влево = new System.Windows.Forms.Button();
            this.Вправо = new System.Windows.Forms.Button();
            this.Вниз = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.Отдых);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.Генерация);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 734);
            this.panel2.TabIndex = 1;
            // 
            // Отдых
            // 
            this.Отдых.Location = new System.Drawing.Point(124, 247);
            this.Отдых.Name = "Отдых";
            this.Отдых.Size = new System.Drawing.Size(99, 34);
            this.Отдых.TabIndex = 4;
            this.Отдых.Text = "Отдых";
            this.Отдых.UseVisualStyleBackColor = true;
            this.Отдых.Click += new System.EventHandler(this.Отдых_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Генерация
            // 
            this.Генерация.Location = new System.Drawing.Point(124, 184);
            this.Генерация.Name = "Генерация";
            this.Генерация.Size = new System.Drawing.Size(99, 31);
            this.Генерация.TabIndex = 2;
            this.Генерация.Text = "Генерация";
            this.Генерация.UseVisualStyleBackColor = true;
            this.Генерация.Click += new System.EventHandler(this.Генерация_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Вверх);
            this.panel1.Controls.Add(this.Влево);
            this.panel1.Controls.Add(this.Вправо);
            this.panel1.Controls.Add(this.Вниз);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 359);
            this.panel1.TabIndex = 1;
            // 
            // Вверх
            // 
            this.Вверх.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Вверх.Location = new System.Drawing.Point(71, 72);
            this.Вверх.Name = "Вверх";
            this.Вверх.Size = new System.Drawing.Size(150, 60);
            this.Вверх.TabIndex = 3;
            this.Вверх.Text = "Вверх";
            this.Вверх.UseVisualStyleBackColor = true;
            this.Вверх.Click += new System.EventHandler(this.button4_Click);
            // 
            // Влево
            // 
            this.Влево.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Влево.Location = new System.Drawing.Point(10, 147);
            this.Влево.Name = "Влево";
            this.Влево.Size = new System.Drawing.Size(121, 60);
            this.Влево.TabIndex = 2;
            this.Влево.Text = "Влево";
            this.Влево.UseVisualStyleBackColor = true;
            this.Влево.Click += new System.EventHandler(this.button3_Click);
            // 
            // Вправо
            // 
            this.Вправо.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Вправо.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Вправо.Location = new System.Drawing.Point(151, 147);
            this.Вправо.Name = "Вправо";
            this.Вправо.Size = new System.Drawing.Size(121, 60);
            this.Вправо.TabIndex = 1;
            this.Вправо.Text = "Вправо";
            this.Вправо.UseVisualStyleBackColor = true;
            this.Вправо.Click += new System.EventHandler(this.button2_Click);
            // 
            // Вниз
            // 
            this.Вниз.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Вниз.Location = new System.Drawing.Point(71, 224);
            this.Вниз.Name = "Вниз";
            this.Вниз.Size = new System.Drawing.Size(150, 60);
            this.Вниз.TabIndex = 0;
            this.Вниз.Text = "Вниз";
            this.Вниз.UseVisualStyleBackColor = true;
            this.Вниз.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipTitle = "Cостояние героя";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(300, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 700);
            this.panel3.TabIndex = 2;
            // 
            // Основа
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 734);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Основа";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button Вверх;
        public System.Windows.Forms.Button Влево;
        public System.Windows.Forms.Button Вправо;
        public System.Windows.Forms.Button Вниз;
        public System.Windows.Forms.Button Генерация;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Отдых;
        public System.Windows.Forms.Panel panel3;


    }
}



