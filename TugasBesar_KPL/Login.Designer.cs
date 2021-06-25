
namespace TugasBesar_KPL
{
    partial class lblLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblLogin));
            this.lblLibraryId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLibraryId = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLibraryId = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLibraryId
            // 
            this.lblLibraryId.AutoSize = true;
            this.lblLibraryId.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLibraryId.Location = new System.Drawing.Point(42, 101);
            this.lblLibraryId.Name = "lblLibraryId";
            this.lblLibraryId.Size = new System.Drawing.Size(53, 14);
            this.lblLibraryId.TabIndex = 0;
            this.lblLibraryId.Text = "LibraryId";
            this.lblLibraryId.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // tbLibraryId
            // 
            this.tbLibraryId.Location = new System.Drawing.Point(131, 101);
            this.tbLibraryId.Name = "tbLibraryId";
            this.tbLibraryId.Size = new System.Drawing.Size(130, 23);
            this.tbLibraryId.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(131, 136);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '$';
            this.tbPassword.Size = new System.Drawing.Size(130, 23);
            this.tbPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(152, 189);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login\r\n";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnLibraryId
            // 
            this.btnLibraryId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLibraryId.BackgroundImage")));
            this.btnLibraryId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLibraryId.Location = new System.Drawing.Point(285, 12);
            this.btnLibraryId.Name = "btnLibraryId";
            this.btnLibraryId.Size = new System.Drawing.Size(75, 70);
            this.btnLibraryId.TabIndex = 5;
            this.btnLibraryId.UseVisualStyleBackColor = true;
            this.btnLibraryId.Click += new System.EventHandler(this.btnLibraryId_Click);
            // 
            // lblLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(387, 361);
            this.Controls.Add(this.btnLibraryId);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLibraryId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLibraryId);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lblLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLibraryId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLibraryId;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLibraryId;
    }
}