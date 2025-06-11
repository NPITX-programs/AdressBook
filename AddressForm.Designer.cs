namespace AdressBook
{
    partial class frm_addressForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addressForm));
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
            this.toolStrip_autoSave = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_contacts = new System.Windows.Forms.DataGridView();
            this.col_firName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phoNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_contType = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_contNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_contInd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contacts)).BeginInit();
            this.SuspendLayout();
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
            this.fileToolStripMenuItem,
            this.toolStrip_autoSave});
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip_autoSave
            // 
            this.toolStrip_autoSave.BackColor = System.Drawing.Color.Red;
            this.toolStrip_autoSave.CheckOnClick = true;
            this.toolStrip_autoSave.Name = "toolStrip_autoSave";
            this.toolStrip_autoSave.Size = new System.Drawing.Size(74, 20);
            this.toolStrip_autoSave.Text = "Auto-Save";
            this.toolStrip_autoSave.CheckedChanged += new System.EventHandler(this.toolStrip_autoSave_Click);
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
            this.dgv_contacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_firName,
            this.col_lastName,
            this.col_EMail,
            this.col_phoNum,
            this.col_contType,
            this.col_contNotes,
            this.col_contInd});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_contacts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_contacts.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_contacts.Location = new System.Drawing.Point(676, 24);
            this.dgv_contacts.MultiSelect = false;
            this.dgv_contacts.Name = "dgv_contacts";
            this.dgv_contacts.ReadOnly = true;
            this.dgv_contacts.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_contacts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_contacts.RowTemplate.Height = 25;
            this.dgv_contacts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_contacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_contacts.Size = new System.Drawing.Size(221, 426);
            this.dgv_contacts.TabIndex = 18;
            this.dgv_contacts.TabStop = false;
            this.dgv_contacts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_contacts_CellClick);
            // 
            // col_firName
            // 
            this.col_firName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_firName.FillWeight = 10F;
            this.col_firName.HeaderText = "First Name";
            this.col_firName.MinimumWidth = 100;
            this.col_firName.Name = "col_firName";
            this.col_firName.ReadOnly = true;
            // 
            // col_lastName
            // 
            this.col_lastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_lastName.FillWeight = 10F;
            this.col_lastName.HeaderText = "Last Name";
            this.col_lastName.MinimumWidth = 100;
            this.col_lastName.Name = "col_lastName";
            this.col_lastName.ReadOnly = true;
            // 
            // col_EMail
            // 
            this.col_EMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_EMail.HeaderText = "E-Mail";
            this.col_EMail.MinimumWidth = 75;
            this.col_EMail.Name = "col_EMail";
            this.col_EMail.ReadOnly = true;
            this.col_EMail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_EMail.Width = 75;
            // 
            // col_phoNum
            // 
            this.col_phoNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_phoNum.HeaderText = "Phone Number";
            this.col_phoNum.MinimumWidth = 75;
            this.col_phoNum.Name = "col_phoNum";
            this.col_phoNum.ReadOnly = true;
            this.col_phoNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_phoNum.Width = 75;
            // 
            // col_contType
            // 
            this.col_contType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_contType.HeaderText = "Contact Type";
            this.col_contType.Name = "col_contType";
            this.col_contType.ReadOnly = true;
            this.col_contType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_contType.Width = 75;
            // 
            // col_contNotes
            // 
            this.col_contNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_contNotes.FillWeight = 90F;
            this.col_contNotes.HeaderText = "Contact Notes";
            this.col_contNotes.MinimumWidth = 100;
            this.col_contNotes.Name = "col_contNotes";
            this.col_contNotes.ReadOnly = true;
            // 
            // col_contInd
            // 
            this.col_contInd.HeaderText = "Index";
            this.col_contInd.Name = "col_contInd";
            this.col_contInd.ReadOnly = true;
            this.col_contInd.Width = 81;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(400, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 22;
            // 
            // frm_addressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_contacts);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_addressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primary Form";
            this.Load += new System.EventHandler(this.frm_addressForm_Load);
            this.Resize += new System.EventHandler(this.frm_addressForm_reSize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ToolStripMenuItem toolStrip_autoSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_firName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_EMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phoNum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_contType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_contNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_contInd;
        private System.Windows.Forms.Panel panel1;
    }
}

