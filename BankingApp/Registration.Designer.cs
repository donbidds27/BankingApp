namespace BankingApp
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.LinkLabel();
            this.passText = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.regButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pinText = new System.Windows.Forms.TextBox();
            this.cardText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.passText);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.regButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pinText);
            this.panel1.Controls.Add(this.cardText);
            this.panel1.Controls.Add(this.addressText);
            this.panel1.Controls.Add(this.emailText);
            this.panel1.Controls.Add(this.firstNameText);
            this.panel1.Location = new System.Drawing.Point(73, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 362);
            this.panel1.TabIndex = 0;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginLabel.Location = new System.Drawing.Point(542, 14);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(36, 13);
            this.loginLabel.TabIndex = 14;
            this.loginLabel.TabStop = true;
            this.loginLabel.Text = "Login ";
            this.loginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLabel_LinkClicked);
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(89, 146);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(148, 20);
            this.passText.TabIndex = 13;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(25, 149);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(53, 13);
            this.pass.TabIndex = 12;
            this.pass.Text = "Password";
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.regButton.Location = new System.Drawing.Point(384, 285);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(133, 42);
            this.regButton.TabIndex = 11;
            this.regButton.Text = "Register";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://freesvg.org/img/abstract-user-flat-3.png?w=150&h=150&fit=fill&fm=png";
            this.pictureBox1.Location = new System.Drawing.Point(369, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 157);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PIN";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Card #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // pinText
            // 
            this.pinText.Location = new System.Drawing.Point(89, 285);
            this.pinText.Name = "pinText";
            this.pinText.Size = new System.Drawing.Size(148, 20);
            this.pinText.TabIndex = 4;
            // 
            // cardText
            // 
            this.cardText.Location = new System.Drawing.Point(89, 238);
            this.cardText.Name = "cardText";
            this.cardText.Size = new System.Drawing.Size(148, 20);
            this.cardText.TabIndex = 3;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(89, 191);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(148, 20);
            this.addressText.TabIndex = 2;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(89, 97);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(148, 20);
            this.emailText.TabIndex = 1;
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(89, 50);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(148, 20);
            this.firstNameText.TabIndex = 0;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(759, 442);
            this.Controls.Add(this.panel1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pinText;
        private System.Windows.Forms.TextBox cardText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.LinkLabel loginLabel;
    }
}