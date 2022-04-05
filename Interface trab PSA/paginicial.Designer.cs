namespace Interface_trab_PSA
{
    partial class páginicial
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
            this.modomanual = new System.Windows.Forms.Button();
            this.modoauto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modomanual
            // 
            this.modomanual.Location = new System.Drawing.Point(274, 219);
            this.modomanual.Name = "modomanual";
            this.modomanual.Size = new System.Drawing.Size(194, 29);
            this.modomanual.TabIndex = 0;
            this.modomanual.Text = "Modo Manual";
            this.modomanual.UseVisualStyleBackColor = true;
            // 
            // modoauto
            // 
            this.modoauto.Location = new System.Drawing.Point(607, 219);
            this.modoauto.Name = "modoauto";
            this.modoauto.Size = new System.Drawing.Size(246, 29);
            this.modoauto.TabIndex = 1;
            this.modoauto.Text = "Modo automático";
            this.modoauto.UseVisualStyleBackColor = true;
            // 
            // páginicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 715);
            this.Controls.Add(this.modoauto);
            this.Controls.Add(this.modomanual);
            this.Name = "páginicial";
            this.Text = "Página Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private Button modomanual;
        private Button modoauto;
    }
}