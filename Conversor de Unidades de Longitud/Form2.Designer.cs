namespace Conversor_de_Unidades_de_Longitud
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.cmborigen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbdestino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.cmdconvertir = new MaterialSkin.Controls.MaterialButton();
            this.cmdSalir = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONVERTIR";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(130, 111);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(90, 20);
            this.txtvalor.TabIndex = 1;
            // 
            // cmborigen
            // 
            this.cmborigen.FormattingEnabled = true;
            this.cmborigen.Items.AddRange(new object[] {
            "Milímetros",
            "Centímetros",
            "Decímetros",
            "Metros",
            "Kilómetros"});
            this.cmborigen.Location = new System.Drawing.Point(237, 110);
            this.cmborigen.Name = "cmborigen";
            this.cmborigen.Size = new System.Drawing.Size(121, 21);
            this.cmborigen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A";
            // 
            // cmbdestino
            // 
            this.cmbdestino.FormattingEnabled = true;
            this.cmbdestino.Items.AddRange(new object[] {
            "Milímetros",
            "Centímetros",
            "Decímetros",
            "Metros",
            "Kilómetros"});
            this.cmbdestino.Location = new System.Drawing.Point(427, 110);
            this.cmbdestino.Name = "cmbdestino";
            this.cmbdestino.Size = new System.Drawing.Size(121, 21);
            this.cmbdestino.TabIndex = 4;
            this.cmbdestino.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "RESULTADO";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(129, 178);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(91, 13);
            this.lblresultado.TabIndex = 7;
            this.lblresultado.Text = "______________";
            this.lblresultado.Click += new System.EventHandler(this.lblresultado_Click);
            // 
            // cmdconvertir
            // 
            this.cmdconvertir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdconvertir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cmdconvertir.Depth = 0;
            this.cmdconvertir.HighEmphasis = true;
            this.cmdconvertir.Icon = null;
            this.cmdconvertir.Location = new System.Drawing.Point(427, 217);
            this.cmdconvertir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmdconvertir.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdconvertir.Name = "cmdconvertir";
            this.cmdconvertir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cmdconvertir.Size = new System.Drawing.Size(96, 36);
            this.cmdconvertir.TabIndex = 9;
            this.cmdconvertir.Text = "PROCESAR";
            this.cmdconvertir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cmdconvertir.UseAccentColor = false;
            this.cmdconvertir.UseVisualStyleBackColor = true;
            this.cmdconvertir.Click += new System.EventHandler(this.cmdconvertir_Click_1);
            // 
            // cmdSalir
            // 
            this.cmdSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cmdSalir.Depth = 0;
            this.cmdSalir.HighEmphasis = true;
            this.cmdSalir.Icon = null;
            this.cmdSalir.Location = new System.Drawing.Point(544, 217);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmdSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cmdSalir.Size = new System.Drawing.Size(64, 36);
            this.cmdSalir.TabIndex = 10;
            this.cmdSalir.Text = "SALIR";
            this.cmdSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cmdSalir.UseAccentColor = false;
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 262);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdconvertir);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbdestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmborigen);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.ComboBox cmborigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbdestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblresultado;
        private MaterialSkin.Controls.MaterialButton cmdconvertir;
        private MaterialSkin.Controls.MaterialButton cmdSalir;
    }
}