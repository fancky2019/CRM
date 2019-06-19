namespace CRM.UserControls.ProcuctManager
{
    partial class ProductEdit
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
            this.tePrice = new DevExpress.XtraEditors.TextEdit();
            this.teProcuctName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.meDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.seDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.teBonusPoints = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProcuctName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBonusPoints.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbtnSave
            // 
            this.sbtnSave.Location = new System.Drawing.Point(425, 212);
            this.sbtnSave.Name = "sbtnSave";
            this.sbtnSave.Size = new System.Drawing.Size(62, 27);
            this.sbtnSave.TabIndex = 11;
            this.sbtnSave.Text = "保存";
            this.sbtnSave.Click += new System.EventHandler(this.sbtnSave_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(294, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(7, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "*";
            // 
            // tePrice
            // 
            this.tePrice.EditValue = "";
            this.tePrice.Location = new System.Drawing.Point(54, 57);
            this.tePrice.Name = "tePrice";
            this.tePrice.Properties.Mask.EditMask = "((0.)|([1-9]\\d*\\.?))\\d+";
            this.tePrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tePrice.Size = new System.Drawing.Size(233, 20);
            this.tePrice.TabIndex = 9;
            // 
            // teProcuctName
            // 
            this.teProcuctName.Location = new System.Drawing.Point(54, 24);
            this.teProcuctName.Name = "teProcuctName";
            this.teProcuctName.Size = new System.Drawing.Size(234, 20);
            this.teProcuctName.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(294, 60);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(12, 14);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "￥";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(17, 60);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 14);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "价格：";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(312, 62);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(7, 14);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "*";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "名称：";
            // 
            // meDescription
            // 
            this.meDescription.Location = new System.Drawing.Point(54, 89);
            this.meDescription.Name = "meDescription";
            this.meDescription.Size = new System.Drawing.Size(433, 104);
            this.meDescription.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 135);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "描述：";
            // 
            // seDiscount
            // 
            this.seDiscount.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seDiscount.Location = new System.Drawing.Point(387, 24);
            this.seDiscount.Name = "seDiscount";
            this.seDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seDiscount.Properties.IsFloatValue = false;
            this.seDiscount.Properties.Mask.EditMask = "N00";
            this.seDiscount.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seDiscount.Properties.NullText = "折扣";
            this.seDiscount.Size = new System.Drawing.Size(100, 20);
            this.seDiscount.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(345, 27);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "折扣：";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(345, 60);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 14);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "积分：";
            // 
            // teBonusPoints
            // 
            this.teBonusPoints.EditValue = "0";
            this.teBonusPoints.Location = new System.Drawing.Point(387, 57);
            this.teBonusPoints.Name = "teBonusPoints";
            this.teBonusPoints.Properties.Mask.EditMask = "\\d+";
            this.teBonusPoints.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.teBonusPoints.Size = new System.Drawing.Size(100, 20);
            this.teBonusPoints.TabIndex = 19;
            // 
            // ProductEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.teBonusPoints);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.seDiscount);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.meDescription);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.sbtnSave);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.tePrice);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.teProcuctName);
            this.Controls.Add(this.labelControl1);
            this.Name = "ProductEdit";
            this.Size = new System.Drawing.Size(513, 259);
            this.Load += new System.EventHandler(this.ProductEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProcuctName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBonusPoints.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton sbtnSave;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tePrice;
        private DevExpress.XtraEditors.TextEdit teProcuctName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit meDescription;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit seDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit teBonusPoints;
    }
}
