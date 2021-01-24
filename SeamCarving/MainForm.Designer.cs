
namespace SeamCarving
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picture = new System.Windows.Forms.PictureBox();
            this.verticalSeamButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.originWidth = new System.Windows.Forms.TextBox();
            this.originHeight = new System.Windows.Forms.TextBox();
            this.horizontalSeamButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(754, 507);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // verticalSeamButton
            // 
            this.verticalSeamButton.Font = new System.Drawing.Font("宋体", 14F);
            this.verticalSeamButton.Location = new System.Drawing.Point(882, 206);
            this.verticalSeamButton.Name = "verticalSeamButton";
            this.verticalSeamButton.Size = new System.Drawing.Size(100, 30);
            this.verticalSeamButton.TabIndex = 5;
            this.verticalSeamButton.Text = "纵向裁切";
            this.verticalSeamButton.UseVisualStyleBackColor = true;
            this.verticalSeamButton.Click += new System.EventHandler(this.verticalSeamButton_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Font = new System.Drawing.Font("宋体", 14F);
            this.uploadButton.Location = new System.Drawing.Point(882, 481);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(100, 38);
            this.uploadButton.TabIndex = 6;
            this.uploadButton.Text = "上传图片";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(772, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "图片宽度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(772, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "图片高度：";
            // 
            // originWidth
            // 
            this.originWidth.Enabled = false;
            this.originWidth.Font = new System.Drawing.Font("宋体", 14F);
            this.originWidth.Location = new System.Drawing.Point(882, 26);
            this.originWidth.Name = "originWidth";
            this.originWidth.Size = new System.Drawing.Size(100, 29);
            this.originWidth.TabIndex = 9;
            // 
            // originHeight
            // 
            this.originHeight.Enabled = false;
            this.originHeight.Font = new System.Drawing.Font("宋体", 14F);
            this.originHeight.Location = new System.Drawing.Point(882, 70);
            this.originHeight.Name = "originHeight";
            this.originHeight.Size = new System.Drawing.Size(100, 29);
            this.originHeight.TabIndex = 10;
            // 
            // horizontalSeamButton
            // 
            this.horizontalSeamButton.Font = new System.Drawing.Font("宋体", 14F);
            this.horizontalSeamButton.Location = new System.Drawing.Point(882, 156);
            this.horizontalSeamButton.Name = "horizontalSeamButton";
            this.horizontalSeamButton.Size = new System.Drawing.Size(100, 30);
            this.horizontalSeamButton.TabIndex = 11;
            this.horizontalSeamButton.Text = "横向裁切";
            this.horizontalSeamButton.UseVisualStyleBackColor = true;
            this.horizontalSeamButton.Click += new System.EventHandler(this.horizontalSeamButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 536);
            this.Controls.Add(this.horizontalSeamButton);
            this.Controls.Add(this.originHeight);
            this.Controls.Add(this.originWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.verticalSeamButton);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "图像裁切工具";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button verticalSeamButton;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox originWidth;
        private System.Windows.Forms.TextBox originHeight;
        private System.Windows.Forms.Button horizontalSeamButton;
    }
}

