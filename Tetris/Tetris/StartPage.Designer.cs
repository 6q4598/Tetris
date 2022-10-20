namespace Tetris {
    partial class StartPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.titleLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.pswLabel = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.pswTxt = new System.Windows.Forms.TextBox();
            this.buttonLoggin = new System.Windows.Forms.Button();
            this.buttonDemo = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titleLabel.Font = new System.Drawing.Font("IBM Plex Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(40, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(384, 84);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Tetris game";
            // 
            // userLabel
            // 
            this.userLabel.BackColor = System.Drawing.SystemColors.Window;
            this.userLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userLabel.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLabel.Location = new System.Drawing.Point(40, 157);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(109, 32);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "User";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pswLabel
            // 
            this.pswLabel.BackColor = System.Drawing.SystemColors.Window;
            this.pswLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pswLabel.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pswLabel.Location = new System.Drawing.Point(40, 212);
            this.pswLabel.Name = "pswLabel";
            this.pswLabel.Size = new System.Drawing.Size(109, 32);
            this.pswLabel.TabIndex = 2;
            this.pswLabel.Text = "Password";
            this.pswLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userTxt
            // 
            this.userTxt.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userTxt.Location = new System.Drawing.Point(181, 157);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(100, 32);
            this.userTxt.TabIndex = 3;
            // 
            // pswTxt
            // 
            this.pswTxt.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pswTxt.Location = new System.Drawing.Point(181, 212);
            this.pswTxt.Name = "pswTxt";
            this.pswTxt.Size = new System.Drawing.Size(100, 32);
            this.pswTxt.TabIndex = 4;
            this.pswTxt.UseSystemPasswordChar = true;
            // 
            // buttonLoggin
            // 
            this.buttonLoggin.BackColor = System.Drawing.Color.Yellow;
            this.buttonLoggin.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLoggin.Location = new System.Drawing.Point(40, 269);
            this.buttonLoggin.Name = "buttonLoggin";
            this.buttonLoggin.Size = new System.Drawing.Size(241, 35);
            this.buttonLoggin.TabIndex = 5;
            this.buttonLoggin.Text = "Loggin";
            this.buttonLoggin.UseVisualStyleBackColor = false;
            this.buttonLoggin.Click += new System.EventHandler(this.buttonLoggin_Click);
            // 
            // buttonDemo
            // 
            this.buttonDemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonDemo.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDemo.Location = new System.Drawing.Point(183, 411);
            this.buttonDemo.Name = "buttonDemo";
            this.buttonDemo.Size = new System.Drawing.Size(241, 35);
            this.buttonDemo.TabIndex = 6;
            this.buttonDemo.Text = "Play Demo";
            this.buttonDemo.UseVisualStyleBackColor = false;
            this.buttonDemo.Click += new System.EventHandler(this.buttonDemo_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonRegister.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRegister.Location = new System.Drawing.Point(40, 319);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(241, 35);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Red;
            this.buttonHelp.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHelp.Location = new System.Drawing.Point(183, 465);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(241, 35);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(472, 540);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonDemo);
            this.Controls.Add(this.buttonLoggin);
            this.Controls.Add(this.pswTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.pswLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label pswLabel;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox pswTxt;
        private System.Windows.Forms.Button buttonLoggin;
        private System.Windows.Forms.Button buttonDemo;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonHelp;
    }
}