
namespace SeamCarving
{
    partial class SeamCarving
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
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.carvingButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(649, 426);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.widthLabel.Location = new System.Drawing.Point(667, 24);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(66, 19);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "宽度：";
            // 
            // widthInput
            // 
            this.widthInput.Font = new System.Drawing.Font("宋体", 14F);
            this.widthInput.Location = new System.Drawing.Point(688, 46);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(100, 29);
            this.widthInput.TabIndex = 2;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.heightLabel.Location = new System.Drawing.Point(667, 95);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(66, 19);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "高度：";
            // 
            // heightInput
            // 
            this.heightInput.Font = new System.Drawing.Font("宋体", 14F);
            this.heightInput.Location = new System.Drawing.Point(688, 117);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(100, 29);
            this.heightInput.TabIndex = 4;
            // 
            // carvingButton
            // 
            this.carvingButton.Font = new System.Drawing.Font("宋体", 14F);
            this.carvingButton.Location = new System.Drawing.Point(688, 176);
            this.carvingButton.Name = "carvingButton";
            this.carvingButton.Size = new System.Drawing.Size(100, 30);
            this.carvingButton.TabIndex = 5;
            this.carvingButton.Text = "裁 切";
            this.carvingButton.UseVisualStyleBackColor = true;
            // 
            // uploadButton
            // 
            this.uploadButton.Font = new System.Drawing.Font("宋体", 14F);
            this.uploadButton.Location = new System.Drawing.Point(688, 400);
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
            // SeamCarving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.carvingButton);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.picture);
            this.Name = "SeamCarving";
            this.Text = "图像裁切工具";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.Button carvingButton;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

