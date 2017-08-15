namespace WinBatchDownload
{
    partial class FrmBatchDownload
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDownLoad = new System.Windows.Forms.DataGridView();
            this.btnStartDownLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDownLoad
            // 
            this.dgvDownLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDownLoad.Location = new System.Drawing.Point(3, 49);
            this.dgvDownLoad.Name = "dgvDownLoad";
            this.dgvDownLoad.RowTemplate.Height = 23;
            this.dgvDownLoad.Size = new System.Drawing.Size(691, 346);
            this.dgvDownLoad.TabIndex = 0;
            // 
            // btnStartDownLoad
            // 
            this.btnStartDownLoad.Location = new System.Drawing.Point(611, 12);
            this.btnStartDownLoad.Name = "btnStartDownLoad";
            this.btnStartDownLoad.Size = new System.Drawing.Size(75, 23);
            this.btnStartDownLoad.TabIndex = 1;
            this.btnStartDownLoad.Text = "开始下载";
            this.btnStartDownLoad.UseVisualStyleBackColor = true;
            this.btnStartDownLoad.Click += new System.EventHandler(this.btnStartDownLoad_Click);
            // 
            // FrmBatchDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 398);
            this.Controls.Add(this.btnStartDownLoad);
            this.Controls.Add(this.dgvDownLoad);
            this.Name = "FrmBatchDownload";
            this.Text = "多线程批量下载";
            this.Load += new System.EventHandler(this.FrmBatchDownload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDownLoad;
        private System.Windows.Forms.Button btnStartDownLoad;
    }
}

