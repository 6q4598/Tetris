namespace Tetris {
    partial class RegistrationPage {
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
            this.pswRegTxt = new System.Windows.Forms.TextBox();
            this.userRegTxt = new System.Windows.Forms.TextBox();
            this.pswLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titleLabel.Font = new System.Drawing.Font("IBM Plex Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(30, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(384, 84);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Tetris game";
            // 
            // pswRegTxt
            // 
            this.pswRegTxt.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pswRegTxt.Location = new System.Drawing.Point(171, 264);
            this.pswRegTxt.Name = "pswRegTxt";
            this.pswRegTxt.Size = new System.Drawing.Size(100, 32);
            this.pswRegTxt.TabIndex = 8;
            this.pswRegTxt.UseSystemPasswordChar = true;
            this.pswRegTxt.TextChanged += new System.EventHandler(this.pswRegTxt_TextChanged);
            // 
            // userRegTxt
            // 
            this.userRegTxt.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userRegTxt.Location = new System.Drawing.Point(171, 192);
            this.userRegTxt.Name = "userRegTxt";
            this.userRegTxt.Size = new System.Drawing.Size(100, 32);
            this.userRegTxt.TabIndex = 7;
            // 
            // pswLabel
            // 
            this.pswLabel.BackColor = System.Drawing.SystemColors.Window;
            this.pswLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pswLabel.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pswLabel.Location = new System.Drawing.Point(30, 264);
            this.pswLabel.Name = "pswLabel";
            this.pswLabel.Size = new System.Drawing.Size(109, 32);
            this.pswLabel.TabIndex = 6;
            this.pswLabel.Text = "Password";
            this.pswLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userLabel
            // 
            this.userLabel.BackColor = System.Drawing.SystemColors.Window;
            this.userLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userLabel.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLabel.Location = new System.Drawing.Point(30, 192);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(109, 32);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "User";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonRegistration.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRegistration.Location = new System.Drawing.Point(30, 340);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(241, 35);
            this.buttonRegistration.TabIndex = 9;
            this.buttonRegistration.Text = "Register";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DeepPink;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonBack.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(255, 444);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(159, 37);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Home";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // RegistrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(472, 540);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.pswRegTxt);
            this.Controls.Add(this.userRegTxt);
            this.Controls.Add(this.pswLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "RegistrationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox pswRegTxt;
        private System.Windows.Forms.TextBox userRegTxt;
        private System.Windows.Forms.Label pswLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonBack;
    }
}