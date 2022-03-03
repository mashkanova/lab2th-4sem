namespace lab2th
{
    partial class Member
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TrackBar();
            this.Expiriense = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.ComboBox();
            this.add_info = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // name_surname
            // 
            this.name_surname.Location = new System.Drawing.Point(111, 47);
            this.name_surname.Name = "name_surname";
            this.name_surname.Size = new System.Drawing.Size(100, 26);
            this.name_surname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Стаж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Должность";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(165, 124);
            this.Age.Maximum = 30;
            this.Age.Minimum = 25;
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(130, 69);
            this.Age.TabIndex = 5;
            this.Age.Value = 25;
            this.Age.Scroll += new System.EventHandler(this.Age_Scroll);
            // 
            // Expiriense
            // 
            this.Expiriense.Location = new System.Drawing.Point(147, 214);
            this.Expiriense.Name = "Expiriense";
            this.Expiriense.Size = new System.Drawing.Size(100, 26);
            this.Expiriense.TabIndex = 9;
            // 
            // Position
            // 
            this.Position.FormattingEnabled = true;
            this.Position.Items.AddRange(new object[] {
            "Пилот",
            "Стюардесса",
            "Помощник пилота"});
            this.Position.Location = new System.Drawing.Point(165, 316);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(121, 28);
            this.Position.TabIndex = 12;
            // 
            // add_info
            // 
            this.add_info.Location = new System.Drawing.Point(356, 359);
            this.add_info.Name = "add_info";
            this.add_info.Size = new System.Drawing.Size(128, 45);
            this.add_info.TabIndex = 33;
            this.add_info.Text = "add info";
            this.add_info.UseVisualStyleBackColor = true;
            this.add_info.Click += new System.EventHandler(this.add_info_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 26);
            this.textBox1.TabIndex = 34;
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add_info);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.Expiriense);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_surname);
            this.Controls.Add(this.label1);
            this.Name = "Member";
            this.Text = "Member";
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar Age;
        private System.Windows.Forms.TextBox Expiriense;
        private System.Windows.Forms.ComboBox Position;
        private System.Windows.Forms.Button add_info;
        private System.Windows.Forms.TextBox textBox1;
    }
}