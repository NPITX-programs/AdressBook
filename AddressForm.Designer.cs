namespace AdressBook
{
    partial class AddressForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_personal
            // 
            this.lst_personal.FormattingEnabled = true;
            this.lst_personal.Location = new System.Drawing.Point(10, 44);
            this.lst_personal.Name = "lst_personal";
            this.lst_personal.Size = new System.Drawing.Size(184, 160);
            this.lst_personal.TabIndex = 0;
            this.lst_personal.TabStop = false;
            this.lst_personal.Tag = "per";
            this.lst_personal.SelectedIndexChanged += new System.EventHandler(this.select_contact);
            // 
            // lst_buisnes
            // 
            this.lst_buisnes.FormattingEnabled = true;
            this.lst_buisnes.Location = new System.Drawing.Point(10, 260);
            this.lst_buisnes.Name = "lst_buisnes";
            this.lst_buisnes.Size = new System.Drawing.Size(184, 160);
            this.lst_buisnes.TabIndex = 1;
            this.lst_buisnes.TabStop = false;
            this.lst_buisnes.Tag = "bui";
            this.lst_buisnes.SelectedIndexChanged += new System.EventHandler(this.select_contact);
            // 
            // chk_type
            // 
            this.chk_type.AutoSize = true;
            this.chk_type.Location = new System.Drawing.Point(0, 232);
            this.chk_type.Name = "chk_type";
            this.chk_type.Size = new System.Drawing.Size(90, 17);
            this.chk_type.TabIndex = 5;
            this.chk_type.Text = "Contact Type";
            this.toolTip1.SetToolTip(this.chk_type, "Please mark the contact type\r\n\r\nA checkmark means \"buisness\"\r\nNo Checkmark means " +
        "\"personal\"");
            this.chk_type.UseVisualStyleBackColor = true;
            // 
            // txt_firName
            // 
            this.txt_firName.Location = new System.Drawing.Point(6, 32);
            this.txt_firName.Name = "txt_firName";
            this.txt_firName.Size = new System.Drawing.Size(100, 20);
            this.txt_firName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_firName, "Please enter a First Name. Must be at least 1 character");
            // 
            // txt_EMail
            // 
            this.txt_EMail.Location = new System.Drawing.Point(0, 138);
            this.txt_EMail.Name = "txt_EMail";
            this.txt_EMail.Size = new System.Drawing.Size(100, 20);
            this.txt_EMail.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txt_EMail, "Please enter an e-mail address\r\nmust be at least 1 character");
            // 
            // txt_contNote
            // 
            this.txt_contNote.AcceptsReturn = true;
            this.txt_contNote.Location = new System.Drawing.Point(0, 298);
            this.txt_contNote.Multiline = true;
            this.txt_contNote.Name = "txt_contNote";
            this.txt_contNote.Size = new System.Drawing.Size(188, 122);
            this.txt_contNote.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txt_contNote, "Please input in whatever information about the contact\r\nmust be at least 1 charac" +
        "ter");
            // 
            // txt_phoNum
            // 
            this.txt_phoNum.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_phoNum.Location = new System.Drawing.Point(0, 191);
            this.txt_phoNum.Mask = "(999) 000-0000";
            this.txt_phoNum.Name = "txt_phoNum";
            this.txt_phoNum.Size = new System.Drawing.Size(100, 20);
            this.txt_phoNum.TabIndex = 4;
            this.txt_phoNum.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.toolTip1.SetToolTip(this.txt_phoNum, "Please input a phone number");
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(6, 84);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(100, 20);
            this.txt_lastName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_lastName, "Please Input a Last Name. Must be at least 1 character");
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(125, 6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.TabStop = false;
            this.btn_add.Text = "Add Entry";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(12, -1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(113, 23);
            this.btn_close.TabIndex = 10;
            this.btn_close.TabStop = false;
            this.btn_close.Text = "Close Application";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Contact Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Personal Contacts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Buisness Contacts";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lst_personal);
            this.groupBox1.Controls.Add(this.lst_buisnes);
            this.groupBox1.Location = new System.Drawing.Point(588, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 426);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_firName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_phoNum);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chk_type);
            this.groupBox2.Controls.Add(this.txt_EMail);
            this.groupBox2.Controls.Add(this.txt_contNote);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_lastName);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 410);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_close);
            this.Name = "AddressForm";
            this.Text = "Primary Form";
            this.Load += new System.EventHandler(this.Frm_main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

