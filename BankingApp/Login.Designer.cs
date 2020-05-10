using System.Windows.Forms;

namespace BankingApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logButton = new System.Windows.Forms.Button();
            this.passText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createAccountLabel = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.createAccountLabel);
            this.panel1.Controls.Add(this.logButton);
            this.panel1.Controls.Add(this.passText);
            this.panel1.Controls.Add(this.emailText);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(60, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 350);
            this.panel1.TabIndex = 0;
            // 
            // logButton
            // 
            this.logButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logButton.Location = new System.Drawing.Point(86, 273);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(75, 23);
            this.logButton.TabIndex = 3;
            this.logButton.Text = "Login";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // passText
            // 
            this.passText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.passText.Location = new System.Drawing.Point(49, 233);
            this.passText.Name = "passText";
            this.passText.PasswordChar = '*';
            this.passText.Size = new System.Drawing.Size(149, 20);
            this.passText.TabIndex = 2;
            this.passText.Text = "Password";
            this.passText.TextChanged += new System.EventHandler(this.passText_TextChanged);
            // 
            // emailText
            // 
            this.emailText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailText.Location = new System.Drawing.Point(49, 184);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(149, 20);
            this.emailText.TabIndex = 1;
            this.emailText.Text = "Email";
            this.emailText.TextChanged += new System.EventHandler(this.userText_TextChanged);
            this.emailText.Leave += new System.EventHandler(this.userText_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://freesvg.org/img/abstract-user-flat-3.png?w=150&h=150&fit=fill&fm=png";
            this.pictureBox1.Location = new System.Drawing.Point(49, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 157);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.LinkColor = System.Drawing.Color.DimGray;
            this.createAccountLabel.Location = new System.Drawing.Point(83, 324);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(81, 13);
            this.createAccountLabel.TabIndex = 4;
            this.createAccountLabel.TabStop = true;
            this.createAccountLabel.Text = "Create Account";
            this.createAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccountLabel_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(359, 469);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "LoginScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel createAccountLabel; 
    }
}

