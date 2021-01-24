using System;
using System.Drawing;

namespace SeamCarving
{
    class SeamCarver
    {
        public int width { get; private set; }
        public int height { get; private set; }
        private Color[,] RGBMatrix { get; set; }

        public SeamCarver(Image picture)
        {
            Bitmap bitmap = new Bitmap(picture);
            width = bitmap.Width; height = bitmap.Height;
            RGBMatrix = new Color[width, height];
            for (var i = 0; i < width; ++i)
            {
                for (var j = 0; j < height; ++j)
                {
                    RGBMatrix[i, j] = bitmap.GetPixel(i, j);
                }
            }
        }

        public Image Picture()
        {
            Bitmap bitmap = new Bitmap(width, height);
            for (var i = 0; i < width; ++i)
            {
                for (var j = 0; j < height; ++j)
                {
                    bitmap.SetPixel(i, j, RGBMatrix[i, j]);
                }
            }
            return bitmap;
        }

        public double Energy(int x, int y)
        {
            if (x < 0 || x >= width || y < 0 || y >= height)
            {
                throw new IllegalArgumentException("所计算的点超出图片边界");
            }
            int lx = (x + width - 1) % width, rx = (x + width + 1) % width;
            int uy = (y + height - 1) % height, dy = (y + height + 1) % height;
            double deltaX = (RGBMatrix[lx, y].R - RGBMatrix[rx, y].R) * (RGBMatrix[lx, y].R - RGBMatrix[rx, y].R)
                + (RGBMatrix[lx, y].G - RGBMatrix[rx, y].G) * (RGBMatrix[lx, y].G - RGBMatrix[rx, y].G) +
                +(RGBMatrix[lx, y].B - RGBMatrix[rx, y].B) * (RGBMatrix[lx, y].B - RGBMatrix[rx, y].B);
            double deltaY = (RGBMatrix[x, uy].R - RGBMatrix[x, dy].R) * (RGBMatrix[x, uy].R - RGBMatrix[x, dy].R)
                + (RGBMatrix[x, uy].G - RGBMatrix[x, dy].G) * (RGBMatrix[x, uy].G - RGBMatrix[x, dy].G) +
                +(RGBMatrix[x, uy].B - RGBMatrix[x, dy].B) * (RGBMatrix[x, uy].B - RGBMatrix[x, dy].B);
            return Math.Sqrt(deltaX + deltaY);
        }

        public int[] FindHorizontalSeam()
        {
            // dp 数组
            var energyMatrix = new double[width, height];
            // 记录最短路径
            var father = new int[width, height];
            for (var j = 0; j < height; ++j)
            {
                energyMatrix[0, j] = Energy(0, j);
            }
            for (var i = 1; i < width; ++i)
            {
                for (var j = 0; j < height; ++j)
                {
                    var temp = j;
                    if (j > 0 && energyMatrix[i - 1, j - 1] < energyMatrix[i - 1, temp])
                    {
                        temp = j - 1;

                    }
                    if (j < height - 1 && energyMatrix[i - 1, j + 1] < energyMatrix[i - 1, temp])
                    {
                        temp = j + 1;
                    }
                    father[i, j] = temp;
                    energyMatrix[i, j] = energyMatrix[i - 1, temp] + Energy(i, j);
                }
            }
            var res = new int[width];
            var start = 0;
            for (var j = 1; j < height; ++j)
            {
                if (energyMatrix[width - 1, j] < energyMatrix[width - 1, start])
                {
                    start = j;
                }
            }
            res[width - 1] = start;
            for (var i = width - 1; i > 0; --i)
            {
                res[i - 1] = father[i, start];
                start = father[i, start];
            }
            return res;
        }

        public int[] FindVerticalSeam()
        {
            // dp 数组
            var energyMatrix = new double[width, height];
            // 记录最短路径
            var father = new int[width, height];
            for (var i = 0; i < width; ++i)
            {
                energyMatrix[i, 0] = Energy(i, 0);
            }
            for (var j = 1; j < height; ++j)
            {
                for (var i = 0; i < width; ++i)
                {
                    var temp = i;
                    if (i > 0 && energyMatrix[i - 1, j - 1] < energyMatrix[temp, j - 1])
                    {
                        temp = i - 1;

                    }
                    if (i < width - 1 && energyMatrix[i + 1, j - 1] < energyMatrix[temp, j - 1])
                    {
                        temp = i + 1;
                    }
                    father[i, j] = temp;
                    energyMatrix[i, j] = energyMatrix[temp, j - 1] + Energy(i, j);
                }
            }
            var res = new int[height];
            var start = 0;
            for (var i = 1; i < width; ++i)
            {
                if (energyMatrix[i, height - 1] < energyMatrix[start, height - 1])
                {
                    start = i;
                }
            }
            res[height - 1] = start;
            for (var j = height - 1; j > 0; --j)
            {
                res[j - 1] = father[start, j];
                start = father[start, j];
            }
            return res;
        }

        public void RemoveHorizontalSeam(int[] seam)
        {
            if (seam == null)
            {
                throw new IllegalArgumentException("传入数组不得为空。");
            }
            if (seam.Length != width)
            {
                throw new IllegalArgumentException("传入数组长度与图片不匹配。");
            }
            if (height <= 1)
            {
                throw new IllegalArgumentException("高度不足，无法裁切。");
            }
            height -= 1;
            for (var i = 0; i < width; ++i)
            {
                for (var j = seam[i]; j < height; ++j)
                {
                    RGBMatrix[i, j] = RGBMatrix[i, j + 1];
                }
            }
        }

        public void RemoveVerticalSeam(int[] seam)
        {
            if (seam == null)
            {
                throw new IllegalArgumentException("传入数组不得为空。");
            }
            if (seam.Length != height)
            {
                throw new IllegalArgumentException("传入数组长度与图片不匹配。");
            }
            if (width <= 1)
            {
                throw new IllegalArgumentException("宽度不足，无法裁切。");
            }
            width -= 1;
            for (var j = 0; j < height; ++j)
            {
                for (var i = seam[j]; i < width; ++i)
                {
                    RGBMatrix[i, j] = RGBMatrix[i + 1, j];
                }
            }
        }
    }
}
