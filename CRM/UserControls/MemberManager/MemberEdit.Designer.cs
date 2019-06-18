namespace CRM.UserControls.ProcuctManager
{
    partial class MemberEdit
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.sbtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tePhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.teUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.meRemark = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.teIDCard = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.teAddress = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teIDCard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbtnSave
            // 
            this.sbtnSave.Location = new System.Drawing.Point(498, 213);
            this.sbtnSave.Name = "sbtnSave";
            this.sbtnSave.Size = new System.Drawing.Size(53, 23);
            this.sbtnSave.TabIndex = 11;
            this.sbtnSave.Text = "保存";
            this.sbtnSave.Click += new System.EventHandler(this.sbtnSave_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(258, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(7, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "*";
            // 
            // tePhoneNumber
            // 
            this.tePhoneNumber.Location = new System.Drawing.Point(51, 53);
            this.tePhoneNumber.Name = "tePhoneNumber";
            this.tePhoneNumber.Properties.MaxLength = 11;
            this.tePhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.tePhoneNumber.TabIndex = 9;
            // 
            // teUserName
            // 
            this.teUserName.Location = new System.Drawing.Point(50, 23);
            this.teUserName.Name = "teUserName";
            this.teUserName.Size = new System.Drawing.Size(201, 20);
            this.teUserName.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 56);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 14);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "手机：";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(257, 59);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(7, 14);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "*";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "名称：";
            // 
            // meRemark
            // 
            this.meRemark.Location = new System.Drawing.Point(51, 113);
            this.meRemark.Name = "meRemark";
            this.meRemark.Size = new System.Drawing.Size(506, 89);
            this.meRemark.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 138);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "备注：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(280, 26);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "支付密码：";
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(356, 23);
            this.tePassword.Name = "tePassword";
            this.tePassword.Size = new System.Drawing.Size(201, 20);
            this.tePassword.TabIndex = 17;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(292, 56);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "身份证：";
            // 
            // teIDCard
            // 
            this.teIDCard.Location = new System.Drawing.Point(356, 53);
            this.teIDCard.Name = "teIDCard";
            this.teIDCard.Size = new System.Drawing.Size(201, 20);
            this.teIDCard.TabIndex = 19;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 84);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 14);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "地址：";
            // 
            // teAddress
            // 
            this.teAddress.Location = new System.Drawing.Point(51, 87);
            this.teAddress.Name = "teAddress";
            this.teAddress.Size = new System.Drawing.Size(506, 20);
            this.teAddress.TabIndex = 21;
            // 
            // MemberEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.teAddress);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.teIDCard);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.meRemark);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.sbtnSave);
            this.Controls.Add(this.tePhoneNumber);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.teUserName);
            this.Controls.Add(this.labelControl1);
            this.Name = "MemberEdit";
            this.Size = new System.Drawing.Size(571, 250);
            this.Load += new System.EventHandler(this.ProductEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tePhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teIDCard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton sbtnSave;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tePhoneNumber;
        private DevExpress.XtraEditors.TextEdit teUserName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit meRemark;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit teIDCard;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit teAddress;
    }
}
