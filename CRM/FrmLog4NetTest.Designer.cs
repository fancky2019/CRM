namespace CRM
{
    partial class FrmLog4NetTest
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
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();
            this.btnFileSize = new System.Windows.Forms.Button();
            this.btnBufferCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(175, 99);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(421, 99);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(75, 23);
            this.btnDebug.TabIndex = 1;
            this.btnDebug.Text = "Debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.BtnDebug_Click);
            // 
            // btnFileSize
            // 
            this.btnFileSize.Location = new System.Drawing.Point(175, 170);
            this.btnFileSize.Name = "btnFileSize";
            this.btnFileSize.Size = new System.Drawing.Size(75, 23);
            this.btnFileSize.TabIndex = 2;
            this.btnFileSize.Text = "file2K";
            this.btnFileSize.UseVisualStyleBackColor = true;
            this.btnFileSize.Click += new System.EventHandler(this.BtnFileSize_Click);
            // 
            // btnBufferCount
            // 
            this.btnBufferCount.Location = new System.Drawing.Point(421, 160);
            this.btnBufferCount.Name = "btnBufferCount";
            this.btnBufferCount.Size = new System.Drawing.Size(75, 23);
            this.btnBufferCount.TabIndex = 3;
            this.btnBufferCount.Text = "buffer30";
            this.btnBufferCount.UseVisualStyleBackColor = true;
            this.btnBufferCount.Click += new System.EventHandler(this.BtnBufferCount_Click);
            // 
            // FrmLog4NetTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBufferCount);
            this.Controls.Add(this.btnFileSize);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.btnInfo);
            this.Name = "FrmLog4NetTest";
            this.Text = "FrmLog4NetTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Button btnFileSize;
        private System.Windows.Forms.Button btnBufferCount;
    }
}