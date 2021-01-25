using System.Drawing;

namespace SeamCarving
{
    interface SeamCarverInterface
    {
        Image Picture();
        double Energy(int x, int y);
        int[] FindHorizontalSeam();
        int[] FindVerticalSeam();
        void RemoveHorizontalSeam(int[] seam);
        void RemoveVerticalSeam(int[] seam);
    }
}
