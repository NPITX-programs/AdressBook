﻿namespace AdressBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chk_type = new System.Windows.Forms.CheckBox();
            this.txt_firName = new System.Windows.Forms.TextBox();
            this.txt_EMail = new System.Windows.Forms.TextBox();
            this.txt_contNote = new System.Windows.Forms.TextBox();
            this.txt_phoNum = new System.Windows.Forms.MaskedTextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_contacts = new System.Windows.Forms.DataGridView();
            this.col_firName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phoNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_contType = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_contNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contacts)).BeginInit();
            this.SuspendLayout();
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
            this.toolTip1.SetToolTip(this.btn_add, "Add the entry into the lists\r\nthis saves it into the list that loads on start\r\n\r\n" +
        "");
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
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
            this.groupBox2.Size = new System.Drawing.Size(200, 420);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "con";
            this.saveFileDialog1.Title = "Save As";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.btn_svAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.btn_op_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // dgv_contacts
            // 
            this.dgv_contacts.AllowUserToAddRows = false;
            this.dgv_contacts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_contacts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_contacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_contacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_firName,
            this.col_lastName,
            this.col_EMail,
            this.col_phoNum,
            this.col_contType,
            this.col_contNotes});
            this.dgv_contacts.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_contacts.Location = new System.Drawing.Point(225, 24);
            this.dgv_contacts.MultiSelect = false;
            this.dgv_contacts.Name = "dgv_contacts";
            this.dgv_contacts.ReadOnly = true;
            this.dgv_contacts.RowHeadersVisible = false;
            this.dgv_contacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_contacts.Size = new System.Drawing.Size(672, 426);
            this.dgv_contacts.TabIndex = 18;
            this.dgv_contacts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_contacts_CellClick);
            // 
            // col_firName
            // 
            this.col_firName.HeaderText = "First Name";
            this.col_firName.Name = "col_firName";
            this.col_firName.ReadOnly = true;
            this.col_firName.Width = 76;
            // 
            // col_lastName
            // 
            this.col_lastName.HeaderText = "Last Name";
            this.col_lastName.Name = "col_lastName";
            this.col_lastName.ReadOnly = true;
            this.col_lastName.Width = 77;
            // 
            // col_EMail
            // 
            this.col_EMail.HeaderText = "E-Mail";
            this.col_EMail.Name = "col_EMail";
            this.col_EMail.ReadOnly = true;
            this.col_EMail.Width = 61;
            // 
            // col_phoNum
            // 
            this.col_phoNum.HeaderText = "Phone Number";
            this.col_phoNum.Name = "col_phoNum";
            this.col_phoNum.ReadOnly = true;
            this.col_phoNum.Width = 95;
            // 
            // col_contType
            // 
            this.col_contType.HeaderText = "Contact Type";
            this.col_contType.Name = "col_contType";
            this.col_contType.ReadOnly = true;
            this.col_contType.Width = 69;
            // 
            // col_contNotes
            // 
            this.col_contNotes.HeaderText = "Contact Notes";
            this.col_contNotes.Name = "col_contNotes";
            this.col_contNotes.ReadOnly = true;
            this.col_contNotes.Width = 92;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.dgv_contacts);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddressForm";
            this.Text = "Primary Form";
            this.Load += new System.EventHandler(this.Frm_main_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chk_type;
        private System.Windows.Forms.TextBox txt_firName;
        private System.Windows.Forms.TextBox txt_EMail;
        private System.Windows.Forms.TextBox txt_contNote;
        private System.Windows.Forms.MaskedTextBox txt_phoNum;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_contacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_firName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_EMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phoNum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_contType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_contNotes;
    }
}

