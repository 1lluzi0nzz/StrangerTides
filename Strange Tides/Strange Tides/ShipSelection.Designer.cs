
namespace Strange_Tides
{
    partial class ShipSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipSelection));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSloop = new System.Windows.Forms.Button();
            this.buttonBrig = new System.Windows.Forms.Button();
            this.buttonGalleon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 681);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSloop
            // 
            this.buttonSloop.Location = new System.Drawing.Point(8, 8);
            this.buttonSloop.Name = "buttonSloop";
            this.buttonSloop.Size = new System.Drawing.Size(168, 59);
            this.buttonSloop.TabIndex = 1;
            this.buttonSloop.Text = "Sloop";
            this.buttonSloop.UseVisualStyleBackColor = true;
            // 
            // buttonBrig
            // 
            this.buttonBrig.Location = new System.Drawing.Point(182, 8);
            this.buttonBrig.Name = "buttonBrig";
            this.buttonBrig.Size = new System.Drawing.Size(168, 59);
            this.buttonBrig.TabIndex = 2;
            this.buttonBrig.Text = "Brigantine";
            this.buttonBrig.UseVisualStyleBackColor = true;
            // 
            // buttonGalleon
            // 
            this.buttonGalleon.Location = new System.Drawing.Point(356, 8);
            this.buttonGalleon.Name = "buttonGalleon";
            this.buttonGalleon.Size = new System.Drawing.Size(168, 59);
            this.buttonGalleon.TabIndex = 3;
            this.buttonGalleon.Text = "Galleon";
            this.buttonGalleon.UseVisualStyleBackColor = true;
            // 
            // ShipSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.buttonGalleon);
            this.Controls.Add(this.buttonBrig);
            this.Controls.Add(this.buttonSloop);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ShipSelection";
            this.Text = "ShipSelection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSloop;
        private System.Windows.Forms.Button buttonBrig;
        private System.Windows.Forms.Button buttonGalleon;
    }
}