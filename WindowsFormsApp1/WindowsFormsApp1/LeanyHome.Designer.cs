namespace Leany
{
    partial class Leany_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leany_Home));
            this.ceftest = new MetroFramework.Controls.MetroTile();
            this.Onenoteweb = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // ceftest
            // 
            this.ceftest.Location = new System.Drawing.Point(23, 328);
            this.ceftest.Name = "ceftest";
            this.ceftest.Size = new System.Drawing.Size(100, 100);
            this.ceftest.TabIndex = 0;
            this.ceftest.TileImage = ((System.Drawing.Image)(resources.GetObject("ceftest.TileImage")));
            this.ceftest.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ceftest.UseTileImage = true;
            this.ceftest.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Onenoteweb
            // 
            this.Onenoteweb.Location = new System.Drawing.Point(139, 328);
            this.Onenoteweb.Name = "Onenoteweb";
            this.Onenoteweb.Size = new System.Drawing.Size(100, 100);
            this.Onenoteweb.TabIndex = 1;
            this.Onenoteweb.TileImage = ((System.Drawing.Image)(resources.GetObject("Onenoteweb.TileImage")));
            this.Onenoteweb.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Onenoteweb.UseTileImage = true;
            this.Onenoteweb.Click += new System.EventHandler(this.OneNote_Click);
            // 
            // Leany_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Onenoteweb);
            this.Controls.Add(this.ceftest);
            this.Name = "Leany_Home";
            this.Text = "Leany Home";
            this.Load += new System.EventHandler(this.Leany_Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile ceftest;
        private MetroFramework.Controls.MetroTile Onenoteweb;
    }
}