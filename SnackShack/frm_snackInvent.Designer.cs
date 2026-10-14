namespace snackShack
{
    partial class frm_snackInvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_snackInvent));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_snackName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_snackPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_snackQuantity = new System.Windows.Forms.NumericUpDown();
            this.bttn_snackImage = new System.Windows.Forms.Button();
            this.txt_imagePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pb_snackIcon = new System.Windows.Forms.PictureBox();
            this.dgv_invent = new System.Windows.Forms.DataGridView();
            this.col_snackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_snackPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_snackQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_snackIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_iconPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_icon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_clearEntry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_snackPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_snackQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_snackIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invent)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snack Name";
            // 
            // txt_snackName
            // 
            this.txt_snackName.Location = new System.Drawing.Point(77, 33);
            this.txt_snackName.Name = "txt_snackName";
            this.txt_snackName.Size = new System.Drawing.Size(100, 20);
            this.txt_snackName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_snackName, "The Name of the snck");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Snack Price";
            // 
            // nud_snackPrice
            // 
            this.nud_snackPrice.DecimalPlaces = 2;
            this.nud_snackPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_snackPrice.Location = new System.Drawing.Point(77, 54);
            this.nud_snackPrice.Name = "nud_snackPrice";
            this.nud_snackPrice.Size = new System.Drawing.Size(120, 20);
            this.nud_snackPrice.TabIndex = 3;
            this.nud_snackPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nud_snackPrice, "The price of the snack");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // nud_snackQuantity
            // 
            this.nud_snackQuantity.Location = new System.Drawing.Point(77, 80);
            this.nud_snackQuantity.Name = "nud_snackQuantity";
            this.nud_snackQuantity.Size = new System.Drawing.Size(120, 20);
            this.nud_snackQuantity.TabIndex = 5;
            this.nud_snackQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nud_snackQuantity, "Quantity of snacks");
            // 
            // bttn_snackImage
            // 
            this.bttn_snackImage.Location = new System.Drawing.Point(3, 0);
            this.bttn_snackImage.Name = "bttn_snackImage";
            this.bttn_snackImage.Size = new System.Drawing.Size(75, 23);
            this.bttn_snackImage.TabIndex = 6;
            this.bttn_snackImage.Text = "Image";
            this.toolTip1.SetToolTip(this.bttn_snackImage, "Select Image");
            this.bttn_snackImage.UseVisualStyleBackColor = true;
            this.bttn_snackImage.Click += new System.EventHandler(this.bttn_snackImage_Click);
            // 
            // txt_imagePath
            // 
            this.txt_imagePath.Location = new System.Drawing.Point(84, 2);
            this.txt_imagePath.Name = "txt_imagePath";
            this.txt_imagePath.Size = new System.Drawing.Size(100, 20);
            this.txt_imagePath.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txt_imagePath, "Image Path");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pb_snackIcon
            // 
            this.pb_snackIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_snackIcon.InitialImage = global::snackShack.Properties.Resources.VendingMachine1;
            this.pb_snackIcon.Location = new System.Drawing.Point(493, 1);
            this.pb_snackIcon.Name = "pb_snackIcon";
            this.pb_snackIcon.Size = new System.Drawing.Size(307, 204);
            this.pb_snackIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_snackIcon.TabIndex = 8;
            this.pb_snackIcon.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_snackIcon, "Icon Preview");
            // 
            // dgv_invent
            // 
            this.dgv_invent.AllowUserToAddRows = false;
            this.dgv_invent.AllowUserToDeleteRows = false;
            this.dgv_invent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_invent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_snackName,
            this.col_snackPrice,
            this.col_snackQuantity,
            this.col_snackIcon,
            this.col_iconPath,
            this.col_icon});
            this.dgv_invent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_invent.Location = new System.Drawing.Point(0, 211);
            this.dgv_invent.MultiSelect = false;
            this.dgv_invent.Name = "dgv_invent";
            this.dgv_invent.ReadOnly = true;
            this.dgv_invent.RowHeadersVisible = false;
            this.dgv_invent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_invent.Size = new System.Drawing.Size(800, 217);
            this.dgv_invent.TabIndex = 9;
            this.dgv_invent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_selectEdit);
            // 
            // col_snackName
            // 
            this.col_snackName.HeaderText = "Snack Name";
            this.col_snackName.Name = "col_snackName";
            this.col_snackName.ReadOnly = true;
            // 
            // col_snackPrice
            // 
            this.col_snackPrice.HeaderText = "Snack Price";
            this.col_snackPrice.Name = "col_snackPrice";
            this.col_snackPrice.ReadOnly = true;
            // 
            // col_snackQuantity
            // 
            this.col_snackQuantity.HeaderText = "Snack Quantity";
            this.col_snackQuantity.Name = "col_snackQuantity";
            this.col_snackQuantity.ReadOnly = true;
            // 
            // col_snackIcon
            // 
            this.col_snackIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_snackIcon.HeaderText = "Icon";
            this.col_snackIcon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_snackIcon.Name = "col_snackIcon";
            this.col_snackIcon.ReadOnly = true;
            this.col_snackIcon.Width = 199;
            // 
            // col_iconPath
            // 
            this.col_iconPath.HeaderText = "path for icon";
            this.col_iconPath.Name = "col_iconPath";
            this.col_iconPath.ReadOnly = true;
            this.col_iconPath.Visible = false;
            // 
            // col_icon
            // 
            this.col_icon.HeaderText = "snack index";
            this.col_icon.Name = "col_icon";
            this.col_icon.ReadOnly = true;
            this.col_icon.Visible = false;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(4, 179);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.toolTip1.SetToolTip(this.btn_add, "Add Entry to table");
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bttn_snackImage);
            this.panel1.Controls.Add(this.txt_imagePath);
            this.panel1.Controls.Add(this.txt_snackName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nud_snackQuantity);
            this.panel1.Controls.Add(this.nud_snackPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btn_clearEntry
            // 
            this.btn_clearEntry.Location = new System.Drawing.Point(125, 182);
            this.btn_clearEntry.Name = "btn_clearEntry";
            this.btn_clearEntry.Size = new System.Drawing.Size(75, 23);
            this.btn_clearEntry.TabIndex = 12;
            this.btn_clearEntry.Text = "Clear Entry";
            this.toolTip1.SetToolTip(this.btn_clearEntry, "Clear Input Fields");
            this.btn_clearEntry.UseVisualStyleBackColor = true;
            this.btn_clearEntry.Click += new System.EventHandler(this.btn_clearEntry_Click);
            // 
            // frm_snackInvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clearEntry);
            this.Controls.Add(this.dgv_invent);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pb_snackIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_snackInvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snack Shack Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_snackInvent_FormClosing);
            this.Load += new System.EventHandler(this.frm_snackInvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_snackPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_snackQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_snackIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_snackName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_snackPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_snackQuantity;
        private System.Windows.Forms.Button bttn_snackImage;
        private System.Windows.Forms.TextBox txt_imagePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pb_snackIcon;
        private System.Windows.Forms.DataGridView dgv_invent;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_snackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_snackPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_snackQuantity;
        private System.Windows.Forms.DataGridViewImageColumn col_snackIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_iconPath;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_icon;
        private System.Windows.Forms.Button btn_clearEntry;
    }
}

