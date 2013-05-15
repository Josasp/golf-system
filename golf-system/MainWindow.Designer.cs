namespace golf_system
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anslutTillDatabasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopplaFrånDatabasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databasinställningarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyMedlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medlemslistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tidsbokningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tävlingarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyTävlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tävlingslistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bokaStarttidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bokaÖvrigVerksamhetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bokningslistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connected_statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.medlemToolStripMenuItem,
            this.tävlingarToolStripMenuItem,
            this.tidsbokningToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anslutTillDatabasToolStripMenuItem,
            this.kopplaFrånDatabasToolStripMenuItem,
            this.databasinställningarToolStripMenuItem,
            this.toolStripSeparator1,
            this.avslutaToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // anslutTillDatabasToolStripMenuItem
            // 
            this.anslutTillDatabasToolStripMenuItem.Name = "anslutTillDatabasToolStripMenuItem";
            this.anslutTillDatabasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.anslutTillDatabasToolStripMenuItem.Text = "Anslut till databas";
            this.anslutTillDatabasToolStripMenuItem.Click += new System.EventHandler(this.anslutTillDatabasToolStripMenuItem_Click);
            // 
            // kopplaFrånDatabasToolStripMenuItem
            // 
            this.kopplaFrånDatabasToolStripMenuItem.Enabled = false;
            this.kopplaFrånDatabasToolStripMenuItem.Name = "kopplaFrånDatabasToolStripMenuItem";
            this.kopplaFrånDatabasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.kopplaFrånDatabasToolStripMenuItem.Text = "Koppla från databas";
            this.kopplaFrånDatabasToolStripMenuItem.Click += new System.EventHandler(this.kopplaFrånDatabasToolStripMenuItem_Click);
            // 
            // databasinställningarToolStripMenuItem
            // 
            this.databasinställningarToolStripMenuItem.Name = "databasinställningarToolStripMenuItem";
            this.databasinställningarToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.databasinställningarToolStripMenuItem.Text = "Databasinställningar";
            this.databasinställningarToolStripMenuItem.Click += new System.EventHandler(this.databasinställningarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // medlemToolStripMenuItem
            // 
            this.medlemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyMedlemToolStripMenuItem,
            this.toolStripSeparator3,
            this.medlemslistaToolStripMenuItem});
            this.medlemToolStripMenuItem.Name = "medlemToolStripMenuItem";
            this.medlemToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.medlemToolStripMenuItem.Text = "Medlem";
            // 
            // nyMedlemToolStripMenuItem
            // 
            this.nyMedlemToolStripMenuItem.Name = "nyMedlemToolStripMenuItem";
            this.nyMedlemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nyMedlemToolStripMenuItem.Text = "Ny medlem";
            // 
            // medlemslistaToolStripMenuItem
            // 
            this.medlemslistaToolStripMenuItem.Name = "medlemslistaToolStripMenuItem";
            this.medlemslistaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.medlemslistaToolStripMenuItem.Text = "Medlemslista";
            // 
            // tidsbokningToolStripMenuItem
            // 
            this.tidsbokningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bokaStarttidToolStripMenuItem,
            this.bokaÖvrigVerksamhetToolStripMenuItem,
            this.toolStripSeparator4,
            this.bokningslistaToolStripMenuItem});
            this.tidsbokningToolStripMenuItem.Name = "tidsbokningToolStripMenuItem";
            this.tidsbokningToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.tidsbokningToolStripMenuItem.Text = "Tidsbokning";
            // 
            // tävlingarToolStripMenuItem
            // 
            this.tävlingarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyTävlingToolStripMenuItem,
            this.toolStripSeparator2,
            this.tävlingslistaToolStripMenuItem});
            this.tävlingarToolStripMenuItem.Name = "tävlingarToolStripMenuItem";
            this.tävlingarToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.tävlingarToolStripMenuItem.Text = "Tävlingar";
            // 
            // nyTävlingToolStripMenuItem
            // 
            this.nyTävlingToolStripMenuItem.Name = "nyTävlingToolStripMenuItem";
            this.nyTävlingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nyTävlingToolStripMenuItem.Text = "Ny Tävling";
            // 
            // tävlingslistaToolStripMenuItem
            // 
            this.tävlingslistaToolStripMenuItem.Name = "tävlingslistaToolStripMenuItem";
            this.tävlingslistaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tävlingslistaToolStripMenuItem.Text = "Tävlingslista";
            // 
            // bokaStarttidToolStripMenuItem
            // 
            this.bokaStarttidToolStripMenuItem.Name = "bokaStarttidToolStripMenuItem";
            this.bokaStarttidToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.bokaStarttidToolStripMenuItem.Text = "Boka starttid";
            // 
            // bokaÖvrigVerksamhetToolStripMenuItem
            // 
            this.bokaÖvrigVerksamhetToolStripMenuItem.Name = "bokaÖvrigVerksamhetToolStripMenuItem";
            this.bokaÖvrigVerksamhetToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.bokaÖvrigVerksamhetToolStripMenuItem.Text = "Boka övrig verksamhet";
            // 
            // bokningslistaToolStripMenuItem
            // 
            this.bokningslistaToolStripMenuItem.Name = "bokningslistaToolStripMenuItem";
            this.bokningslistaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.bokningslistaToolStripMenuItem.Text = "Bokningslista";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(191, 6);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connected_statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(426, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connected_statusLabel
            // 
            this.connected_statusLabel.Name = "connected_statusLabel";
            this.connected_statusLabel.Size = new System.Drawing.Size(64, 17);
            this.connected_statusLabel.Text = "Ej ansluten";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 383);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Golf System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anslutTillDatabasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopplaFrånDatabasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databasinställningarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyMedlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medlemslistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tävlingarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyTävlingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tävlingslistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tidsbokningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bokaStarttidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bokaÖvrigVerksamhetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem bokningslistaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connected_statusLabel;
    }
}

