namespace PracticaparaExamen
{
    partial class frmPrincipal
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
            menuStrip_Principal = new MenuStrip();
            estudiantesToolStripMenuItem = new ToolStripMenuItem();
            regularToolStripMenuItem = new ToolStripMenuItem();
            pregradoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip_Principal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_Principal
            // 
            menuStrip_Principal.Items.AddRange(new ToolStripItem[] { estudiantesToolStripMenuItem });
            menuStrip_Principal.Location = new Point(0, 0);
            menuStrip_Principal.Name = "menuStrip_Principal";
            menuStrip_Principal.Size = new Size(800, 24);
            menuStrip_Principal.TabIndex = 0;
            menuStrip_Principal.Text = "menuStrip1";
            // 
            // estudiantesToolStripMenuItem
            // 
            estudiantesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { regularToolStripMenuItem, pregradoToolStripMenuItem });
            estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            estudiantesToolStripMenuItem.Size = new Size(79, 20);
            estudiantesToolStripMenuItem.Text = "Estudiantes";
            // 
            // regularToolStripMenuItem
            // 
            regularToolStripMenuItem.Name = "regularToolStripMenuItem";
            regularToolStripMenuItem.Size = new Size(180, 22);
            regularToolStripMenuItem.Text = "Regular";
            regularToolStripMenuItem.Click += regularToolStripMenuItem_Click;
            // 
            // pregradoToolStripMenuItem
            // 
            pregradoToolStripMenuItem.Name = "pregradoToolStripMenuItem";
            pregradoToolStripMenuItem.Size = new Size(180, 22);
            pregradoToolStripMenuItem.Text = "Pregrado";
            pregradoToolStripMenuItem.Click += pregradoToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip_Principal);
            MainMenuStrip = menuStrip_Principal;
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            menuStrip_Principal.ResumeLayout(false);
            menuStrip_Principal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_Principal;
        private ToolStripMenuItem estudiantesToolStripMenuItem;
        private ToolStripMenuItem regularToolStripMenuItem;
        private ToolStripMenuItem pregradoToolStripMenuItem;
    }
}