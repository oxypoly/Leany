namespace Leany
{
    partial class Defaulcef
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
            this.btnback = new MetroFramework.Controls.MetroTile();
            this.btnforward = new MetroFramework.Controls.MetroTile();
            this.webname = new MetroFramework.Controls.MetroLabel();
            this.webframe = new System.Windows.Forms.Panel();
            this.weblink = new MetroFramework.Controls.MetroTextBox();
            this.webgo = new MetroFramework.Controls.MetroTile();
            this.webrld = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(-3, -4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(52, 38);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "<";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // btnforward
            // 
            this.btnforward.Location = new System.Drawing.Point(46, -4);
            this.btnforward.Name = "btnforward";
            this.btnforward.Size = new System.Drawing.Size(50, 38);
            this.btnforward.TabIndex = 1;
            this.btnforward.Text = ">";
            this.btnforward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnforward.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // webname
            // 
            this.webname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.webname.Location = new System.Drawing.Point(334, 7);
            this.webname.Name = "webname";
            this.webname.Size = new System.Drawing.Size(139, 27);
            this.webname.TabIndex = 2;
            this.webname.Text = "Default Cef";
            this.webname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // webframe
            // 
            this.webframe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webframe.Location = new System.Drawing.Point(-3, 33);
            this.webframe.Name = "webframe";
            this.webframe.Size = new System.Drawing.Size(804, 394);
            this.webframe.TabIndex = 3;
            this.webframe.Paint += new System.Windows.Forms.PaintEventHandler(this.webframe_Paint);
            // 
            // weblink
            // 
            this.weblink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weblink.Location = new System.Drawing.Point(98, 428);
            this.weblink.Name = "weblink";
            this.weblink.Size = new System.Drawing.Size(585, 23);
            this.weblink.TabIndex = 4;
            this.weblink.Text = "Url";
            this.weblink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // webgo
            // 
            this.webgo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.webgo.Location = new System.Drawing.Point(-2, 427);
            this.webgo.Name = "webgo";
            this.webgo.Size = new System.Drawing.Size(107, 23);
            this.webgo.TabIndex = 5;
            this.webgo.Text = "Gaan";
            this.webgo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.webgo.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.webgo.Click += new System.EventHandler(this.webgo_Click);
            // 
            // webrld
            // 
            this.webrld.Location = new System.Drawing.Point(95, -1);
            this.webrld.Name = "webrld";
            this.webrld.Size = new System.Drawing.Size(84, 34);
            this.webrld.TabIndex = 6;
            this.webrld.Text = "Herlaad";
            this.webrld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.webrld.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(637, 4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(75, 23);
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "Terug";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Defaulcef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.webrld);
            this.Controls.Add(this.webframe);
            this.Controls.Add(this.webgo);
            this.Controls.Add(this.weblink);
            this.Controls.Add(this.webname);
            this.Controls.Add(this.btnforward);
            this.Controls.Add(this.btnback);
            this.DisplayHeader = false;
            this.Name = "Defaulcef";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "Default Cef";
            this.Load += new System.EventHandler(this.OneNote_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroTile btnforward;
        private MetroFramework.Controls.MetroLabel webname;
        private System.Windows.Forms.Panel webframe;
        private MetroFramework.Controls.MetroTextBox weblink;
        private MetroFramework.Controls.MetroTile webgo;
        private MetroFramework.Controls.MetroTile webrld;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}