using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            openFileDialog.Filter = "图片(*.jpg;*.png;*.bmp;*.tiff)|*.jpg;*.png;*.bmp;*.tiff"; // 图片格式
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var pictureFile = openFileDialog.FileName;
                        picture.Image = Image.FromFile(pictureFile);
                    }
                    catch
                    {
                        MessageBox.Show("图片选择有误！");
                    }
                }
            }
            catch
            {
                MessageBox.Show("上传图片出错。");
            }
        }
    }
}
