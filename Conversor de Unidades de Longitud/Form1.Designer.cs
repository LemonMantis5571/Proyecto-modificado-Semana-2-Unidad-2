namespace Conversor_de_Unidades_de_Longitud
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdingresar = new MaterialSkin.Controls.MaterialButton();
            this.cmdsalir = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(169, 101);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 0;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(169, 143);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '+';
            this.txtclave.Size = new System.Drawing.Size(100, 20);
            this.txtclave.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CLAVE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmdingresar
            // 
            this.cmdingresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdingresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cmdingresar.Depth = 0;
            this.cmdingresar.HighEmphasis = true;
            this.cmdingresar.Icon = null;
            this.cmdingresar.Location = new System.Drawing.Point(110, 207);
            this.cmdingresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmdingresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdingresar.Name = "cmdingresar";
            this.cmdingresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cmdingresar.Size = new System.Drawing.Size(91, 36);
            this.cmdingresar.TabIndex = 6;
            this.cmdingresar.Text = "INGRESAR";
            this.cmdingresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cmdingresar.UseAccentColor = false;
            this.cmdingresar.UseVisualStyleBackColor = true;
            this.cmdingresar.Click += new System.EventHandler(this.cmdingresar_Click_1);
            // 
            // cmdsalir
            // 
            this.cmdsalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdsalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cmdsalir.Depth = 0;
            this.cmdsalir.HighEmphasis = true;
            this.cmdsalir.Icon = null;
            this.cmdsalir.Location = new System.Drawing.Point(232, 207);
            this.cmdsalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmdsalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdsalir.Name = "cmdsalir";
            this.cmdsalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cmdsalir.Size = new System.Drawing.Size(64, 36);
            this.cmdsalir.TabIndex = 7;
            this.cmdsalir.Text = "SALIR";
            this.cmdsalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cmdsalir.UseAccentColor = false;
            this.cmdsalir.UseVisualStyleBackColor = true;
            this.cmdsalir.Click += new System.EventHandler(this.cmdsalir_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 256);
            this.Controls.Add(this.cmdsalir);
            this.Controls.Add(this.cmdingresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton cmdingresar;
        private MaterialSkin.Controls.MaterialButton cmdsalir;
    }
}

