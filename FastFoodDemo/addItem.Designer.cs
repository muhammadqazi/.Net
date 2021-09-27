
namespace FastFoodDemo
{
    partial class addItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addItem));
            this.itemQuantityAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemNameAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemCatAdd = new System.Windows.Forms.ComboBox();
            this.itemCustomAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.itemClearBtn = new System.Windows.Forms.Button();
            this.itemAddBtn = new System.Windows.Forms.Button();
            this.itemAddPrice = new System.Windows.Forms.TextBox();
            this.sas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemQuantityAdd
            // 
            this.itemQuantityAdd.Location = new System.Drawing.Point(280, 250);
            this.itemQuantityAdd.Name = "itemQuantityAdd";
            this.itemQuantityAdd.Size = new System.Drawing.Size(269, 20);
            this.itemQuantityAdd.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(201, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Quantity";
            // 
            // itemNameAdd
            // 
            this.itemNameAdd.Location = new System.Drawing.Point(280, 213);
            this.itemNameAdd.Name = "itemNameAdd";
            this.itemNameAdd.Size = new System.Drawing.Size(269, 20);
            this.itemNameAdd.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(169, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Product Name";
            // 
            // itemCatAdd
            // 
            this.itemCatAdd.FormattingEnabled = true;
            this.itemCatAdd.Items.AddRange(new object[] {
            "Coffes",
            "Soft Drinks",
            "Juice",
            "Custom Coffes",
            "Milk Shakes",
            "Others"});
            this.itemCatAdd.Location = new System.Drawing.Point(192, 167);
            this.itemCatAdd.Name = "itemCatAdd";
            this.itemCatAdd.Size = new System.Drawing.Size(357, 21);
            this.itemCatAdd.TabIndex = 24;
            this.itemCatAdd.Text = "Catagory";
            // 
            // itemCustomAdd
            // 
            this.itemCustomAdd.Location = new System.Drawing.Point(280, 287);
            this.itemCustomAdd.Name = "itemCustomAdd";
            this.itemCustomAdd.Size = new System.Drawing.Size(269, 20);
            this.itemCustomAdd.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(207, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Custom";
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
            this.button13.Location = new System.Drawing.Point(759, 0);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(37, 43);
            this.button13.TabIndex = 32;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // itemClearBtn
            // 
            this.itemClearBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itemClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemClearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemClearBtn.Location = new System.Drawing.Point(451, 381);
            this.itemClearBtn.Name = "itemClearBtn";
            this.itemClearBtn.Size = new System.Drawing.Size(98, 36);
            this.itemClearBtn.TabIndex = 33;
            this.itemClearBtn.Text = "Clear";
            this.itemClearBtn.UseVisualStyleBackColor = false;
            this.itemClearBtn.Click += new System.EventHandler(this.itemClearBtn_Click);
            // 
            // itemAddBtn
            // 
            this.itemAddBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itemAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemAddBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.itemAddBtn.Location = new System.Drawing.Point(280, 381);
            this.itemAddBtn.Name = "itemAddBtn";
            this.itemAddBtn.Size = new System.Drawing.Size(89, 36);
            this.itemAddBtn.TabIndex = 34;
            this.itemAddBtn.Text = "Add";
            this.itemAddBtn.UseVisualStyleBackColor = false;
            this.itemAddBtn.Click += new System.EventHandler(this.itemAddBtn_Click);
            // 
            // itemAddPrice
            // 
            this.itemAddPrice.Location = new System.Drawing.Point(280, 332);
            this.itemAddPrice.Name = "itemAddPrice";
            this.itemAddPrice.Size = new System.Drawing.Size(269, 20);
            this.itemAddPrice.TabIndex = 36;
            // 
            // sas
            // 
            this.sas.AutoSize = true;
            this.sas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sas.Location = new System.Drawing.Point(195, 334);
            this.sas.Name = "sas";
            this.sas.Size = new System.Drawing.Size(58, 15);
            this.sas.TabIndex = 35;
            this.sas.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(355, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Add your items in Database\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(309, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Items Adding Pannel\r\n";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(25, 404);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 13);
            this.linkLabel1.TabIndex = 50;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(28, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 143);
            this.panel2.TabIndex = 64;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // addItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.itemAddPrice);
            this.Controls.Add(this.sas);
            this.Controls.Add(this.itemClearBtn);
            this.Controls.Add(this.itemAddBtn);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.itemCustomAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemQuantityAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemNameAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemCatAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addItem";
            this.Text = "addItem";
            this.Load += new System.EventHandler(this.addItem_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemQuantityAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemNameAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox itemCatAdd;
        private System.Windows.Forms.TextBox itemCustomAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button itemClearBtn;
        private System.Windows.Forms.Button itemAddBtn;
        private System.Windows.Forms.TextBox itemAddPrice;
        private System.Windows.Forms.Label sas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}