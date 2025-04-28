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
            this.txt_firName = new System.Windows.Forms.TextBox();
            this.txt_EMail = new System.Windows.Forms.TextBox();
            this.txt_contNote = new System.Windows.Forms.TextBox();
            this.txt_phoNum = new System.Windows.Forms.MaskedTextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
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
            this.chk_type.Location = new System.Drawing.Point(12, 125);
            this.chk_type.Name = "chk_type";
            this.chk_type.Size = new System.Drawing.Size(80, 17);
            this.chk_type.TabIndex = 2;
            this.chk_type.Text = "checkBox1";
            this.chk_type.UseVisualStyleBackColor = true;
            // 
            // txt_firName
            // 
            this.txt_firName.Location = new System.Drawing.Point(12, 169);
            this.txt_firName.Name = "txt_firName";
            this.txt_firName.Size = new System.Drawing.Size(100, 20);
            this.txt_firName.TabIndex = 3;
            // 
            // txt_EMail
            // 
            this.txt_EMail.Location = new System.Drawing.Point(12, 286);
            this.txt_EMail.Name = "txt_EMail";
            this.txt_EMail.Size = new System.Drawing.Size(100, 20);
            this.txt_EMail.TabIndex = 4;
            // 
            // txt_contNote
            // 
            this.txt_contNote.Location = new System.Drawing.Point(264, 44);
            this.txt_contNote.Name = "txt_contNote";
            this.txt_contNote.Size = new System.Drawing.Size(100, 20);
            this.txt_contNote.TabIndex = 5;
            // 
            // txt_phoNum
            // 
            this.txt_phoNum.Location = new System.Drawing.Point(12, 363);
            this.txt_phoNum.Name = "txt_phoNum";
            this.txt_phoNum.Size = new System.Drawing.Size(100, 20);
            this.txt_phoNum.TabIndex = 6;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(12, 211);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(100, 20);
            this.txt_lastName.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(138, 167);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "button1";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(138, 211);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "button3";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_phoNum);
            this.Controls.Add(this.txt_contNote);
            this.Controls.Add(this.txt_EMail);
            this.Controls.Add(this.txt_firName);
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
        private System.Windows.Forms.TextBox txt_firName;
        private System.Windows.Forms.TextBox txt_EMail;
        private System.Windows.Forms.TextBox txt_contNote;
        private System.Windows.Forms.MaskedTextBox txt_phoNum;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
    }
}

