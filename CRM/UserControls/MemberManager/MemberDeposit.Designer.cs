namespace CRM.UserControls.MemberManager
{
    partial class MemberDeposit
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
            this.teDepositAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tePayAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tePhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.meRemark = new DevExpress.XtraEditors.MemoEdit();
            this.sbtnDeposit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::CRM.WaitForm1), true, true, typeof(System.Windows.Forms.UserControl));
            ((System.ComponentModel.ISupportInitialize)(this.teDepositAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePayAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meRemark.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teDepositAmount
            // 
            this.teDepositAmount.EditValue = "";
            this.teDepositAmount.Location = new System.Drawing.Point(116, 104);
            this.teDepositAmount.Name = "teDepositAmount";
            this.teDepositAmount.Properties.Mask.EditMask = "((0.)|([1-9]\\d*\\.?))\\d+";
            this.teDepositAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.teDepositAmount.Size = new System.Drawing.Size(433, 20);
            this.teDepositAmount.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(32, 107);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "充值金额：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 158);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "实收金额：";
            // 
            // tePayAmount
            // 
            this.tePayAmount.EditValue = "";
            this.tePayAmount.Location = new System.Drawing.Point(116, 155);
            this.tePayAmount.Name = "tePayAmount";
            this.tePayAmount.Properties.Mask.EditMask = "((0.)|([1-9]\\d*\\.?))\\d+";
            this.tePayAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tePayAmount.Size = new System.Drawing.Size(433, 20);
            this.tePayAmount.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "会员手机：";
            // 
            // tePhoneNumber
            // 
            this.tePhoneNumber.Location = new System.Drawing.Point(116, 52);
            this.tePhoneNumber.Name = "tePhoneNumber";
            this.tePhoneNumber.Size = new System.Drawing.Size(433, 20);
            this.tePhoneNumber.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(56, 244);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "备注：";
            // 
            // meRemark
            // 
            this.meRemark.Location = new System.Drawing.Point(116, 206);
            this.meRemark.Name = "meRemark";
            this.meRemark.Size = new System.Drawing.Size(433, 104);
            this.meRemark.TabIndex = 17;
            // 
            // sbtnDeposit
            // 
            this.sbtnDeposit.Location = new System.Drawing.Point(474, 347);
            this.sbtnDeposit.Name = "sbtnDeposit";
            this.sbtnDeposit.Size = new System.Drawing.Size(75, 23);
            this.sbtnDeposit.TabIndex = 18;
            this.sbtnDeposit.Text = "充值";
            this.sbtnDeposit.Click += new System.EventHandler(this.SbtnDeposit_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(555, 158);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(7, 14);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "*";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(555, 110);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(7, 14);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "*";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(555, 58);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(7, 14);
            this.labelControl7.TabIndex = 21;
            this.labelControl7.Text = "*";
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // MemberDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.sbtnDeposit);
            this.Controls.Add(this.meRemark);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.tePhoneNumber);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tePayAmount);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.teDepositAmount);
            this.Name = "MemberDeposit";
            this.Size = new System.Drawing.Size(595, 399);
            ((System.ComponentModel.ISupportInitialize)(this.teDepositAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePayAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meRemark.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teDepositAmount;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tePayAmount;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tePhoneNumber;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit meRemark;
        private DevExpress.XtraEditors.SimpleButton sbtnDeposit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}
