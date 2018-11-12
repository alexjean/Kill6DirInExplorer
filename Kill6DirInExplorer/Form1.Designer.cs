namespace Kill6DirInExplorer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cBox3dObject = new System.Windows.Forms.CheckBox();
            this.cBoxDocuments = new System.Windows.Forms.CheckBox();
            this.cBoxDownloads = new System.Windows.Forms.CheckBox();
            this.cBoxMusic = new System.Windows.Forms.CheckBox();
            this.cBoxDesktop = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxVideos = new System.Windows.Forms.CheckBox();
            this.cBoxPictures = new System.Windows.Forms.CheckBox();
            this.btnDo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBox3dObject
            // 
            this.cBox3dObject.AutoSize = true;
            this.cBox3dObject.Location = new System.Drawing.Point(24, 43);
            this.cBox3dObject.Margin = new System.Windows.Forms.Padding(4);
            this.cBox3dObject.Name = "cBox3dObject";
            this.cBox3dObject.Size = new System.Drawing.Size(75, 20);
            this.cBox3dObject.TabIndex = 0;
            this.cBox3dObject.Text = "3D物件";
            this.cBox3dObject.UseVisualStyleBackColor = true;
            // 
            // cBoxDocuments
            // 
            this.cBoxDocuments.AutoSize = true;
            this.cBoxDocuments.Location = new System.Drawing.Point(24, 123);
            this.cBoxDocuments.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxDocuments.Name = "cBoxDocuments";
            this.cBoxDocuments.Size = new System.Drawing.Size(59, 20);
            this.cBoxDocuments.TabIndex = 1;
            this.cBoxDocuments.Text = "文件";
            this.cBoxDocuments.UseVisualStyleBackColor = true;
            // 
            // cBoxDownloads
            // 
            this.cBoxDownloads.AutoSize = true;
            this.cBoxDownloads.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxDownloads.Location = new System.Drawing.Point(24, 83);
            this.cBoxDownloads.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxDownloads.Name = "cBoxDownloads";
            this.cBoxDownloads.Size = new System.Drawing.Size(59, 20);
            this.cBoxDownloads.TabIndex = 2;
            this.cBoxDownloads.Text = "下載";
            this.cBoxDownloads.UseVisualStyleBackColor = true;
            // 
            // cBoxMusic
            // 
            this.cBoxMusic.AutoSize = true;
            this.cBoxMusic.Location = new System.Drawing.Point(24, 163);
            this.cBoxMusic.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxMusic.Name = "cBoxMusic";
            this.cBoxMusic.Size = new System.Drawing.Size(59, 20);
            this.cBoxMusic.TabIndex = 3;
            this.cBoxMusic.Text = "音樂";
            this.cBoxMusic.UseVisualStyleBackColor = true;
            // 
            // cBoxDesktop
            // 
            this.cBoxDesktop.AutoSize = true;
            this.cBoxDesktop.Location = new System.Drawing.Point(24, 203);
            this.cBoxDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxDesktop.Name = "cBoxDesktop";
            this.cBoxDesktop.Size = new System.Drawing.Size(59, 20);
            this.cBoxDesktop.TabIndex = 4;
            this.cBoxDesktop.Text = "桌面";
            this.cBoxDesktop.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxVideos);
            this.groupBox1.Controls.Add(this.cBox3dObject);
            this.groupBox1.Controls.Add(this.cBoxPictures);
            this.groupBox1.Controls.Add(this.cBoxDocuments);
            this.groupBox1.Controls.Add(this.cBoxMusic);
            this.groupBox1.Controls.Add(this.cBoxDesktop);
            this.groupBox1.Controls.Add(this.cBoxDownloads);
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(285, 338);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "要隱藏的打勾";
            // 
            // cBoxVideos
            // 
            this.cBoxVideos.AutoSize = true;
            this.cBoxVideos.Location = new System.Drawing.Point(24, 283);
            this.cBoxVideos.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxVideos.Name = "cBoxVideos";
            this.cBoxVideos.Size = new System.Drawing.Size(59, 20);
            this.cBoxVideos.TabIndex = 7;
            this.cBoxVideos.Text = "影片";
            this.cBoxVideos.UseVisualStyleBackColor = true;
            // 
            // cBoxPictures
            // 
            this.cBoxPictures.AutoSize = true;
            this.cBoxPictures.Location = new System.Drawing.Point(24, 243);
            this.cBoxPictures.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxPictures.Name = "cBoxPictures";
            this.cBoxPictures.Size = new System.Drawing.Size(59, 20);
            this.cBoxPictures.TabIndex = 6;
            this.cBoxPictures.Text = "圖片";
            this.cBoxPictures.UseVisualStyleBackColor = true;
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(99, 394);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(121, 37);
            this.btnDo.TabIndex = 6;
            this.btnDo.Text = "更改註冊表";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 489);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Kill Dir in 資源管理器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cBox3dObject;
        private System.Windows.Forms.CheckBox cBoxDocuments;
        private System.Windows.Forms.CheckBox cBoxDownloads;
        private System.Windows.Forms.CheckBox cBoxMusic;
        private System.Windows.Forms.CheckBox cBoxDesktop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBoxVideos;
        private System.Windows.Forms.CheckBox cBoxPictures;
        private System.Windows.Forms.Button btnDo;
    }
}

