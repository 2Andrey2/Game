namespace Игра
{
    partial class Окно_боя
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Окно_боя));
            this.Атака = new System.Windows.Forms.Button();
            this.Отсупаем = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Уклонение = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Защита = new System.Windows.Forms.Button();
            this.Уселение_атаки = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Атака
            // 
            this.Атака.Location = new System.Drawing.Point(12, 303);
            this.Атака.Name = "Атака";
            this.Атака.Size = new System.Drawing.Size(100, 50);
            this.Атака.TabIndex = 0;
            this.Атака.Text = "Атака";
            this.Атака.UseVisualStyleBackColor = true;
            this.Атака.Click += new System.EventHandler(this.Атака_Click);
            // 
            // Отсупаем
            // 
            this.Отсупаем.Location = new System.Drawing.Point(581, 303);
            this.Отсупаем.Name = "Отсупаем";
            this.Отсупаем.Size = new System.Drawing.Size(100, 50);
            this.Отсупаем.TabIndex = 1;
            this.Отсупаем.Text = "Отсупаем";
            this.Отсупаем.UseVisualStyleBackColor = true;
            this.Отсупаем.Click += new System.EventHandler(this.Отсупаем_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Атака";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(414, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Атака";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(498, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Враг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(138, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "Герой";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(414, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Здоровье";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(414, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 33);
            this.label6.TabIndex = 3;
            this.label6.Text = "Броня";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 33);
            this.label7.TabIndex = 3;
            this.label7.Text = "Броня";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 33);
            this.label8.TabIndex = 3;
            this.label8.Text = "Здоровье";
            // 
            // Уклонение
            // 
            this.Уклонение.Location = new System.Drawing.Point(34, 244);
            this.Уклонение.Name = "Уклонение";
            this.Уклонение.Size = new System.Drawing.Size(99, 43);
            this.Уклонение.TabIndex = 5;
            this.Уклонение.Text = "Уклонение";
            this.Уклонение.UseVisualStyleBackColor = true;
            this.Уклонение.Click += new System.EventHandler(this.Уклонение_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 20F);
            this.textBox4.Location = new System.Drawing.Point(567, 184);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ShortcutsEnabled = false;
            this.textBox4.Size = new System.Drawing.Size(100, 40);
            this.textBox4.TabIndex = 4;
            this.textBox4.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.textBox1.Location = new System.Drawing.Point(567, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(100, 40);
            this.textBox1.TabIndex = 4;
            this.textBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 20F);
            this.textBox3.Location = new System.Drawing.Point(567, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ShortcutsEnabled = false;
            this.textBox3.Size = new System.Drawing.Size(100, 40);
            this.textBox3.TabIndex = 4;
            this.textBox3.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Tahoma", 20F);
            this.textBox6.Location = new System.Drawing.Point(176, 184);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.ShortcutsEnabled = false;
            this.textBox6.Size = new System.Drawing.Size(100, 40);
            this.textBox6.TabIndex = 4;
            this.textBox6.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.textBox2.Location = new System.Drawing.Point(176, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(100, 40);
            this.textBox2.TabIndex = 4;
            this.textBox2.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Tahoma", 20F);
            this.textBox5.Location = new System.Drawing.Point(176, 71);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.ShortcutsEnabled = false;
            this.textBox5.Size = new System.Drawing.Size(100, 40);
            this.textBox5.TabIndex = 4;
            this.textBox5.TabStop = false;
            // 
            // Защита
            // 
            this.Защита.Location = new System.Drawing.Point(177, 244);
            this.Защита.Name = "Защита";
            this.Защита.Size = new System.Drawing.Size(99, 43);
            this.Защита.TabIndex = 5;
            this.Защита.Text = "Защита";
            this.Защита.UseVisualStyleBackColor = true;
            this.Защита.Click += new System.EventHandler(this.Защита_Click);
            // 
            // Уселение_атаки
            // 
            this.Уселение_атаки.Location = new System.Drawing.Point(311, 244);
            this.Уселение_атаки.Name = "Уселение_атаки";
            this.Уселение_атаки.Size = new System.Drawing.Size(99, 43);
            this.Уселение_атаки.TabIndex = 5;
            this.Уселение_атаки.Text = "Уселение атака";
            this.Уселение_атаки.UseVisualStyleBackColor = true;
            this.Уселение_атаки.Click += new System.EventHandler(this.Уселение_атаки_Click);
            // 
            // Окно_боя
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 365);
            this.Controls.Add(this.Уселение_атаки);
            this.Controls.Add(this.Защита);
            this.Controls.Add(this.Уклонение);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Отсупаем);
            this.Controls.Add(this.Атака);
            this.Name = "Окно_боя";
            this.Text = "Окно_боя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Атака;
        private System.Windows.Forms.Button Отсупаем;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Уклонение;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button Защита;
        private System.Windows.Forms.Button Уселение_атаки;
    }
}