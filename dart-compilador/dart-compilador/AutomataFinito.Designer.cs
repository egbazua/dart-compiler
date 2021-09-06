namespace dart_compilador
{
    partial class AutomataFinito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomataFinito));
            this.automatafinito_Pbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.automatafinito_Pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // automatafinito_Pbx
            // 
            this.automatafinito_Pbx.Image = ((System.Drawing.Image)(resources.GetObject("automatafinito_Pbx.Image")));
            this.automatafinito_Pbx.InitialImage = ((System.Drawing.Image)(resources.GetObject("automatafinito_Pbx.InitialImage")));
            this.automatafinito_Pbx.Location = new System.Drawing.Point(77, 24);
            this.automatafinito_Pbx.Name = "automatafinito_Pbx";
            this.automatafinito_Pbx.Size = new System.Drawing.Size(710, 672);
            this.automatafinito_Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.automatafinito_Pbx.TabIndex = 0;
            this.automatafinito_Pbx.TabStop = false;
            // 
            // AutomataFinito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(872, 725);
            this.Controls.Add(this.automatafinito_Pbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutomataFinito";
            this.Text = "Autómata Finito";
            ((System.ComponentModel.ISupportInitialize)(this.automatafinito_Pbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox automatafinito_Pbx;
    }
}