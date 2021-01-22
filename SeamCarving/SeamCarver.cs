using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeamCarving
{
    class SeamCarver
    {
        public Bitmap picture { get; }
        public int width { get; }
        public int height { get; }

        public SeamCarver(Bitmap picture)
        {
            this.picture = picture;
            this.width = picture.Width;
            this.height = picture.Height;
        }

        public double Energy(int x, int y)
        {
            return 0;
        }

        public List<int> FindHorizontalSeam()
        {
            return new List<int>();
        }

        public List<int> FindVerticalSeam()
        {
            return new List<int>();
        }

        public void RemoveHorizontalSeam(List<int> seam)
        {

        }

        public void RemoveVerticalSeam(List<int> seam)
        {

        }
    }
}
