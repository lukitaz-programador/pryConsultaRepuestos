namespace pryConsultaRepuestos
{
    partial class frmPrincipal
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
            grbDatos = new GroupBox();
            lblPrecioo = new Label();
            lblDescripciónn = new Label();
            lblNúmero = new Label();
            lblOrigen = new Label();
            lblMarcaa = new Label();
            mtbPrecio = new MaskedTextBox();
            txtDescripción = new TextBox();
            mtbNumero = new MaskedTextBox();
            lstOrigen = new ComboBox();
            lstMarca = new ComboBox();
            btnRegistrar = new Button();
            grbDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grbDatos
            // 
            grbDatos.Controls.Add(lblPrecioo);
            grbDatos.Controls.Add(lblDescripciónn);
            grbDatos.Controls.Add(lblNúmero);
            grbDatos.Controls.Add(lblOrigen);
            grbDatos.Controls.Add(lblMarcaa);
            grbDatos.Controls.Add(mtbPrecio);
            grbDatos.Controls.Add(txtDescripción);
            grbDatos.Controls.Add(mtbNumero);
            grbDatos.Controls.Add(lstOrigen);
            grbDatos.Controls.Add(lstMarca);
            grbDatos.Font = new Font("Segoe UI", 10F);
            grbDatos.Location = new Point(12, 13);
            grbDatos.Name = "grbDatos";
            grbDatos.RightToLeft = RightToLeft.No;
            grbDatos.Size = new Size(279, 383);
            grbDatos.TabIndex = 0;
            grbDatos.TabStop = false;
            grbDatos.Text = "Datos del repuesto";
            // 
            // lblPrecioo
            // 
            lblPrecioo.AutoSize = true;
            lblPrecioo.Location = new Point(18, 318);
            lblPrecioo.Name = "lblPrecioo";
            lblPrecioo.Size = new Size(49, 19);
            lblPrecioo.TabIndex = 9;
            lblPrecioo.Text = "Precio:";
            // 
            // lblDescripciónn
            // 
            lblDescripciónn.AutoSize = true;
            lblDescripciónn.Location = new Point(18, 215);
            lblDescripciónn.Name = "lblDescripciónn";
            lblDescripciónn.Size = new Size(82, 19);
            lblDescripciónn.TabIndex = 8;
            lblDescripciónn.Text = "Descripción:";
            // 
            // lblNúmero
            // 
            lblNúmero.AutoSize = true;
            lblNúmero.Location = new Point(18, 155);
            lblNúmero.Name = "lblNúmero";
            lblNúmero.Size = new Size(62, 19);
            lblNúmero.TabIndex = 7;
            lblNúmero.Text = "Número:";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(18, 92);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(54, 19);
            lblOrigen.TabIndex = 6;
            lblOrigen.Text = "Origen:";
            // 
            // lblMarcaa
            // 
            lblMarcaa.AutoSize = true;
            lblMarcaa.Location = new Point(18, 32);
            lblMarcaa.Name = "lblMarcaa";
            lblMarcaa.Size = new Size(50, 19);
            lblMarcaa.TabIndex = 5;
            lblMarcaa.Text = "Marca:";
            // 
            // mtbPrecio
            // 
            mtbPrecio.Location = new Point(18, 340);
            mtbPrecio.Mask = "$9999999999.99";
            mtbPrecio.Name = "mtbPrecio";
            mtbPrecio.Size = new Size(239, 25);
            mtbPrecio.TabIndex = 4;
            // 
            // txtDescripción
            // 
            txtDescripción.Location = new Point(18, 237);
            txtDescripción.MaxLength = 50;
            txtDescripción.Multiline = true;
            txtDescripción.Name = "txtDescripción";
            txtDescripción.Size = new Size(239, 70);
            txtDescripción.TabIndex = 3;
            // 
            // mtbNumero
            // 
            mtbNumero.Location = new Point(18, 177);
            mtbNumero.Mask = "999999";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(239, 25);
            mtbNumero.TabIndex = 2;
            mtbNumero.ValidatingType = typeof(int);
            // 
            // lstOrigen
            // 
            lstOrigen.FormattingEnabled = true;
            lstOrigen.Items.AddRange(new object[] { "(N) Nacional", "(I) Importado" });
            lstOrigen.Location = new Point(18, 114);
            lstOrigen.Name = "lstOrigen";
            lstOrigen.Size = new Size(239, 25);
            lstOrigen.TabIndex = 1;
            // 
            // lstMarca
            // 
            lstMarca.FormattingEnabled = true;
            lstMarca.Items.AddRange(new object[] { "(P) Peugeot", "(F) Fiat", "(R) Renault" });
            lstMarca.Location = new Point(18, 54);
            lstMarca.Name = "lstMarca";
            lstMarca.Size = new Size(239, 25);
            lstMarca.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.Highlight;
            btnRegistrar.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrar.Location = new Point(12, 402);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(280, 41);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar Repuesto";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 453);
            Controls.Add(btnRegistrar);
            Controls.Add(grbDatos);
            Font = new Font("Segoe UI", 10F);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar Repuestos";
            grbDatos.ResumeLayout(false);
            grbDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDatos;
        private MaskedTextBox mtbPrecio;
        private TextBox txtDescripción;
        private MaskedTextBox mtbNumero;
        private ComboBox lstOrigen;
        private ComboBox lstMarca;
        private Button btnRegistrar;
        private Label lblPrecioo;
        private Label lblDescripciónn;
        private Label lblNúmero;
        private Label lblOrigen;
        private Label lblMarcaa;
    }
}
