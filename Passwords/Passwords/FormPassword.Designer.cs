namespace Passwords
{
    partial class FormPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPassword));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btPassword3 = new System.Windows.Forms.Button();
            this.tblogin3 = new System.Windows.Forms.TextBox();
            this.llSite3 = new System.Windows.Forms.LinkLabel();
            this.btPassword2 = new System.Windows.Forms.Button();
            this.tblogin2 = new System.Windows.Forms.TextBox();
            this.llSite2 = new System.Windows.Forms.LinkLabel();
            this.llSite1 = new System.Windows.Forms.LinkLabel();
            this.tblogin1 = new System.Windows.Forms.TextBox();
            this.btPassword1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btPassword3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tblogin3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.llSite3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btPassword2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tblogin2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.llSite2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.llSite1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tblogin1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btPassword1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 105);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btPassword3
            // 
            this.btPassword3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btPassword3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPassword3.Location = new System.Drawing.Point(361, 73);
            this.btPassword3.Name = "btPassword3";
            this.btPassword3.Size = new System.Drawing.Size(174, 29);
            this.btPassword3.TabIndex = 8;
            this.btPassword3.Tag = "rety67iso";
            this.btPassword3.Text = "Пароль";
            this.btPassword3.UseVisualStyleBackColor = true;
            this.btPassword3.Click += new System.EventHandler(this.BtPassword1_Click);
            // 
            // tblogin3
            // 
            this.tblogin3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblogin3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tblogin3.Location = new System.Drawing.Point(182, 73);
            this.tblogin3.Multiline = true;
            this.tblogin3.Name = "tblogin3";
            this.tblogin3.ReadOnly = true;
            this.tblogin3.Size = new System.Drawing.Size(173, 29);
            this.tblogin3.TabIndex = 7;
            this.tblogin3.Text = "antonK@yandex.ru";
            this.tblogin3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tblogin3.Click += new System.EventHandler(this.Tblogin1_Click);
            // 
            // llSite3
            // 
            this.llSite3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llSite3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llSite3.Location = new System.Drawing.Point(3, 70);
            this.llSite3.Name = "llSite3";
            this.llSite3.Size = new System.Drawing.Size(173, 35);
            this.llSite3.TabIndex = 6;
            this.llSite3.TabStop = true;
            this.llSite3.Tag = "http://www.yandex.ru";
            this.llSite3.Text = "www.yandex.ru";
            this.llSite3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llSite3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlSite1_LinkClicked);
            // 
            // btPassword2
            // 
            this.btPassword2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btPassword2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPassword2.Location = new System.Drawing.Point(361, 38);
            this.btPassword2.Name = "btPassword2";
            this.btPassword2.Size = new System.Drawing.Size(174, 29);
            this.btPassword2.TabIndex = 5;
            this.btPassword2.Tag = "rty88io2";
            this.btPassword2.Text = "Пароль";
            this.btPassword2.UseVisualStyleBackColor = true;
            this.btPassword2.Click += new System.EventHandler(this.BtPassword1_Click);
            // 
            // tblogin2
            // 
            this.tblogin2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblogin2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tblogin2.Location = new System.Drawing.Point(182, 38);
            this.tblogin2.Multiline = true;
            this.tblogin2.Name = "tblogin2";
            this.tblogin2.ReadOnly = true;
            this.tblogin2.Size = new System.Drawing.Size(173, 29);
            this.tblogin2.TabIndex = 4;
            this.tblogin2.Tag = "";
            this.tblogin2.Text = "antonK@rambler.ru";
            this.tblogin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tblogin2.Click += new System.EventHandler(this.Tblogin1_Click);
            // 
            // llSite2
            // 
            this.llSite2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llSite2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llSite2.Location = new System.Drawing.Point(3, 35);
            this.llSite2.Name = "llSite2";
            this.llSite2.Size = new System.Drawing.Size(173, 35);
            this.llSite2.TabIndex = 3;
            this.llSite2.TabStop = true;
            this.llSite2.Tag = "http://www.rambler.ru";
            this.llSite2.Text = "www.rambler.ru";
            this.llSite2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llSite2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlSite1_LinkClicked);
            // 
            // llSite1
            // 
            this.llSite1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llSite1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llSite1.Location = new System.Drawing.Point(3, 0);
            this.llSite1.Name = "llSite1";
            this.llSite1.Size = new System.Drawing.Size(173, 35);
            this.llSite1.TabIndex = 0;
            this.llSite1.TabStop = true;
            this.llSite1.Tag = "http://gmail.com";
            this.llSite1.Text = "www.gmail.com";
            this.llSite1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llSite1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlSite1_LinkClicked);
            // 
            // tblogin1
            // 
            this.tblogin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblogin1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tblogin1.Location = new System.Drawing.Point(182, 3);
            this.tblogin1.Multiline = true;
            this.tblogin1.Name = "tblogin1";
            this.tblogin1.ReadOnly = true;
            this.tblogin1.Size = new System.Drawing.Size(173, 29);
            this.tblogin1.TabIndex = 1;
            this.tblogin1.Text = "antonK@gmail.com";
            this.tblogin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tblogin1.Click += new System.EventHandler(this.Tblogin1_Click);
            // 
            // btPassword1
            // 
            this.btPassword1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btPassword1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPassword1.Location = new System.Drawing.Point(361, 3);
            this.btPassword1.Name = "btPassword1";
            this.btPassword1.Size = new System.Drawing.Size(174, 29);
            this.btPassword1.TabIndex = 2;
            this.btPassword1.Tag = "rty89io";
            this.btPassword1.Text = "Пароль";
            this.btPassword1.UseVisualStyleBackColor = true;
            this.btPassword1.Click += new System.EventHandler(this.BtPassword1_Click);
            // 
            // FormPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 105);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мои пароли";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel llSite1;
        private System.Windows.Forms.TextBox tblogin1;
        private System.Windows.Forms.Button btPassword1;
        private System.Windows.Forms.Button btPassword3;
        private System.Windows.Forms.TextBox tblogin3;
        private System.Windows.Forms.LinkLabel llSite3;
        private System.Windows.Forms.Button btPassword2;
        private System.Windows.Forms.TextBox tblogin2;
        private System.Windows.Forms.LinkLabel llSite2;
    }
}

