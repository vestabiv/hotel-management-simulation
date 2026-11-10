
namespace HotelManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_manag = new System.Windows.Forms.Button();
            this.btn_regis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_nickname = new System.Windows.Forms.TextBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_passw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_manag
            // 
            this.btn_manag.Location = new System.Drawing.Point(25, 143);
            this.btn_manag.Name = "btn_manag";
            this.btn_manag.Size = new System.Drawing.Size(198, 83);
            this.btn_manag.TabIndex = 0;
            this.btn_manag.Text = "Management";
            this.btn_manag.UseVisualStyleBackColor = true;
            this.btn_manag.Click += new System.EventHandler(this.btn_manag_Click);
            // 
            // btn_regis
            // 
            this.btn_regis.Location = new System.Drawing.Point(25, 26);
            this.btn_regis.Name = "btn_regis";
            this.btn_regis.Size = new System.Drawing.Size(198, 81);
            this.btn_regis.TabIndex = 1;
            this.btn_regis.Text = "Booking";
            this.btn_regis.UseVisualStyleBackColor = true;
            this.btn_regis.Click += new System.EventHandler(this.btn_regis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff only";
            // 
            // txtbox_nickname
            // 
            this.txtbox_nickname.Location = new System.Drawing.Point(25, 252);
            this.txtbox_nickname.Name = "txtbox_nickname";
            this.txtbox_nickname.Size = new System.Drawing.Size(138, 23);
            this.txtbox_nickname.TabIndex = 3;
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(25, 294);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(138, 23);
            this.txtbox_password.TabIndex = 4;
            this.txtbox_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nickname";
            // 
            // lbl_passw
            // 
            this.lbl_passw.AutoSize = true;
            this.lbl_passw.Location = new System.Drawing.Point(25, 278);
            this.lbl_passw.Name = "lbl_passw";
            this.lbl_passw.Size = new System.Drawing.Size(57, 15);
            this.lbl_passw.TabIndex = 6;
            this.lbl_passw.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 347);
            this.Controls.Add(this.lbl_passw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_nickname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regis);
            this.Controls.Add(this.btn_manag);
            this.Name = "Form1";
            this.Text = "Silver Hotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_manag;
        private System.Windows.Forms.Button btn_regis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_nickname;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_passw;
    }
}

