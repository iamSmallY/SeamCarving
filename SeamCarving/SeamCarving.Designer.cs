
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.originWidth = new System.Windows.Forms.TextBox();
            this.originHeight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(754, 507);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.widthLabel.Location = new System.Drawing.Point(772, 130);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(104, 19);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "目标宽度：";
            // 
            // widthInput
            // 
            this.widthInput.Font = new System.Drawing.Font("宋体", 14F);
            this.widthInput.Location = new System.Drawing.Point(882, 127);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(100, 29);
            this.widthInput.TabIndex = 2;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.heightLabel.Location = new System.Drawing.Point(772, 179);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(104, 19);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "目标高度：";
            // 
            // heightInput
            // 
            this.heightInput.Font = new System.Drawing.Font("宋体", 14F);
            this.heightInput.Location = new System.Drawing.Point(882, 176);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(100, 29);
            this.heightInput.TabIndex = 4;
            // 
            // carvingButton
            // 
            this.carvingButton.Font = new System.Drawing.Font("宋体", 14F);
            this.carvingButton.Location = new System.Drawing.Point(882, 243);
            this.carvingButton.Name = "carvingButton";
            this.carvingButton.Size = new System.Drawing.Size(100, 30);
            this.carvingButton.TabIndex = 5;
            this.carvingButton.Text = "裁 切";
            this.carvingButton.UseVisualStyleBackColor = true;
            this.carvingButton.Click += new System.EventHandler(this.carvingButton_Click);
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
            this.label1.Text = "原图宽度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(772, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "原图高度：";
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
            // SeamCarving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 544);
            this.Controls.Add(this.originHeight);
            this.Controls.Add(this.originWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.carvingButton);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox originWidth;
        private System.Windows.Forms.TextBox originHeight;
    }
}

