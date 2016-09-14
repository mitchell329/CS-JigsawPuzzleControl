namespace ctlJigsawPuzzle
{
    partial class ctlGameLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.picbThumbnailImg = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.dlgOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGrid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbThumbnailImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Location = new System.Drawing.Point(10, 10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(360, 360);
            this.pnlMain.TabIndex = 0;
            // 
            // picbThumbnailImg
            // 
            this.picbThumbnailImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbThumbnailImg.Location = new System.Drawing.Point(404, 10);
            this.picbThumbnailImg.Name = "picbThumbnailImg";
            this.picbThumbnailImg.Size = new System.Drawing.Size(120, 120);
            this.picbThumbnailImg.TabIndex = 1;
            this.picbThumbnailImg.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImage.Location = new System.Drawing.Point(404, 136);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(120, 33);
            this.btnSelectImage.TabIndex = 2;
            this.btnSelectImage.Text = "Select an Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Difficulty:";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "3 * 3",
            "4 * 4"});
            this.cmbDifficulty.Location = new System.Drawing.Point(404, 200);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(120, 23);
            this.cmbDifficulty.TabIndex = 4;
            this.cmbDifficulty.SelectedIndexChanged += new System.EventHandler(this.cmbDifficulty_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Steps:";
            // 
            // lblSteps
            // 
            this.lblSteps.BackColor = System.Drawing.Color.Wheat;
            this.lblSteps.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteps.Location = new System.Drawing.Point(449, 277);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(75, 24);
            this.lblSteps.TabIndex = 6;
            this.lblSteps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(404, 320);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 33);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dlgOpenImage
            // 
            this.dlgOpenImage.InitialDirectory = "C:\\TEMP\\ctlJigsawPuzzle\\images";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Grid:";
            // 
            // lblGrid
            // 
            this.lblGrid.BackColor = System.Drawing.Color.Wheat;
            this.lblGrid.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrid.Location = new System.Drawing.Point(449, 239);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(75, 24);
            this.lblGrid.TabIndex = 9;
            this.lblGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctlGameLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.picbThumbnailImg);
            this.Controls.Add(this.pnlMain);
            this.Name = "ctlGameLayout";
            this.Size = new System.Drawing.Size(559, 381);
            ((System.ComponentModel.ISupportInitialize)(this.picbThumbnailImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox picbThumbnailImg;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.OpenFileDialog dlgOpenImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGrid;
    }
}
