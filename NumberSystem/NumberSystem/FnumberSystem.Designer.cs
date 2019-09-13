namespace NumberSystem
{
    partial class FnumberSystem
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FnumberSystem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_interface5 = new System.Windows.Forms.Label();
            this.t_result = new System.Windows.Forms.TextBox();
            this.b_start = new System.Windows.Forms.Button();
            this.l_interface4 = new System.Windows.Forms.Label();
            this.t_system_exit = new System.Windows.Forms.TextBox();
            this.l_interface3 = new System.Windows.Forms.Label();
            this.t_system_entry = new System.Windows.Forms.TextBox();
            this.l_interface2 = new System.Windows.Forms.Label();
            this.t_number = new System.Windows.Forms.TextBox();
            this.l_interface1 = new System.Windows.Forms.Label();
            this.l_interface6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_interface6);
            this.groupBox1.Controls.Add(this.l_interface5);
            this.groupBox1.Controls.Add(this.t_result);
            this.groupBox1.Controls.Add(this.b_start);
            this.groupBox1.Controls.Add(this.l_interface4);
            this.groupBox1.Controls.Add(this.t_system_exit);
            this.groupBox1.Controls.Add(this.l_interface3);
            this.groupBox1.Controls.Add(this.t_system_entry);
            this.groupBox1.Controls.Add(this.l_interface2);
            this.groupBox1.Controls.Add(this.t_number);
            this.groupBox1.Controls.Add(this.l_interface1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Перевод чисел из одной системы счисления в другую";
            // 
            // l_interface5
            // 
            this.l_interface5.AutoSize = true;
            this.l_interface5.BackColor = System.Drawing.SystemColors.Highlight;
            this.l_interface5.Location = new System.Drawing.Point(6, 97);
            this.l_interface5.Name = "l_interface5";
            this.l_interface5.Size = new System.Drawing.Size(104, 23);
            this.l_interface5.TabIndex = 9;
            this.l_interface5.Text = "Результат:";
            // 
            // t_result
            // 
            this.t_result.Location = new System.Drawing.Point(6, 123);
            this.t_result.Multiline = true;
            this.t_result.Name = "t_result";
            this.t_result.Size = new System.Drawing.Size(690, 318);
            this.t_result.TabIndex = 8;
            // 
            // b_start
            // 
            this.b_start.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.b_start.Location = new System.Drawing.Point(508, 49);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(188, 35);
            this.b_start.TabIndex = 7;
            this.b_start.Text = "Начать перевод";
            this.b_start.UseVisualStyleBackColor = false;
            this.b_start.Click += new System.EventHandler(this.B_start_Click);
            // 
            // l_interface4
            // 
            this.l_interface4.AutoSize = true;
            this.l_interface4.BackColor = System.Drawing.SystemColors.Highlight;
            this.l_interface4.Location = new System.Drawing.Point(445, 52);
            this.l_interface4.Name = "l_interface4";
            this.l_interface4.Size = new System.Drawing.Size(57, 23);
            this.l_interface4.TabIndex = 6;
            this.l_interface4.Text = "- ную";
            // 
            // t_system_exit
            // 
            this.t_system_exit.Location = new System.Drawing.Point(393, 52);
            this.t_system_exit.Multiline = true;
            this.t_system_exit.Name = "t_system_exit";
            this.t_system_exit.Size = new System.Drawing.Size(46, 30);
            this.t_system_exit.TabIndex = 5;
            // 
            // l_interface3
            // 
            this.l_interface3.AutoSize = true;
            this.l_interface3.BackColor = System.Drawing.SystemColors.Highlight;
            this.l_interface3.Location = new System.Drawing.Point(316, 52);
            this.l_interface3.Name = "l_interface3";
            this.l_interface3.Size = new System.Drawing.Size(71, 23);
            this.l_interface3.TabIndex = 4;
            this.l_interface3.Text = "- ной в";
            // 
            // t_system_entry
            // 
            this.t_system_entry.Location = new System.Drawing.Point(264, 52);
            this.t_system_entry.Multiline = true;
            this.t_system_entry.Name = "t_system_entry";
            this.t_system_entry.Size = new System.Drawing.Size(46, 30);
            this.t_system_entry.TabIndex = 3;
            // 
            // l_interface2
            // 
            this.l_interface2.AutoSize = true;
            this.l_interface2.BackColor = System.Drawing.SystemColors.Highlight;
            this.l_interface2.Location = new System.Drawing.Point(228, 52);
            this.l_interface2.Name = "l_interface2";
            this.l_interface2.Size = new System.Drawing.Size(30, 23);
            this.l_interface2.TabIndex = 2;
            this.l_interface2.Text = "из";
            // 
            // t_number
            // 
            this.t_number.Location = new System.Drawing.Point(115, 52);
            this.t_number.Multiline = true;
            this.t_number.Name = "t_number";
            this.t_number.Size = new System.Drawing.Size(100, 30);
            this.t_number.TabIndex = 1;
            // 
            // l_interface1
            // 
            this.l_interface1.AutoSize = true;
            this.l_interface1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.l_interface1.Location = new System.Drawing.Point(7, 52);
            this.l_interface1.Name = "l_interface1";
            this.l_interface1.Size = new System.Drawing.Size(103, 23);
            this.l_interface1.TabIndex = 0;
            this.l_interface1.Text = "Перевести";
            // 
            // l_interface6
            // 
            this.l_interface6.AutoSize = true;
            this.l_interface6.BackColor = System.Drawing.SystemColors.Highlight;
            this.l_interface6.Location = new System.Drawing.Point(131, 26);
            this.l_interface6.Name = "l_interface6";
            this.l_interface6.Size = new System.Drawing.Size(61, 23);
            this.l_interface6.TabIndex = 10;
            this.l_interface6.Text = "число";
            // 
            // FnumberSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FnumberSystem";
            this.Text = "Системы счисления";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l_interface5;
        private System.Windows.Forms.TextBox t_result;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Label l_interface4;
        private System.Windows.Forms.TextBox t_system_exit;
        private System.Windows.Forms.Label l_interface3;
        private System.Windows.Forms.TextBox t_system_entry;
        private System.Windows.Forms.Label l_interface2;
        private System.Windows.Forms.TextBox t_number;
        private System.Windows.Forms.Label l_interface1;
        private System.Windows.Forms.Label l_interface6;
    }
}

