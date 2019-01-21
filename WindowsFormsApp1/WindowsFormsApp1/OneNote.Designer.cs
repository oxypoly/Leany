namespace Leany
{
    partial class OneNote
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
            this.webrld = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.webgo = new MetroFramework.Controls.MetroTile();
            this.weblink = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(-3, -4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(52, 38);
            this.btnback.Style = MetroFramework.MetroColorStyle.Purple;
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
            this.btnforward.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnforward.TabIndex = 1;
            this.btnforward.Text = ">";
            this.btnforward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnforward.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // webname
            // 
            this.webname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.webname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.webname.Location = new System.Drawing.Point(464, 7);
            this.webname.Name = "webname";
            this.webname.Size = new System.Drawing.Size(139, 27);
            this.webname.TabIndex = 2;
            this.webname.Text = "One Note";
            this.webname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.webname.Click += new System.EventHandler(this.webname_Click);
            // 
            // webframe
            // 
            this.webframe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webframe.Location = new System.Drawing.Point(-3, 33);
            this.webframe.Name = "webframe";
            this.webframe.Size = new System.Drawing.Size(1064, 539);
            this.webframe.TabIndex = 3;
            this.webframe.Paint += new System.Windows.Forms.PaintEventHandler(this.webframe_Paint);
            // 
            // webrld
            // 
            this.webrld.Location = new System.Drawing.Point(95, -1);
            this.webrld.Name = "webrld";
            this.webrld.Size = new System.Drawing.Size(84, 34);
            this.webrld.Style = MetroFramework.MetroColorStyle.Purple;
            this.webrld.TabIndex = 6;
            this.webrld.Text = "Herlaad";
            this.webrld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.webrld.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.webrld.Click += new System.EventHandler(this.webrld_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Location = new System.Drawing.Point(883, 4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(89, 29);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "Terug";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // webgo
            // 
            this.webgo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.webgo.Location = new System.Drawing.Point(-2, 567);
            this.webgo.Name = "webgo";
            this.webgo.Size = new System.Drawing.Size(107, 29);
            this.webgo.Style = MetroFramework.MetroColorStyle.Purple;
            this.webgo.TabIndex = 5;
            this.webgo.Text = "Gaan";
            this.webgo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.webgo.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.webgo.Click += new System.EventHandler(this.webgo_Click);
            // 
            // weblink
            // 
            this.weblink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weblink.Location = new System.Drawing.Point(98, 573);
            this.weblink.Name = "weblink";
            this.weblink.Size = new System.Drawing.Size(845, 23);
            this.weblink.TabIndex = 4;
            this.weblink.Text = "Url";
            this.weblink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OneNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 595);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.webrld);
            this.Controls.Add(this.webframe);
            this.Controls.Add(this.webgo);
            this.Controls.Add(this.weblink);
            this.Controls.Add(this.webname);
            this.Controls.Add(this.btnforward);
            this.Controls.Add(this.btnback);
            this.DisplayHeader = false;
            this.Name = "OneNote";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "OneNote";
            this.Load += new System.EventHandler(this.OneNote_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroTile btnforward;
        private MetroFramework.Controls.MetroLabel webname;
        private System.Windows.Forms.Panel webframe;
        private MetroFramework.Controls.MetroTile webrld;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile webgo;
        private MetroFramework.Controls.MetroTextBox weblink;
    }
}