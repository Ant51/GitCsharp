namespace ArithmeticOperations
{
    partial class F_ArithmeticOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ArithmeticOperations));
            this.tb_number1 = new System.Windows.Forms.TextBox();
            this.gB_interface = new System.Windows.Forms.GroupBox();
            this.l_interface5 = new System.Windows.Forms.Label();
            this.l_interface4 = new System.Windows.Forms.Label();
            this.l_interface3 = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.b_calculate = new System.Windows.Forms.Button();
            this.l_interface1 = new System.Windows.Forms.Label();
            this.tb_number2 = new System.Windows.Forms.TextBox();
            this.lb_NumericSystem = new System.Windows.Forms.ListBox();
            this.lb_OperationSelection = new System.Windows.Forms.ListBox();
            this.l_interface6 = new System.Windows.Forms.Label();
            this.l_interface7 = new System.Windows.Forms.Label();
            this.gB_interface.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_number1
            // 
            this.tb_number1.Enabled = false;
            this.tb_number1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_number1.Location = new System.Drawing.Point(6, 138);
            this.tb_number1.MaxLength = 8;
            this.tb_number1.Multiline = true;
            this.tb_number1.Name = "tb_number1";
            this.tb_number1.Size = new System.Drawing.Size(100, 29);
            this.tb_number1.TabIndex = 0;
            this.tb_number1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_press);
            // 
            // gB_interface
            // 
            this.gB_interface.Controls.Add(this.l_interface7);
            this.gB_interface.Controls.Add(this.l_interface6);
            this.gB_interface.Controls.Add(this.lb_OperationSelection);
            this.gB_interface.Controls.Add(this.lb_NumericSystem);
            this.gB_interface.Controls.Add(this.l_interface5);
            this.gB_interface.Controls.Add(this.l_interface4);
            this.gB_interface.Controls.Add(this.l_interface3);
            this.gB_interface.Controls.Add(this.tb_result);
            this.gB_interface.Controls.Add(this.b_calculate);
            this.gB_interface.Controls.Add(this.l_interface1);
            this.gB_interface.Controls.Add(this.tb_number2);
            this.gB_interface.Controls.Add(this.tb_number1);
            this.gB_interface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gB_interface.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gB_interface.Location = new System.Drawing.Point(0, 0);
            this.gB_interface.Name = "gB_interface";
            this.gB_interface.Size = new System.Drawing.Size(872, 467);
            this.gB_interface.TabIndex = 1;
            this.gB_interface.TabStop = false;
            this.gB_interface.Text = "Арифметические операции с числами в позиционной системе счисления";
            // 
            // l_interface5
            // 
            this.l_interface5.AutoSize = true;
            this.l_interface5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_interface5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.l_interface5.Location = new System.Drawing.Point(287, 112);
            this.l_interface5.Name = "l_interface5";
            this.l_interface5.Size = new System.Drawing.Size(79, 23);
            this.l_interface5.TabIndex = 10;
            this.l_interface5.Text = "Число 2";
            // 
            // l_interface4
            // 
            this.l_interface4.AutoSize = true;
            this.l_interface4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_interface4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.l_interface4.Location = new System.Drawing.Point(6, 110);
            this.l_interface4.Name = "l_interface4";
            this.l_interface4.Size = new System.Drawing.Size(79, 23);
            this.l_interface4.TabIndex = 9;
            this.l_interface4.Text = "Число 1";
            // 
            // l_interface3
            // 
            this.l_interface3.AutoSize = true;
            this.l_interface3.Location = new System.Drawing.Point(5, 230);
            this.l_interface3.Name = "l_interface3";
            this.l_interface3.Size = new System.Drawing.Size(97, 25);
            this.l_interface3.TabIndex = 8;
            this.l_interface3.Text = "Решение";
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(4, 258);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(856, 203);
            this.tb_result.TabIndex = 7;
            this.tb_result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_result_KeyPress);
            // 
            // b_calculate
            // 
            this.b_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_calculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.b_calculate.Location = new System.Drawing.Point(374, 129);
            this.b_calculate.Name = "b_calculate";
            this.b_calculate.Size = new System.Drawing.Size(129, 38);
            this.b_calculate.TabIndex = 6;
            this.b_calculate.Text = "Вычислить";
            this.b_calculate.UseVisualStyleBackColor = true;
            this.b_calculate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B_calculate_MouseDown);
            // 
            // l_interface1
            // 
            this.l_interface1.AutoSize = true;
            this.l_interface1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_interface1.Location = new System.Drawing.Point(7, 38);
            this.l_interface1.Name = "l_interface1";
            this.l_interface1.Size = new System.Drawing.Size(377, 23);
            this.l_interface1.TabIndex = 3;
            this.l_interface1.Text = "Сначало выберите систему для рассчета:";
            // 
            // tb_number2
            // 
            this.tb_number2.Enabled = false;
            this.tb_number2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_number2.Location = new System.Drawing.Point(268, 138);
            this.tb_number2.MaxLength = 8;
            this.tb_number2.Multiline = true;
            this.tb_number2.Name = "tb_number2";
            this.tb_number2.Size = new System.Drawing.Size(100, 29);
            this.tb_number2.TabIndex = 2;
            this.tb_number2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_press);
            // 
            // lb_NumericSystem
            // 
            this.lb_NumericSystem.FormattingEnabled = true;
            this.lb_NumericSystem.ItemHeight = 25;
            this.lb_NumericSystem.Items.AddRange(new object[] {
            "2 - я",
            "8 - я",
            "10 - я",
            "16 - ричная"});
            this.lb_NumericSystem.Location = new System.Drawing.Point(10, 64);
            this.lb_NumericSystem.Name = "lb_NumericSystem";
            this.lb_NumericSystem.Size = new System.Drawing.Size(139, 29);
            this.lb_NumericSystem.TabIndex = 11;
            this.lb_NumericSystem.SelectedIndexChanged += new System.EventHandler(this.Lb_NumericSystem_SelectedIndexChanged);
            // 
            // lb_OperationSelection
            // 
            this.lb_OperationSelection.Enabled = false;
            this.lb_OperationSelection.FormattingEnabled = true;
            this.lb_OperationSelection.ItemHeight = 25;
            this.lb_OperationSelection.Items.AddRange(new object[] {
            "прибавить к",
            "отнять"});
            this.lb_OperationSelection.Location = new System.Drawing.Point(112, 138);
            this.lb_OperationSelection.Name = "lb_OperationSelection";
            this.lb_OperationSelection.Size = new System.Drawing.Size(150, 29);
            this.lb_OperationSelection.TabIndex = 12;
            this.lb_OperationSelection.SelectedIndexChanged += new System.EventHandler(this.Lb_OperationSelection_SelectedIndexChanged);
            // 
            // l_interface6
            // 
            this.l_interface6.AutoSize = true;
            this.l_interface6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_interface6.ForeColor = System.Drawing.Color.Maroon;
            this.l_interface6.Location = new System.Drawing.Point(12, 198);
            this.l_interface6.Name = "l_interface6";
            this.l_interface6.Size = new System.Drawing.Size(804, 23);
            this.l_interface6.TabIndex = 13;
            this.l_interface6.Text = "Мы работаем с неотрицательными действительными числами не длиннее 8-ми символов";
            // 
            // l_interface7
            // 
            this.l_interface7.AutoSize = true;
            this.l_interface7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_interface7.ForeColor = System.Drawing.Color.Red;
            this.l_interface7.Location = new System.Drawing.Point(12, 175);
            this.l_interface7.Name = "l_interface7";
            this.l_interface7.Size = new System.Drawing.Size(137, 23);
            this.l_interface7.TabIndex = 14;
            this.l_interface7.Text = "Напоминание:";
            // 
            // F_ArithmeticOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(872, 467);
            this.Controls.Add(this.gB_interface);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_ArithmeticOperations";
            this.Text = "Арифметические операции";
            this.gB_interface.ResumeLayout(false);
            this.gB_interface.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_number1;
        private System.Windows.Forms.GroupBox gB_interface;
        private System.Windows.Forms.Label l_interface1;
        private System.Windows.Forms.TextBox tb_number2;
        private System.Windows.Forms.Label l_interface3;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Button b_calculate;
        private System.Windows.Forms.Label l_interface5;
        private System.Windows.Forms.Label l_interface4;
        private System.Windows.Forms.ListBox lb_NumericSystem;
        private System.Windows.Forms.ListBox lb_OperationSelection;
        private System.Windows.Forms.Label l_interface6;
        private System.Windows.Forms.Label l_interface7;
    }
}

