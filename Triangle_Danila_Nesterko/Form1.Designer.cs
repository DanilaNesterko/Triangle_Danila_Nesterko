namespace Triangle_Danila_Nesterko
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.run_button = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.txtH = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.form_button = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// run_button
			// 
			this.run_button.BackColor = System.Drawing.Color.LightCoral;
			this.run_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.run_button.FlatAppearance.BorderSize = 7;
			this.run_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.run_button.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.run_button.ForeColor = System.Drawing.Color.Black;
			this.run_button.Location = new System.Drawing.Point(462, 12);
			this.run_button.Name = "run_button";
			this.run_button.Size = new System.Drawing.Size(260, 86);
			this.run_button.TabIndex = 0;
			this.run_button.Text = "Запуск";
			this.run_button.UseVisualStyleBackColor = false;
			this.run_button.Click += new System.EventHandler(this.run_button_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(462, 264);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(129, 152);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listView1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
			this.listView1.Location = new System.Drawing.Point(12, 12);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(398, 230);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Поле";
			this.columnHeader1.Width = 172;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Значение";
			this.columnHeader2.Width = 192;
			// 
			// txtA
			// 
			this.txtA.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
			this.txtA.Location = new System.Drawing.Point(299, 248);
			this.txtA.Multiline = true;
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(111, 32);
			this.txtA.TabIndex = 3;
			// 
			// txtB
			// 
			this.txtB.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
			this.txtB.Location = new System.Drawing.Point(299, 297);
			this.txtB.Multiline = true;
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(111, 32);
			this.txtB.TabIndex = 4;
			// 
			// txtC
			// 
			this.txtC.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
			this.txtC.Location = new System.Drawing.Point(299, 345);
			this.txtC.Multiline = true;
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(111, 32);
			this.txtC.TabIndex = 5;
			// 
			// txtH
			// 
			this.txtH.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
			this.txtH.Location = new System.Drawing.Point(299, 394);
			this.txtH.Multiline = true;
			this.txtH.Name = "txtH";
			this.txtH.Size = new System.Drawing.Size(111, 32);
			this.txtH.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(179, 258);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 22);
			this.label1.TabIndex = 7;
			this.label1.Text = "Сторона А";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(179, 307);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 22);
			this.label2.TabIndex = 8;
			this.label2.Text = "Сторона В";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(180, 355);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 22);
			this.label3.TabIndex = 9;
			this.label3.Text = "Сторона С";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(179, 394);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 22);
			this.label4.TabIndex = 10;
			this.label4.Text = "Высота h";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
			this.radioButton1.Location = new System.Drawing.Point(597, 286);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(117, 26);
			this.radioButton1.TabIndex = 11;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "3 стороны";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
			this.radioButton2.Location = new System.Drawing.Point(597, 324);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(193, 26);
			this.radioButton2.TabIndex = 12;
			this.radioButton2.Text = "1 сторона и высота";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// form_button
			// 
			this.form_button.BackColor = System.Drawing.Color.LightCoral;
			this.form_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.form_button.FlatAppearance.BorderSize = 7;
			this.form_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.form_button.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.form_button.ForeColor = System.Drawing.Color.Black;
			this.form_button.Location = new System.Drawing.Point(462, 118);
			this.form_button.Name = "form_button";
			this.form_button.Size = new System.Drawing.Size(260, 86);
			this.form_button.TabIndex = 13;
			this.form_button.Text = "Своя форма";
			this.form_button.UseVisualStyleBackColor = false;
			this.form_button.Click += new System.EventHandler(this.form_button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(799, 440);
			this.Controls.Add(this.form_button);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtH);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.run_button);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Работа с треугольниками";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.TextBox txtH;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Button form_button;
	}
}

