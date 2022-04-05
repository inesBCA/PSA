namespace Interface_trab_PSA
{
    partial class escolhaetapa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(escolhaetapa));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Tipoetapa = new System.Windows.Forms.Label();
            this.numentrada = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.Label();
            this.Tempodetecao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.próximo = new System.Windows.Forms.Button();
            this.anterior = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // Tipoetapa
            // 
            resources.ApplyResources(this.Tipoetapa, "Tipoetapa");
            this.Tipoetapa.Name = "Tipoetapa";
            this.Tipoetapa.Click += new System.EventHandler(this.label1_Click);
            // 
            // numentrada
            // 
            resources.ApplyResources(this.numentrada, "numentrada");
            this.numentrada.Name = "numentrada";
            // 
            // Estado
            // 
            resources.ApplyResources(this.Estado, "Estado");
            this.Estado.Name = "Estado";
            this.Estado.Click += new System.EventHandler(this.Estado_Click);
            // 
            // Tempodetecao
            // 
            resources.ApplyResources(this.Tempodetecao, "Tempodetecao");
            this.Tempodetecao.Name = "Tempodetecao";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // próximo
            // 
            resources.ApplyResources(this.próximo, "próximo");
            this.próximo.Name = "próximo";
            this.próximo.UseVisualStyleBackColor = true;
            // 
            // anterior
            // 
            resources.ApplyResources(this.anterior, "anterior");
            this.anterior.Name = "anterior";
            this.anterior.UseVisualStyleBackColor = true;
            this.anterior.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // numericUpDown2
            // 
            resources.ApplyResources(this.numericUpDown2, "numericUpDown2");
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            // 
            // numericUpDown3
            // 
            resources.ApplyResources(this.numericUpDown3, "numericUpDown3");
            this.numericUpDown3.Name = "numericUpDown3";
            // 
            // escolhaetapa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.anterior);
            this.Controls.Add(this.próximo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tempodetecao);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.numentrada);
            this.Controls.Add(this.Tipoetapa);
            this.Controls.Add(this.comboBox1);
            this.Name = "escolhaetapa";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox comboBox1;
        private Label Tipoetapa;
        private Label numentrada;
        private Label Estado;
        private Label Tempodetecao;
        private Button button1;
        private Button próximo;
        private Button anterior;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
    }
}