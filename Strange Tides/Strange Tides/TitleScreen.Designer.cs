
namespace Strange_Tides
{
    partial class TitleScreen{
        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pickShipButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 720);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pickShipButton
            // 
            this.pickShipButton.Location = new System.Drawing.Point(47, 35);
            this.pickShipButton.Name = "pickShipButton";
            this.pickShipButton.Size = new System.Drawing.Size(311, 77);
            this.pickShipButton.TabIndex = 1;
            this.pickShipButton.Text = "Pick Ship";
            this.pickShipButton.UseVisualStyleBackColor = true;
            this.pickShipButton.Click += new System.EventHandler(this.pickShipButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(47, 156);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(311, 77);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(47, 276);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(311, 77);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // TitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.pickShipButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TitleScreen";
            this.Text = "Strange Tides";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button pickShipButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button quitButton;
    }
}

