namespace AdressBook
{
    partial class frm_main
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
            this.lst_personal = new System.Windows.Forms.ListBox();
            this.lst_buisnes = new System.Windows.Forms.ListBox();
            this.chk_type = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lst_personal
            // 
            this.lst_personal.FormattingEnabled = true;
            this.lst_personal.Location = new System.Drawing.Point(138, 12);
            this.lst_personal.Name = "lst_personal";
            this.lst_personal.Size = new System.Drawing.Size(120, 95);
            this.lst_personal.TabIndex = 0;
            // 
            // lst_buisnes
            // 
            this.lst_buisnes.FormattingEnabled = true;
            this.lst_buisnes.Location = new System.Drawing.Point(12, 12);
            this.lst_buisnes.Name = "lst_buisnes";
            this.lst_buisnes.Size = new System.Drawing.Size(120, 95);
            this.lst_buisnes.TabIndex = 1;
            // 
            // chk_type
            // 
            this.chk_type.AutoSize = true;
            this.chk_type.Location = new System.Drawing.Point(284, 13);
            this.chk_type.Name = "chk_type";
            this.chk_type.Size = new System.Drawing.Size(80, 17);
            this.chk_type.TabIndex = 2;
            this.chk_type.Text = "checkBox1";
            this.chk_type.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(264, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(272, 52);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(280, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chk_type);
            this.Controls.Add(this.lst_buisnes);
            this.Controls.Add(this.lst_personal);
            this.Name = "frm_main";
            this.Text = "Primary Form";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_personal;
        private System.Windows.Forms.ListBox lst_buisnes;
        private System.Windows.Forms.CheckBox chk_type;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox4;
    }
}

