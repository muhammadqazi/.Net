
namespace FastFoodDemo
{
    partial class updateItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateItem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.itemCustomUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemPriceUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemNameUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemCatUpdate = new System.Windows.Forms.ComboBox();
            this.UpdateBtnclear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.dataGridUpdate = new Guna.UI2.WinForms.GunaDataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUpdate)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // itemCustomUpdate
            // 
            this.itemCustomUpdate.Location = new System.Drawing.Point(84, 184);
            this.itemCustomUpdate.Name = "itemCustomUpdate";
            this.itemCustomUpdate.Size = new System.Drawing.Size(688, 20);
            this.itemCustomUpdate.TabIndex = 41;
            this.itemCustomUpdate.TextChanged += new System.EventHandler(this.itemCustomUpdate_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Search\r\n";
            // 
            // itemPriceUpdate
            // 
            this.itemPriceUpdate.Location = new System.Drawing.Point(493, 142);
            this.itemPriceUpdate.Name = "itemPriceUpdate";
            this.itemPriceUpdate.Size = new System.Drawing.Size(216, 20);
            this.itemPriceUpdate.TabIndex = 39;
            this.itemPriceUpdate.TextChanged += new System.EventHandler(this.itemQuantityUpdate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(452, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Price";
            // 
            // itemNameUpdate
            // 
            this.itemNameUpdate.Location = new System.Drawing.Point(264, 142);
            this.itemNameUpdate.Name = "itemNameUpdate";
            this.itemNameUpdate.Size = new System.Drawing.Size(180, 20);
            this.itemNameUpdate.TabIndex = 37;
            this.itemNameUpdate.TextChanged += new System.EventHandler(this.itemNameUpdate_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(174, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Product Name";
            // 
            // itemCatUpdate
            // 
            this.itemCatUpdate.FormattingEnabled = true;
            this.itemCatUpdate.Items.AddRange(new object[] {
            "Coffes",
            "Soft Drinks",
            "Juice",
            "Custom Coffes",
            "Milk Shakes",
            "Others"});
            this.itemCatUpdate.Location = new System.Drawing.Point(177, 114);
            this.itemCatUpdate.Name = "itemCatUpdate";
            this.itemCatUpdate.Size = new System.Drawing.Size(532, 21);
            this.itemCatUpdate.TabIndex = 35;
            this.itemCatUpdate.Text = "Catagory";
            this.itemCatUpdate.SelectedIndexChanged += new System.EventHandler(this.itemCatUpdate_SelectedIndexChanged);
            // 
            // UpdateBtnclear
            // 
            this.UpdateBtnclear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateBtnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtnclear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtnclear.Location = new System.Drawing.Point(674, 370);
            this.UpdateBtnclear.Name = "UpdateBtnclear";
            this.UpdateBtnclear.Size = new System.Drawing.Size(98, 36);
            this.UpdateBtnclear.TabIndex = 44;
            this.UpdateBtnclear.Text = "Clear";
            this.UpdateBtnclear.UseVisualStyleBackColor = false;
            this.UpdateBtnclear.Click += new System.EventHandler(this.UpdateBtnclear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(23, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 45;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(758, -1);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(37, 43);
            this.button13.TabIndex = 43;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // dataGridUpdate
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridUpdate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUpdate.BackgroundColor = System.Drawing.Color.White;
            this.dataGridUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUpdate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridUpdate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUpdate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUpdate.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUpdate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridUpdate.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridUpdate.EnableHeadersVisualStyles = false;
            this.dataGridUpdate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridUpdate.Location = new System.Drawing.Point(36, 214);
            this.dataGridUpdate.Name = "dataGridUpdate";
            this.dataGridUpdate.RowHeadersVisible = false;
            this.dataGridUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUpdate.Size = new System.Drawing.Size(736, 150);
            this.dataGridUpdate.TabIndex = 46;
            this.dataGridUpdate.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridUpdate.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridUpdate.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridUpdate.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridUpdate.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridUpdate.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridUpdate.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridUpdate.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridUpdate.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridUpdate.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridUpdate.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridUpdate.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridUpdate.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridUpdate.ThemeStyle.ReadOnly = false;
            this.dataGridUpdate.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridUpdate.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridUpdate.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridUpdate.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridUpdate.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridUpdate.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridUpdate.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridUpdate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUpdate_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(343, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 32);
            this.label6.TabIndex = 48;
            this.label6.Text = "Update Items into Database\r\n\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(305, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 25);
            this.label7.TabIndex = 47;
            this.label7.Text = "Items Update Pannel\r\n";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(28, 418);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 13);
            this.linkLabel1.TabIndex = 49;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(23, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 143);
            this.panel1.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "Cafe";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(-1, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "The Developer\'s\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // updateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridUpdate);
            this.Controls.Add(this.itemCustomUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemPriceUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemNameUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemCatUpdate);
            this.Controls.Add(this.UpdateBtnclear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateItem";
            this.Load += new System.EventHandler(this.updateItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUpdate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox itemCustomUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemPriceUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemNameUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox itemCatUpdate;
        private System.Windows.Forms.Button UpdateBtnclear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button13;
        private Guna.UI2.WinForms.GunaDataGridView dataGridUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}