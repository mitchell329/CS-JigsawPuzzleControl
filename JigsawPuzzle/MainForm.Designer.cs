namespace JigsawPuzzle
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctlGameLayout1 = new ctlJigsawPuzzle.ctlGameLayout();
            this.SuspendLayout();
            // 
            // ctlGameLayout1
            // 
            this.ctlGameLayout1.Location = new System.Drawing.Point(12, 12);
            this.ctlGameLayout1.Name = "ctlGameLayout1";
            this.ctlGameLayout1.Size = new System.Drawing.Size(559, 381);
            this.ctlGameLayout1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 402);
            this.Controls.Add(this.ctlGameLayout1);
            this.Name = "MainForm";
            this.Text = "Jigsaw Puzzle";
            this.ResumeLayout(false);

        }

        #endregion

        private ctlJigsawPuzzle.ctlGameLayout ctlGameLayout1;
    }
}

