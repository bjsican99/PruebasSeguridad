namespace Pruebas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeAplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtAplicacion = new System.Windows.Forms.TextBox();
            this.aplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDePerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.pruebasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignacionDeAplicacionesToolStripMenuItem,
            this.aplicacionToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.asignacionDePerfilesToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            this.mantenimientosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientosToolStripMenuItem_Click);
            // 
            // asignacionDeAplicacionesToolStripMenuItem
            // 
            this.asignacionDeAplicacionesToolStripMenuItem.Name = "asignacionDeAplicacionesToolStripMenuItem";
            this.asignacionDeAplicacionesToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.asignacionDeAplicacionesToolStripMenuItem.Text = "Asignacion De Aplicaciones";
            this.asignacionDeAplicacionesToolStripMenuItem.Click += new System.EventHandler(this.asignacionDeAplicacionesToolStripMenuItem_Click);
            // 
            // pruebasToolStripMenuItem
            // 
            this.pruebasToolStripMenuItem.Name = "pruebasToolStripMenuItem";
            this.pruebasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pruebasToolStripMenuItem.Text = "Pruebas";
            this.pruebasToolStripMenuItem.Click += new System.EventHandler(this.pruebasToolStripMenuItem_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(211, 56);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtAplicacion
            // 
            this.txtAplicacion.Location = new System.Drawing.Point(211, 82);
            this.txtAplicacion.Name = "txtAplicacion";
            this.txtAplicacion.Size = new System.Drawing.Size(100, 20);
            this.txtAplicacion.TabIndex = 3;
            // 
            // aplicacionToolStripMenuItem
            // 
            this.aplicacionToolStripMenuItem.Name = "aplicacionToolStripMenuItem";
            this.aplicacionToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.aplicacionToolStripMenuItem.Text = "Aplicacion";
            this.aplicacionToolStripMenuItem.Click += new System.EventHandler(this.aplicacionToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.perfilToolStripMenuItem.Text = "Perfil";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // asignacionDePerfilesToolStripMenuItem
            // 
            this.asignacionDePerfilesToolStripMenuItem.Name = "asignacionDePerfilesToolStripMenuItem";
            this.asignacionDePerfilesToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.asignacionDePerfilesToolStripMenuItem.Text = "Asignacion De Perfiles";
            this.asignacionDePerfilesToolStripMenuItem.Click += new System.EventHandler(this.asignacionDePerfilesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAplicacion);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeAplicacionesToolStripMenuItem;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtAplicacion;
        private System.Windows.Forms.ToolStripMenuItem pruebasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDePerfilesToolStripMenuItem;
    }
}

