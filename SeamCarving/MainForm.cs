using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SeamCarving
{
    public partial class MainForm : Form
    {
        private SeamCarver seamCarver { get; set; }
        public MainForm()
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
                    /**
                    if (image.Height > picture.Height || image.Width > picture.Width)
                    {
                        // 如果图片过大则报错
                        throw new ImageWidthHeightException("图片过大，请重新选择。");
                    }
                    */
                    // 显示图片与长宽
                    picture.Image = image;
                    originHeight.Text = image.Height.ToString();
                    originWidth.Text = image.Width.ToString();
                    // 初始化裁切对象
                    seamCarver = new SeamCarver(image);
                }
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("文件不存在，请重新选择。");
            }
            catch(IllegalArgumentException ep)
            {
                MessageBox.Show(ep.Message);
            }
            catch
            {
                MessageBox.Show("上传图片出错。");
            }
        }

        private void horizontalSeamButton_Click(object sender, EventArgs e)
        {
            if (seamCarver == null)
            {
                MessageBox.Show("请先上传图片。");
                return;
            }
            try
            {
                seamCarver.RemoveHorizontalSeam(seamCarver.FindHorizontalSeam());
                picture.Image = seamCarver.Picture();
                originWidth.Text = seamCarver.width.ToString();
                originHeight.Text = seamCarver.height.ToString();
            }
            catch (IllegalArgumentException ep)
            {
                MessageBox.Show(ep.Message);
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

        private void verticalSeamButton_Click(object sender, EventArgs e)
        {
            if (seamCarver == null)
            {
                MessageBox.Show("请先上传图片。");
                return;
            }
            try
            {
                seamCarver.RemoveVerticalSeam(seamCarver.FindVerticalSeam());
                picture.Image = seamCarver.Picture();
                originWidth.Text = seamCarver.width.ToString();
                originHeight.Text = seamCarver.height.ToString();
            }
            catch (IllegalArgumentException ep)
            {
                MessageBox.Show(ep.Message);
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

    }
}
