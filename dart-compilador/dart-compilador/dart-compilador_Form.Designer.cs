namespace dart_compilador
{
    partial class dart_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dart_Form));
            this.menu_mStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compiladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autómataFinitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaDeTokensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lexico_Dgv = new System.Windows.Forms.DataGridView();
            this.lexico_Lbl = new System.Windows.Forms.Label();
            this.errores_Dgv = new System.Windows.Forms.DataGridView();
            this.errores_Lbl = new System.Windows.Forms.Label();
            this.semantico_Dgv = new System.Windows.Forms.DataGridView();
            this.semantico_Lbl = new System.Windows.Forms.Label();
            this.txtCodigoFuente = new System.Windows.Forms.TextBox();
            this.codigo_Lbl = new System.Windows.Forms.Label();
            this.menu_mStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lexico_Dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errores_Dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semantico_Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_mStrip
            // 
            this.menu_mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.compiladorToolStripMenuItem});
            this.menu_mStrip.Location = new System.Drawing.Point(0, 0);
            this.menu_mStrip.Name = "menu_mStrip";
            this.menu_mStrip.Size = new System.Drawing.Size(1382, 24);
            this.menu_mStrip.TabIndex = 0;
            this.menu_mStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.CerrarToolStripMenuItem_Click);
            // 
            // compiladorToolStripMenuItem
            // 
            this.compiladorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarToolStripMenuItem,
            this.autómataFinitoToolStripMenuItem,
            this.tablaDeTokensToolStripMenuItem});
            this.compiladorToolStripMenuItem.Name = "compiladorToolStripMenuItem";
            this.compiladorToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.compiladorToolStripMenuItem.Text = "Compilador";
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ejecutarToolStripMenuItem.Text = "Ejecutar";
            this.ejecutarToolStripMenuItem.Click += new System.EventHandler(this.EjecutarToolStripMenuItem_Click);
            // 
            // autómataFinitoToolStripMenuItem
            // 
            this.autómataFinitoToolStripMenuItem.Name = "autómataFinitoToolStripMenuItem";
            this.autómataFinitoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.autómataFinitoToolStripMenuItem.Text = "Autómata Finito";
            this.autómataFinitoToolStripMenuItem.Click += new System.EventHandler(this.AutómataFinitoToolStripMenuItem_Click);
            // 
            // tablaDeTokensToolStripMenuItem
            // 
            this.tablaDeTokensToolStripMenuItem.Name = "tablaDeTokensToolStripMenuItem";
            this.tablaDeTokensToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.tablaDeTokensToolStripMenuItem.Text = "Tabla de Tokens";
            this.tablaDeTokensToolStripMenuItem.Click += new System.EventHandler(this.TablaDeTokensToolStripMenuItem_Click);
            // 
            // lexico_Dgv
            // 
            this.lexico_Dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(130)))));
            this.lexico_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lexico_Dgv.Location = new System.Drawing.Point(369, 75);
            this.lexico_Dgv.Name = "lexico_Dgv";
            this.lexico_Dgv.Size = new System.Drawing.Size(470, 240);
            this.lexico_Dgv.TabIndex = 2;
            // 
            // lexico_Lbl
            // 
            this.lexico_Lbl.AutoSize = true;
            this.lexico_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lexico_Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(159)))), ((int)(((byte)(222)))));
            this.lexico_Lbl.Location = new System.Drawing.Point(365, 48);
            this.lexico_Lbl.Name = "lexico_Lbl";
            this.lexico_Lbl.Size = new System.Drawing.Size(72, 24);
            this.lexico_Lbl.TabIndex = 3;
            this.lexico_Lbl.Text = "Léxico";
            // 
            // errores_Dgv
            // 
            this.errores_Dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(130)))));
            this.errores_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.errores_Dgv.Location = new System.Drawing.Point(369, 405);
            this.errores_Dgv.Name = "errores_Dgv";
            this.errores_Dgv.Size = new System.Drawing.Size(970, 240);
            this.errores_Dgv.TabIndex = 6;
            // 
            // errores_Lbl
            // 
            this.errores_Lbl.AutoSize = true;
            this.errores_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errores_Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(159)))), ((int)(((byte)(222)))));
            this.errores_Lbl.Location = new System.Drawing.Point(365, 378);
            this.errores_Lbl.Name = "errores_Lbl";
            this.errores_Lbl.Size = new System.Drawing.Size(79, 24);
            this.errores_Lbl.TabIndex = 7;
            this.errores_Lbl.Text = "Errores";
            // 
            // semantico_Dgv
            // 
            this.semantico_Dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(130)))));
            this.semantico_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.semantico_Dgv.Enabled = false;
            this.semantico_Dgv.Location = new System.Drawing.Point(869, 75);
            this.semantico_Dgv.Name = "semantico_Dgv";
            this.semantico_Dgv.Size = new System.Drawing.Size(470, 240);
            this.semantico_Dgv.TabIndex = 8;
            // 
            // semantico_Lbl
            // 
            this.semantico_Lbl.AutoSize = true;
            this.semantico_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semantico_Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(159)))), ((int)(((byte)(222)))));
            this.semantico_Lbl.Location = new System.Drawing.Point(865, 47);
            this.semantico_Lbl.Name = "semantico_Lbl";
            this.semantico_Lbl.Size = new System.Drawing.Size(108, 24);
            this.semantico_Lbl.TabIndex = 9;
            this.semantico_Lbl.Text = "Semántico";
            // 
            // txtCodigoFuente
            // 
            this.txtCodigoFuente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(130)))));
            this.txtCodigoFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFuente.ForeColor = System.Drawing.Color.White;
            this.txtCodigoFuente.Location = new System.Drawing.Point(29, 75);
            this.txtCodigoFuente.Multiline = true;
            this.txtCodigoFuente.Name = "txtCodigoFuente";
            this.txtCodigoFuente.Size = new System.Drawing.Size(300, 570);
            this.txtCodigoFuente.TabIndex = 10;
            // 
            // codigo_Lbl
            // 
            this.codigo_Lbl.AutoSize = true;
            this.codigo_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(159)))), ((int)(((byte)(222)))));
            this.codigo_Lbl.Location = new System.Drawing.Point(25, 48);
            this.codigo_Lbl.Name = "codigo_Lbl";
            this.codigo_Lbl.Size = new System.Drawing.Size(149, 24);
            this.codigo_Lbl.TabIndex = 11;
            this.codigo_Lbl.Text = "Código Fuente";
            // 
            // dart_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1382, 681);
            this.Controls.Add(this.codigo_Lbl);
            this.Controls.Add(this.txtCodigoFuente);
            this.Controls.Add(this.semantico_Lbl);
            this.Controls.Add(this.semantico_Dgv);
            this.Controls.Add(this.errores_Lbl);
            this.Controls.Add(this.errores_Dgv);
            this.Controls.Add(this.lexico_Lbl);
            this.Controls.Add(this.lexico_Dgv);
            this.Controls.Add(this.menu_mStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_mStrip;
            this.MaximizeBox = false;
            this.Name = "dart_Form";
            this.Text = "Compilador - Dart";
            this.menu_mStrip.ResumeLayout(false);
            this.menu_mStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lexico_Dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errores_Dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semantico_Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_mStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compiladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autómataFinitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaDeTokensToolStripMenuItem;
        private System.Windows.Forms.DataGridView lexico_Dgv;
        private System.Windows.Forms.Label lexico_Lbl;
        private System.Windows.Forms.DataGridView errores_Dgv;
        private System.Windows.Forms.Label errores_Lbl;
        private System.Windows.Forms.DataGridView semantico_Dgv;
        private System.Windows.Forms.Label semantico_Lbl;
        private System.Windows.Forms.TextBox txtCodigoFuente;
        private System.Windows.Forms.Label codigo_Lbl;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

