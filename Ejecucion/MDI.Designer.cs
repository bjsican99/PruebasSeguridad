﻿namespace Ejecucion
{
    partial class MDI
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeAplicacionAPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.asiganacionDeAplicacionesAUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 414);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(738, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.asiganacionDeAplicacionesAUsuarioToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoPerfilToolStripMenuItem,
            this.asignacionDeAplicacionAPerfilToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // mantenimientoPerfilToolStripMenuItem
            // 
            this.mantenimientoPerfilToolStripMenuItem.Name = "mantenimientoPerfilToolStripMenuItem";
            this.mantenimientoPerfilToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.mantenimientoPerfilToolStripMenuItem.Text = "Mantenimiento perfil";
            this.mantenimientoPerfilToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoPerfilToolStripMenuItem_Click);
            // 
            // asignacionDeAplicacionAPerfilToolStripMenuItem
            // 
            this.asignacionDeAplicacionAPerfilToolStripMenuItem.Name = "asignacionDeAplicacionAPerfilToolStripMenuItem";
            this.asignacionDeAplicacionAPerfilToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.asignacionDeAplicacionAPerfilToolStripMenuItem.Text = "Asignacion de aplicacion a perfil";
            this.asignacionDeAplicacionAPerfilToolStripMenuItem.Click += new System.EventHandler(this.asignacionDeAplicacionAPerfilToolStripMenuItem_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(0, 414);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // asiganacionDeAplicacionesAUsuarioToolStripMenuItem
            // 
            this.asiganacionDeAplicacionesAUsuarioToolStripMenuItem.Name = "asiganacionDeAplicacionesAUsuarioToolStripMenuItem";
            this.asiganacionDeAplicacionesAUsuarioToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.asiganacionDeAplicacionesAUsuarioToolStripMenuItem.Text = "asignacion de perfil y aplicaciones";
            this.asiganacionDeAplicacionesAUsuarioToolStripMenuItem.Click += new System.EventHandler(this.asiganacionDeAplicacionesAUsuarioToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 436);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDI";
            this.Text = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeAplicacionAPerfilToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem asiganacionDeAplicacionesAUsuarioToolStripMenuItem;
    }
}



