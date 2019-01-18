namespace WindowsFormsApp1
{
    partial class Precheck
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
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressSpinner2 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressSpinner3 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressSpinner4 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(23, 79);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(35, 36);
            this.metroProgressSpinner1.TabIndex = 0;
            this.metroProgressSpinner1.Click += new System.EventHandler(this.metroProgressSpinner1_Click);
            // 
            // metroProgressSpinner2
            // 
            this.metroProgressSpinner2.Location = new System.Drawing.Point(23, 121);
            this.metroProgressSpinner2.Maximum = 100;
            this.metroProgressSpinner2.Name = "metroProgressSpinner2";
            this.metroProgressSpinner2.Size = new System.Drawing.Size(35, 36);
            this.metroProgressSpinner2.TabIndex = 1;
            // 
            // metroProgressSpinner3
            // 
            this.metroProgressSpinner3.Location = new System.Drawing.Point(23, 163);
            this.metroProgressSpinner3.Maximum = 100;
            this.metroProgressSpinner3.Name = "metroProgressSpinner3";
            this.metroProgressSpinner3.Size = new System.Drawing.Size(35, 36);
            this.metroProgressSpinner3.TabIndex = 2;
            // 
            // metroProgressSpinner4
            // 
            this.metroProgressSpinner4.Location = new System.Drawing.Point(23, 205);
            this.metroProgressSpinner4.Maximum = 100;
            this.metroProgressSpinner4.Name = "metroProgressSpinner4";
            this.metroProgressSpinner4.Size = new System.Drawing.Size(35, 36);
            this.metroProgressSpinner4.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(65, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(184, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Checken of je wifi hebt";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(65, 121);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(244, 25);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Kijken welke .Net versie je hebt";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(65, 163);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(365, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Nakijken of de video\'s kunnen worden geladen";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(65, 205);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(268, 25);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Uitzoeken of Office beschikbaar is";
            // 
            // Precheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 308);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroProgressSpinner4);
            this.Controls.Add(this.metroProgressSpinner3);
            this.Controls.Add(this.metroProgressSpinner2);
            this.Controls.Add(this.metroProgressSpinner1);
            this.MaximizeBox = false;
            this.Name = "Precheck";
            this.Resizable = false;
            this.Text = "Start Voorbereiding";
            this.Load += new System.EventHandler(this.Precheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner2;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner3;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

