using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctlJigsawPuzzle
{
    public enum difficulty { Easy, Medium, Hard};

    public partial class ctlGameLayout: UserControl
    {
        #region Fields
        const string ZERO = "0";
        const string START = "Start";
        const string ABORT = "Abort";
        const string ERROR = "Error";
        const string ALERT = "Alert";
        const string LOADERRORMSG = "Sorry, the image cannot be loaded. Please select another one.\n Error: \n";
        const string SELECTIMAGEMSG = "Please select an image to play.";
        const string ABORTMSG = "Are you sure you want to abort current game?";
        const string WINMSG = "You win! Your total steps are: ";
        const string WINCAPTION = "Congratulations!";

        private int selectedDifficulty;
        private JigsawController theController;
        #endregion

        #region Constructor
        public ctlGameLayout()
        {
            InitializeComponent();
            cmbDifficulty.DataSource = Enum.GetNames(typeof(difficulty));
            theController = new JigsawController();
            selectedDifficulty = cmbDifficulty.SelectedIndex;
            theController.setGrid(selectedDifficulty);
            lblGrid.Text = theController.getGrid().ToString() + " * " + theController.getGrid().ToString();
        }
        #endregion

        #region Private methods

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (dlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picbThumbnailImg.Image = theController.LoadImage(dlgOpenImage.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(LOADERRORMSG + ex.Message, ERROR);
                }
            }
        }

        private void cmbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDifficulty = cmbDifficulty.SelectedIndex;
            if (theController != null)
            {
                theController.setGrid(selectedDifficulty);
                lblGrid.Text = theController.getGrid().ToString() + " * " + theController.getGrid().ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (picbThumbnailImg.Image == null)
            {
                MessageBox.Show(SELECTIMAGEMSG, ALERT);
            }
            else if (btnStart.Text == START)
            {
                theController.StartGame();
                lblSteps.Text = ZERO;
                btnSelectImage.Enabled = false;
                cmbDifficulty.Enabled = false;
                btnStart.Text = ABORT;

                theController.LoadTiles();

                for (int i = 0; i < theController.getGrid(); i++)
                {
                    for (int j = 0; j < theController.getGrid(); j++)
                    {
                        pnlMain.Controls.Add(theController.TileArray[i, j]);
                        theController.TileArray[i, j].MouseClick += new MouseEventHandler(TileMoved);
                    }
                }
            }
            else if (btnStart.Text == ABORT)
            {
                if (MessageBox.Show(ABORTMSG, ALERT, MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    NewGame();
                }
            }
        }

        private void TileMoved(object sender, EventArgs e)
        {
            int steps = Convert.ToInt32(lblSteps.Text);
            steps += 1;
            lblSteps.Text = steps.ToString();

            if (theController.GameOver())
            {
                MessageBox.Show(WINMSG + lblSteps.Text, WINCAPTION);
                NewGame();
            }
        }

        private void NewGame()
        {
            pnlMain.Controls.Clear();
            lblSteps.Text = ZERO;
            btnSelectImage.Enabled = true;
            cmbDifficulty.Enabled = true;
            btnStart.Text = START;
        }

        #endregion
    }
}
