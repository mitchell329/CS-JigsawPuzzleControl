using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ctlJigsawPuzzle
{
    class JigsawController
    {
        #region Fields

        const int THUMBNAILSIZE = 120;
        const int MAINPANELSIZE = 360;
        const int INITIALGRID = 3;
        const int DIFFICULTYSTEPLENGTH = 1;

        private int grid;
        private Image panelImage;
        private ImageTile[,] tileArray;
        private int randomSteps;
        private ImageTile clickedTile;

        #endregion

        #region Properties

        public ImageTile[,] TileArray
        {
            get { return tileArray; }
            set { tileArray = value; }
        }

        public ImageTile ClickedTile
        {
            get { return clickedTile; }
            set { clickedTile = value; }
        }

        #endregion

        #region Constructor

        public JigsawController()
        {
            grid = INITIALGRID;
            randomSteps = Convert.ToInt32(Math.Pow(grid, 5));
        }

        #endregion

        #region Public methods

        public void setGrid(int difficulty)
        {
            grid = INITIALGRID + difficulty * DIFFICULTYSTEPLENGTH;
            randomSteps = Convert.ToInt32(Math.Pow(5, grid));
        }

        public int getGrid()
        {
            return grid;
        }

        public void StartGame()
        {
            tileArray = new ImageTile[grid, grid];
        }

        public Bitmap LoadImage(string imagePath)
        {
            Size thumbnailSize = new Size(THUMBNAILSIZE, THUMBNAILSIZE);
            Size panelSize = new Size(MAINPANELSIZE, MAINPANELSIZE);
            Image selectedImage = Image.FromFile(imagePath);
            panelImage = new Bitmap(selectedImage, panelSize);
            Bitmap thrumbnailImage = new Bitmap(selectedImage, thumbnailSize);
            return thrumbnailImage;
        }

        public void LoadTiles()
        {
            int tileSize = MAINPANELSIZE / grid - 2;
            Size picBoxSize = new Size(tileSize, tileSize);

            PopTileArray(tileSize);

            do
            {
                GenerateRandomTile();
            } while (GameOver());

            return;
        }

        public void MoveTile(int i, int j)
        {
            if (i < grid - 1)
            {
                if (tileArray[i + 1, j].IsEmpty)
                {
                    Exchange(ref tileArray[i, j], ref tileArray[i + 1, j]);
                }
            }
            if (j < grid - 1)
            {
                if (tileArray[i, j + 1].IsEmpty)
                {
                    Exchange(ref tileArray[i, j], ref tileArray[i, j + 1]);
                }
            }
            if (i > 0)
            {
                if (tileArray[i - 1, j].IsEmpty)
                {
                    Exchange(ref tileArray[i, j], ref tileArray[i - 1, j]);
                }
            }
            if (j > 0)
            {
                if (tileArray[i, j - 1].IsEmpty)
                {
                    Exchange(ref tileArray[i, j], ref tileArray[i, j - 1]);
                }
            }
        }

        public bool GameOver()
        {
            foreach (ImageTile tile in tileArray)
            {
                if (tile.CurrentPosition != tile.OriginalPosition)
                {
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region Private methods

        private void PopTileArray(int size)
        {
            for (int i = 0; i < grid; i++)
            {
                for (int j = 0; j < grid; j++)
                {
                    tileArray[i, j] = new ImageTile();
                    InitializeTile(tileArray[i, j], size, i, j);

                    if (!((i == grid - 1) && (j == grid - 1)))
                    {
                        tileArray[i, j].Image = tileArray[i, j].GenerateTile(panelImage, i, j, size);
                        tileArray[i, j].Click += new EventHandler(Tile_OnClick);
                    }
                    else
                    {
                        tileArray[i, j].IsEmpty = true;
                    }
                }
            }
        }

        private void InitializeTile(ImageTile tile, int tileSize, int indexI, int indexJ)
        {
            tile.Size = new Size(tileSize, tileSize);
            tile.setOriginalPosition(indexI, indexJ);
            tile.CurrentPosition = tile.OriginalPosition;
            tile.Location = new Point(((MAINPANELSIZE / grid) * indexI + 1), ((MAINPANELSIZE / grid) * indexJ + 1));
        }

        private void Tile_OnClick(object sender, EventArgs e)
        {
            clickedTile = sender as ImageTile;
            int i = clickedTile.CurrentPosition.X;
            int j = clickedTile.CurrentPosition.Y;
            MoveTile(i, j);

            Point current = clickedTile.CurrentPosition;
            Point origin = clickedTile.OriginalPosition;
            return;
        }

        private void GenerateRandomTile()
        {
            int i = 0, j = 0;

            for (int k = 0; k < randomSteps; k++)
            {
                i = FindRandomTile().X;
                j = FindRandomTile().Y;

                MoveTile(i, j);
            }
        }

        private Point FindRandomTile()
        {
            int m = 0, n = 0;
            Random rnd = new Random();
            bool stepDone = false;

            for (int i = grid - 1; i >= 0; i--)
            {
                for (int j = grid - 1; j >= 0; j--)
                {
                    if (tileArray[i, j].IsEmpty)
                    {
                        do
                        {
                            m = rnd.Next(i - 1, i + 2);
                            if ((m == i - 1) || (m == i + 1))
                            {
                                n = j;
                            }
                            else
                            {
                                do
                                {
                                    n = rnd.Next(j - 1, j + 2);
                                } while (n == j);
                            }
                        } while ((m < 0) || (m >= grid) || (n < 0) || (n >= grid));

                        stepDone = true;
                        break;
                    }
                }
                if (stepDone) break;
            }

            Point p = new Point(m, n);
            return p;
        }

        private void Exchange(ref ImageTile tile1, ref ImageTile tile2)
        {
            Point temp = new Point();

            temp = tile1.Location;
            tile1.Location = tile2.Location;
            tile2.Location = temp;

            temp = tile1.CurrentPosition;
            tile1.CurrentPosition = tile2.CurrentPosition;
            tile2.CurrentPosition = temp;

            ImageTile tempTile = new ImageTile();
            tempTile = tile1;
            tile1 = tile2;
            tile2 = tempTile;
        }

        #endregion
    }
}
