using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SeamCarving
{
    public partial class SeamCarving : Form
    {
        public SeamCarving()
        {
            InitializeComponent();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            // 图片格式
            openFileDialog.Filter = "图片(*.jpg;*.png;*.bmp;*.tiff)|*.jpg;*.png;*.bmp;*.tiff";
            try
            {
                // 打开图片
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var pictureFile = openFileDialog.FileName;
                    var image = Image.FromFile(pictureFile);
                    if (image.Height > picture.Height || image.Width > picture.Width)
                    {
                        // 如果图片过大则报错
                        throw new ImageWidthHeightException();
                    }
                    // 显示图片与长宽
                    picture.Image = image;
                    originHeight.Text = image.Height.ToString();
                    originWidth.Text = image.Width.ToString();
                }
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("文件不存在，请重新选择。");
            }
            catch(ImageWidthHeightException)
            {
                MessageBox.Show("图片过大，请重新选择。");
            }
            catch
            {
                MessageBox.Show("上传图片出错。");
            }
        }

        private void carvingButton_Click(object sender, EventArgs e)
        {
            // todo 裁切
            try
            {
                Bitmap bitmap = new Bitmap(picture.Image);
                for (var i = 0; i < bitmap.Width; ++i)
                {
                    for (var j = 0; j < bitmap.Height; ++j)
                    {
                        Color newColor = Color.FromArgb(bitmap.GetPixel(i, j).R, 0, 0);
                        bitmap.SetPixel(i, j, newColor);
                    }
                }
                picture.Image = bitmap;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("裁切时发生错误");
            }
        }

        private class ImageWidthHeightException :  Exception { }
    }
}
