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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_personal
            // 
            this.lst_personal.FormattingEnabled = true;
            this.lst_personal.Items.AddRange(new object[] {
            "Personal"});
            this.lst_personal.Location = new System.Drawing.Point(548, 61);
            this.lst_personal.Name = "lst_personal";
            this.lst_personal.Size = new System.Drawing.Size(120, 95);
            this.lst_personal.TabIndex = 0;
            // 
            // lst_buisnes
            // 
            this.lst_buisnes.FormattingEnabled = true;
            this.lst_buisnes.Items.AddRange(new object[] {
            "Buisness"});
            this.lst_buisnes.Location = new System.Drawing.Point(548, 235);
            this.lst_buisnes.Name = "lst_buisnes";
            this.lst_buisnes.Size = new System.Drawing.Size(120, 95);
            this.lst_buisnes.TabIndex = 1;
            // 
            // chk_type
            // 
            this.chk_type.AutoSize = true;
            this.chk_type.Location = new System.Drawing.Point(15, 349);
            this.chk_type.Name = "chk_type";
            this.chk_type.Size = new System.Drawing.Size(90, 17);
            this.chk_type.TabIndex = 2;
            this.chk_type.Text = "Contact Type";
            this.chk_type.UseVisualStyleBackColor = true;
            // 
            // txt_firName
            // 
            this.txt_firName.Location = new System.Drawing.Point(15, 35);
            this.txt_firName.Name = "txt_firName";
            this.txt_firName.Size = new System.Drawing.Size(100, 20);
            this.txt_firName.TabIndex = 3;
            this.txt_firName.Text = "First Name";
            // 
            // txt_EMail
            // 
            this.txt_EMail.Location = new System.Drawing.Point(12, 310);
            this.txt_EMail.Name = "txt_EMail";
            this.txt_EMail.Size = new System.Drawing.Size(100, 20);
            this.txt_EMail.TabIndex = 4;
            this.txt_EMail.Text = "E-Mail";
            // 
            // txt_contNote
            // 
            this.txt_contNote.Location = new System.Drawing.Point(173, 393);
            this.txt_contNote.Name = "txt_contNote";
            this.txt_contNote.Size = new System.Drawing.Size(100, 20);
            this.txt_contNote.TabIndex = 5;
            this.txt_contNote.Text = "Information";
            // 
            // txt_phoNum
            // 
            this.txt_phoNum.Location = new System.Drawing.Point(12, 224);
            this.txt_phoNum.Name = "txt_phoNum";
            this.txt_phoNum.Size = new System.Drawing.Size(100, 20);
            this.txt_phoNum.TabIndex = 6;
            this.txt_phoNum.Text = "Phone Number";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(15, 126);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(100, 20);
            this.txt_lastName.TabIndex = 7;
            this.txt_lastName.Text = "Last Name";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(632, 415);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add Entry";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(713, 415);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "Close Application";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Contact Information";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

