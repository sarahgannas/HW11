namespace employees
{
    partial class Form1
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
            this.TXT_FNAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_LNAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CMB_SECTION = new System.Windows.Forms.ComboBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.TXT_BOD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_ADRESS = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_FNAME
            // 
            this.TXT_FNAME.Location = new System.Drawing.Point(413, 68);
            this.TXT_FNAME.Margin = new System.Windows.Forms.Padding(6);
            this.TXT_FNAME.Name = "TXT_FNAME";
            this.TXT_FNAME.Size = new System.Drawing.Size(180, 40);
            this.TXT_FNAME.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "الاسم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "اللقب";
            // 
            // TXT_LNAME
            // 
            this.TXT_LNAME.Location = new System.Drawing.Point(413, 140);
            this.TXT_LNAME.Margin = new System.Windows.Forms.Padding(6);
            this.TXT_LNAME.Name = "TXT_LNAME";
            this.TXT_LNAME.Size = new System.Drawing.Size(180, 40);
            this.TXT_LNAME.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "رقم القيد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "القسم";
            // 
            // CMB_SECTION
            // 
            this.CMB_SECTION.FormattingEnabled = true;
            this.CMB_SECTION.Items.AddRange(new object[] {
            "حاسب",
            "تحكم",
            "اتصالات"});
            this.CMB_SECTION.Location = new System.Drawing.Point(413, 300);
            this.CMB_SECTION.Name = "CMB_SECTION";
            this.CMB_SECTION.Size = new System.Drawing.Size(180, 41);
            this.CMB_SECTION.TabIndex = 8;
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(149, 415);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 62;
            this.DGV.Size = new System.Drawing.Size(963, 150);
            this.DGV.TabIndex = 9;
            this.DGV.Click += new System.EventHandler(this.DGV_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(769, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "اضافة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID";
            // 
            // TXT_ID
            // 
            this.TXT_ID.Location = new System.Drawing.Point(413, 15);
            this.TXT_ID.Margin = new System.Windows.Forms.Padding(6);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.Size = new System.Drawing.Size(180, 40);
            this.TXT_ID.TabIndex = 12;
            this.TXT_ID.TextChanged += new System.EventHandler(this.TXT_ID_TextChanged);
            // 
            // TXT_BOD
            // 
            this.TXT_BOD.Location = new System.Drawing.Point(404, 195);
            this.TXT_BOD.Name = "TXT_BOD";
            this.TXT_BOD.Size = new System.Drawing.Size(200, 40);
            this.TXT_BOD.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 33);
            this.label6.TabIndex = 16;
            this.label6.Text = "العنوان";
            // 
            // TXT_ADRESS
            // 
            this.TXT_ADRESS.Location = new System.Drawing.Point(413, 251);
            this.TXT_ADRESS.Margin = new System.Windows.Forms.Padding(6);
            this.TXT_ADRESS.Name = "TXT_ADRESS";
            this.TXT_ADRESS.Size = new System.Drawing.Size(180, 40);
            this.TXT_ADRESS.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(463, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 43);
            this.button3.TabIndex = 17;
            this.button3.Text = "تعديل";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 371);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 40);
            this.textBox1.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(149, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 43);
            this.button4.TabIndex = 19;
            this.button4.Text = "بحث";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(149, 328);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 43);
            this.button5.TabIndex = 20;
            this.button5.Text = "استعادة";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 845);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXT_ADRESS);
            this.Controls.Add(this.TXT_BOD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_ID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.CMB_SECTION);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_LNAME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_FNAME);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_FNAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_LNAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CMB_SECTION;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.DateTimePicker TXT_BOD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_ADRESS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

