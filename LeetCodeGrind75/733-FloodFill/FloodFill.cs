using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeGrind75._733_FloodFill
{
    public class Solution733
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            // Check if the new color is the original color
            if (image[sr][sc] != newColor)
            {
                DepthFirstSearch(image, sr, sc, image[sr][sc], newColor);
            }
            return image;
        }
        // Depth First Search Algorithm
        private void DepthFirstSearch(int[][] image, int sr, int sc, int originalColor, int newColor)
        {
            if (sr < 0 || sr >= image.Length || sc < 0 || sc >= image[0].Length || image[sr][sc] != originalColor)
            {
                return;
            }
            image[sr][sc] = newColor;
            DepthFirstSearch(image, sr + 1, sc, originalColor, newColor);
            DepthFirstSearch(image, sr - 1, sc, originalColor, newColor);
            DepthFirstSearch(image, sr, sc + 1, originalColor, newColor);
            DepthFirstSearch(image, sr, sc - 1, originalColor, newColor);
        }
    }
}
