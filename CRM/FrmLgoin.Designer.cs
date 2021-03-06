﻿namespace CRM
{
    partial class FrmLgoin
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
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ceRememberPassword = new DevExpress.XtraEditors.CheckEdit();
            this.sbtnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.teUserName = new DevExpress.XtraEditors.TextEdit();
            this.lblMessage = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRememberPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tePassword
            // 
            this.tePassword.EditValue = "123456";
            this.tePassword.Location = new System.Drawing.Point(110, 109);
            this.tePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Size = new System.Drawing.Size(125, 24);
            this.tePassword.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(59, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "账号：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(59, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "密码：";
            // 
            // ceRememberPassword
            // 
            this.ceRememberPassword.Location = new System.Drawing.Point(110, 140);
            this.ceRememberPassword.Name = "ceRememberPassword";
            this.ceRememberPassword.Properties.Caption = "记住密码";
            this.ceRememberPassword.Size = new System.Drawing.Size(94, 22);
            this.ceRememberPassword.TabIndex = 3;
            // 
            // sbtnLogin
            // 
            this.sbtnLogin.Location = new System.Drawing.Point(110, 179);
            this.sbtnLogin.Name = "sbtnLogin";
            this.sbtnLogin.Size = new System.Drawing.Size(94, 30);
            this.sbtnLogin.TabIndex = 4;
            this.sbtnLogin.Text = "登录";
            this.sbtnLogin.Click += new System.EventHandler(this.SbtnLogin_Click);
            // 
            // teUserName
            // 
            this.teUserName.EditValue = "admin";
            this.teUserName.Location = new System.Drawing.Point(110, 68);
            this.teUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.teUserName.Name = "teUserName";
            this.teUserName.Size = new System.Drawing.Size(125, 24);
            this.teUserName.TabIndex = 5;
            // 
            // lblMessage
            // 
            this.lblMessage.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Appearance.Options.UseForeColor = true;
            this.lblMessage.Location = new System.Drawing.Point(110, 42);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 18);
            this.lblMessage.TabIndex = 6;
            // 
            // FrmLgoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 238);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.teUserName);
            this.Controls.Add(this.sbtnLogin);
            this.Controls.Add(this.ceRememberPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tePassword);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmLgoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.FrmLgoin_Load);
            this.Shown += new System.EventHandler(this.FrmLgoin_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRememberPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit ceRememberPassword;
        private DevExpress.XtraEditors.SimpleButton sbtnLogin;
        private DevExpress.XtraEditors.TextEdit teUserName;
        private DevExpress.XtraEditors.LabelControl lblMessage;
    }
}