namespace CRM.UserControls.SystemManager
{
    partial class SystemTool
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
            this.sbtnSystemTool = new DevExpress.XtraEditors.SimpleButton();
            this.sbenUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // sbtnSystemTool
            // 
            this.sbtnSystemTool.Location = new System.Drawing.Point(81, 34);
            this.sbtnSystemTool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbtnSystemTool.Name = "sbtnSystemTool";
            this.sbtnSystemTool.Size = new System.Drawing.Size(86, 30);
            this.sbtnSystemTool.TabIndex = 2;
            this.sbtnSystemTool.Text = "系统目录";
            this.sbtnSystemTool.Click += new System.EventHandler(this.SbtnSystemTool_Click);
            // 
            // sbenUpdate
            // 
            this.sbenUpdate.Location = new System.Drawing.Point(227, 34);
            this.sbenUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbenUpdate.Name = "sbenUpdate";
            this.sbenUpdate.Size = new System.Drawing.Size(86, 30);
            this.sbenUpdate.TabIndex = 3;
            this.sbenUpdate.Text = "系统更新";
            this.sbenUpdate.Click += new System.EventHandler(this.SbenUpdate_Click);
            // 
            // SystemTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sbenUpdate);
            this.Controls.Add(this.sbtnSystemTool);
            this.Name = "SystemTool";
            this.Size = new System.Drawing.Size(842, 634);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbtnSystemTool;
        private DevExpress.XtraEditors.SimpleButton sbenUpdate;
    }
}
