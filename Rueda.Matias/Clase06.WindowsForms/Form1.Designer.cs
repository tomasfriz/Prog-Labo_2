﻿namespace Clase06.WindowsForms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPaletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxPaleta = new System.Windows.Forms.GroupBox();
            this.ltsPaleta = new System.Windows.Forms.ListBox();
            this.buttonMas = new System.Windows.Forms.Button();
            this.buttonMenos = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBoxPaleta.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearPaletaToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // crearPaletaToolStripMenuItem
            // 
            this.crearPaletaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperaToolStripMenuItem});
            this.crearPaletaToolStripMenuItem.Name = "crearPaletaToolStripMenuItem";
            this.crearPaletaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.crearPaletaToolStripMenuItem.Text = "Crear Paleta";
            this.crearPaletaToolStripMenuItem.Click += new System.EventHandler(this.crearPaletaToolStripMenuItem_Click);
            // 
            // temperaToolStripMenuItem
            // 
            this.temperaToolStripMenuItem.Name = "temperaToolStripMenuItem";
            this.temperaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.temperaToolStripMenuItem.Text = "Tempera";
            this.temperaToolStripMenuItem.Click += new System.EventHandler(this.temperaToolStripMenuItem_Click);
            // 
            // groupBoxPaleta
            // 
            this.groupBoxPaleta.Controls.Add(this.buttonModificar);
            this.groupBoxPaleta.Controls.Add(this.buttonMenos);
            this.groupBoxPaleta.Controls.Add(this.buttonMas);
            this.groupBoxPaleta.Controls.Add(this.ltsPaleta);
            this.groupBoxPaleta.Location = new System.Drawing.Point(12, 42);
            this.groupBoxPaleta.Name = "groupBoxPaleta";
            this.groupBoxPaleta.Size = new System.Drawing.Size(981, 280);
            this.groupBoxPaleta.TabIndex = 1;
            this.groupBoxPaleta.TabStop = false;
            this.groupBoxPaleta.Text = "Paleta";
            this.groupBoxPaleta.Enter += new System.EventHandler(this.groupBoxPaleta_Enter);
            // 
            // ltsPaleta
            // 
            this.ltsPaleta.FormattingEnabled = true;
            this.ltsPaleta.Location = new System.Drawing.Point(6, 19);
            this.ltsPaleta.Name = "ltsPaleta";
            this.ltsPaleta.Size = new System.Drawing.Size(969, 199);
            this.ltsPaleta.TabIndex = 0;
            // 
            // buttonMas
            // 
            this.buttonMas.Location = new System.Drawing.Point(6, 224);
            this.buttonMas.Name = "buttonMas";
            this.buttonMas.Size = new System.Drawing.Size(114, 50);
            this.buttonMas.TabIndex = 1;
            this.buttonMas.Text = "+";
            this.buttonMas.UseVisualStyleBackColor = true;
            this.buttonMas.Click += new System.EventHandler(this.buttonMas_Click);
            // 
            // buttonMenos
            // 
            this.buttonMenos.Location = new System.Drawing.Point(126, 224);
            this.buttonMenos.Name = "buttonMenos";
            this.buttonMenos.Size = new System.Drawing.Size(114, 50);
            this.buttonMenos.TabIndex = 2;
            this.buttonMenos.Text = "-";
            this.buttonMenos.UseVisualStyleBackColor = true;
            this.buttonMenos.Click += new System.EventHandler(this.buttonMenos_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(246, 224);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(245, 50);
            this.buttonModificar.TabIndex = 3;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 334);
            this.Controls.Add(this.groupBoxPaleta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxPaleta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPaletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxPaleta;
        private System.Windows.Forms.ListBox ltsPaleta;
        private System.Windows.Forms.Button buttonMenos;
        private System.Windows.Forms.Button buttonMas;
        private System.Windows.Forms.Button buttonModificar;
    }
}

