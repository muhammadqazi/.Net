
namespace FastFoodDemo
{
    partial class security
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(security));
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.secureBTn = new System.Windows.Forms.Button();
            this.secureBox = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "Enter the Admistrative password to add user\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "Administrative Password";
            // 
            // secureBTn
            // 
            this.secureBTn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.secureBTn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secureBTn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.secureBTn.Location = new System.Drawing.Point(94, 106);
            this.secureBTn.Name = "secureBTn";
            this.secureBTn.Size = new System.Drawing.Size(89, 36);
            this.secureBTn.TabIndex = 64;
            this.secureBTn.Text = "Confirm";
            this.secureBTn.UseVisualStyleBackColor = false;
            this.secureBTn.Click += new System.EventHandler(this.secureBTn_Click);
            // 
            // secureBox
            // 
            this.secureBox.Location = new System.Drawing.Point(15, 80);
            this.secureBox.Name = "secureBox";
            this.secureBox.PasswordChar = '*';
            this.secureBox.Size = new System.Drawing.Size(269, 20);
            this.secureBox.TabIndex = 63;
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
            this.button13.Location = new System.Drawing.Point(264, -2);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(37, 32);
            this.button13.TabIndex = 65;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // security
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 149);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.secureBTn);
            this.Controls.Add(this.secureBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "security";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "security";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button secureBTn;
        private System.Windows.Forms.TextBox secureBox;
        private System.Windows.Forms.Button button13;
    }
}