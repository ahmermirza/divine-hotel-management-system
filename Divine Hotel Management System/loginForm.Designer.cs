﻿namespace Divine_Hotel_Management_System
{
    partial class loginForm
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
            this.loginL = new System.Windows.Forms.Label();
            this.loginNameL = new System.Windows.Forms.Label();
            this.loginPasswordL = new System.Windows.Forms.Label();
            this.loginNameTB = new System.Windows.Forms.TextBox();
            this.loginPasswordTB = new System.Windows.Forms.TextBox();
            this.loginB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginL
            // 
            this.loginL.AutoSize = true;
            this.loginL.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginL.Location = new System.Drawing.Point(364, 249);
            this.loginL.Name = "loginL";
            this.loginL.Size = new System.Drawing.Size(84, 31);
            this.loginL.TabIndex = 0;
            this.loginL.Text = "LogIn";
            // 
            // loginNameL
            // 
            this.loginNameL.AutoSize = true;
            this.loginNameL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginNameL.Location = new System.Drawing.Point(259, 293);
            this.loginNameL.Name = "loginNameL";
            this.loginNameL.Size = new System.Drawing.Size(93, 21);
            this.loginNameL.TabIndex = 1;
            this.loginNameL.Text = "User Name";
            // 
            // loginPasswordL
            // 
            this.loginPasswordL.AutoSize = true;
            this.loginPasswordL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswordL.Location = new System.Drawing.Point(268, 324);
            this.loginPasswordL.Name = "loginPasswordL";
            this.loginPasswordL.Size = new System.Drawing.Size(84, 21);
            this.loginPasswordL.TabIndex = 2;
            this.loginPasswordL.Text = "Password";
            // 
            // loginNameTB
            // 
            this.loginNameTB.Location = new System.Drawing.Point(358, 294);
            this.loginNameTB.Name = "loginNameTB";
            this.loginNameTB.Size = new System.Drawing.Size(153, 20);
            this.loginNameTB.TabIndex = 3;
            this.loginNameTB.Text = "Enter username here";
            this.loginNameTB.Click += new System.EventHandler(this.loginNameTB_Click);
            // 
            // loginPasswordTB
            // 
            this.loginPasswordTB.Location = new System.Drawing.Point(358, 325);
            this.loginPasswordTB.Name = "loginPasswordTB";
            this.loginPasswordTB.Size = new System.Drawing.Size(153, 20);
            this.loginPasswordTB.TabIndex = 4;
            this.loginPasswordTB.Text = "Enter password here";
            this.loginPasswordTB.Click += new System.EventHandler(this.loginPasswordTB_Click);
            // 
            // loginB
            // 
            this.loginB.Location = new System.Drawing.Point(370, 361);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(63, 26);
            this.loginB.TabIndex = 5;
            this.loginB.Text = "Log in";
            this.loginB.UseVisualStyleBackColor = true;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginB);
            this.Controls.Add(this.loginPasswordTB);
            this.Controls.Add(this.loginNameTB);
            this.Controls.Add(this.loginPasswordL);
            this.Controls.Add(this.loginNameL);
            this.Controls.Add(this.loginL);
            this.Name = "loginForm";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginL;
        private System.Windows.Forms.Label loginNameL;
        private System.Windows.Forms.Label loginPasswordL;
        private System.Windows.Forms.TextBox loginNameTB;
        private System.Windows.Forms.TextBox loginPasswordTB;
        private System.Windows.Forms.Button loginB;
    }
}

