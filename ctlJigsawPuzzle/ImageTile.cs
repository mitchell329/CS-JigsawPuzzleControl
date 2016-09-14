using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ctlJigsawPuzzle
{
    class ImageTile : PictureBox
    {
        #region Fields definition
        const int DEFAULTSIZE = 118;

        private Point originalPosition;
        private Point currentPosition;
        private bool isEmpty;
        private Bitmap tileImage;
        #endregion

        #region Property definition

        public bool IsEmpty
        {
            get { return isEmpty; }
            set { isEmpty = value; }
        }

        public Point OriginalPosition
        {
            get { return originalPosition; }
            set { originalPosition = value; }
        }

        public Point CurrentPosition
        {
            get { return currentPosition; }
            set { currentPosition = value; }
        }

        #endregion

        #region Public methods

        public void setOriginalPosition(int x, int y)
        {
            originalPosition.X = x;
            originalPosition.Y = y;
        }

        public Image GenerateTile(Image image, int indexX, int indexY, int size)
        {
            tileImage = new Bitmap(size, size);
            Graphics g = Graphics.FromImage(tileImage);
            int topLeftX = indexX * (size + 2);
            int topLeftY = indexY * (size + 2);
            Rectangle targetRect = new Rectangle(0, 0, size, size);
            g.DrawImage(image, targetRect, topLeftX, topLeftY, size, size, GraphicsUnit.Pixel);
            g.Dispose();

            return tileImage;
        }

        #endregion
    }
}
