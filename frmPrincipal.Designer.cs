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
            lblNúmeroo = new Label();
            lblOrigenn = new Label();
            lblMarcaa = new Label();
            mtbPrecio = new MaskedTextBox();
            txtDescripción = new TextBox();
            mtbNumero = new MaskedTextBox();
            lstOrigen = new ComboBox();
            lstMarca = new ComboBox();
            btnRegistrar = new Button();
            tbcPaginas = new TabControl();
            tbpRegistrar = new TabPage();
            tbpConsultar = new TabPage();
            btnConsultar = new Button();
            grbDatoss = new GroupBox();
            lblRespuestoo = new Label();
            lblOrigennn = new Label();
            lblMarcaaa = new Label();
            lstRepuestos = new ListBox();
            lstOrigenn = new ComboBox();
            lstMarcaa = new ComboBox();
            grbDatos.SuspendLayout();
            tbcPaginas.SuspendLayout();
            tbpRegistrar.SuspendLayout();
            tbpConsultar.SuspendLayout();
            grbDatoss.SuspendLayout();
            SuspendLayout();
            // 
            // grbDatos
            // 
            grbDatos.Controls.Add(lblPrecioo);
            grbDatos.Controls.Add(lblDescripciónn);
            grbDatos.Controls.Add(lblNúmeroo);
            grbDatos.Controls.Add(lblOrigenn);
            grbDatos.Controls.Add(lblMarcaa);
            grbDatos.Controls.Add(mtbPrecio);
            grbDatos.Controls.Add(txtDescripción);
            grbDatos.Controls.Add(mtbNumero);
            grbDatos.Controls.Add(lstOrigen);
            grbDatos.Controls.Add(lstMarca);
            grbDatos.Font = new Font("Segoe UI", 10F);
            grbDatos.Location = new Point(22, 15);
            grbDatos.Name = "grbDatos";
            grbDatos.RightToLeft = RightToLeft.No;
            grbDatos.Size = new Size(273, 383);
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
            // lblNúmeroo
            // 
            lblNúmeroo.AutoSize = true;
            lblNúmeroo.Location = new Point(18, 155);
            lblNúmeroo.Name = "lblNúmeroo";
            lblNúmeroo.Size = new Size(62, 19);
            lblNúmeroo.TabIndex = 7;
            lblNúmeroo.Text = "Número:";
            // 
            // lblOrigenn
            // 
            lblOrigenn.AutoSize = true;
            lblOrigenn.Location = new Point(18, 92);
            lblOrigenn.Name = "lblOrigenn";
            lblOrigenn.Size = new Size(54, 19);
            lblOrigenn.TabIndex = 6;
            lblOrigenn.Text = "Origen:";
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
            mtbPrecio.Enabled = false;
            mtbPrecio.Location = new Point(18, 340);
            mtbPrecio.Mask = "$9999999999.99";
            mtbPrecio.Name = "mtbPrecio";
            mtbPrecio.Size = new Size(239, 25);
            mtbPrecio.TabIndex = 4;
            mtbPrecio.MaskInputRejected += mtbPrecio_MaskInputRejected;
            mtbPrecio.TextChanged += mtbPrecio_TextChanged;
            // 
            // txtDescripción
            // 
            txtDescripción.Enabled = false;
            txtDescripción.Location = new Point(18, 237);
            txtDescripción.MaxLength = 50;
            txtDescripción.Multiline = true;
            txtDescripción.Name = "txtDescripción";
            txtDescripción.Size = new Size(239, 70);
            txtDescripción.TabIndex = 3;
            txtDescripción.TextChanged += txtDescripción_TextChanged;
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Location = new Point(18, 177);
            mtbNumero.Mask = "999999";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(239, 25);
            mtbNumero.TabIndex = 2;
            mtbNumero.ValidatingType = typeof(int);
            mtbNumero.TextChanged += mtbNumero_TextChanged;
            // 
            // lstOrigen
            // 
            lstOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            lstOrigen.Enabled = false;
            lstOrigen.FormattingEnabled = true;
            lstOrigen.Location = new Point(18, 114);
            lstOrigen.Name = "lstOrigen";
            lstOrigen.Size = new Size(239, 25);
            lstOrigen.TabIndex = 1;
            lstOrigen.SelectedIndexChanged += lstOrigen_SelectedIndexChanged;
            // 
            // lstMarca
            // 
            lstMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            lstMarca.FormattingEnabled = true;
            lstMarca.Location = new Point(18, 54);
            lstMarca.Name = "lstMarca";
            lstMarca.Size = new Size(239, 25);
            lstMarca.TabIndex = 0;
            lstMarca.SelectedIndexChanged += lstMarca_SelectedIndexChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.Highlight;
            btnRegistrar.Enabled = false;
            btnRegistrar.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrar.Location = new Point(22, 404);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(274, 41);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar Ingreso";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbcPaginas
            // 
            tbcPaginas.Controls.Add(tbpRegistrar);
            tbcPaginas.Controls.Add(tbpConsultar);
            tbcPaginas.Location = new Point(12, 12);
            tbcPaginas.Name = "tbcPaginas";
            tbcPaginas.SelectedIndex = 0;
            tbcPaginas.Size = new Size(327, 488);
            tbcPaginas.TabIndex = 2;
            // 
            // tbpRegistrar
            // 
            tbpRegistrar.Controls.Add(grbDatos);
            tbpRegistrar.Controls.Add(btnRegistrar);
            tbpRegistrar.Location = new Point(4, 26);
            tbpRegistrar.Name = "tbpRegistrar";
            tbpRegistrar.Padding = new Padding(3);
            tbpRegistrar.Size = new Size(319, 458);
            tbpRegistrar.TabIndex = 0;
            tbpRegistrar.Text = "Registrar";
            tbpRegistrar.UseVisualStyleBackColor = true;
            // 
            // tbpConsultar
            // 
            tbpConsultar.Controls.Add(btnConsultar);
            tbpConsultar.Controls.Add(grbDatoss);
            tbpConsultar.Location = new Point(4, 26);
            tbpConsultar.Name = "tbpConsultar";
            tbpConsultar.Padding = new Padding(3);
            tbpConsultar.Size = new Size(319, 458);
            tbpConsultar.TabIndex = 1;
            tbpConsultar.Text = "Consultar";
            tbpConsultar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = SystemColors.Highlight;
            btnConsultar.ForeColor = SystemColors.ControlLightLight;
            btnConsultar.Location = new Point(17, 404);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(280, 42);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar Ingreso";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // grbDatoss
            // 
            grbDatoss.Controls.Add(lblRespuestoo);
            grbDatoss.Controls.Add(lblOrigennn);
            grbDatoss.Controls.Add(lblMarcaaa);
            grbDatoss.Controls.Add(lstRepuestos);
            grbDatoss.Controls.Add(lstOrigenn);
            grbDatoss.Controls.Add(lstMarcaa);
            grbDatoss.Location = new Point(17, 15);
            grbDatoss.Name = "grbDatoss";
            grbDatoss.Size = new Size(280, 383);
            grbDatoss.TabIndex = 0;
            grbDatoss.TabStop = false;
            grbDatoss.Text = "Datos del Repuesto:";
            // 
            // lblRespuestoo
            // 
            lblRespuestoo.AutoSize = true;
            lblRespuestoo.Location = new Point(21, 151);
            lblRespuestoo.Name = "lblRespuestoo";
            lblRespuestoo.Size = new Size(138, 19);
            lblRespuestoo.TabIndex = 5;
            lblRespuestoo.Text = "Repuesto Registrado:";
            // 
            // lblOrigennn
            // 
            lblOrigennn.AutoSize = true;
            lblOrigennn.Location = new Point(20, 93);
            lblOrigennn.Name = "lblOrigennn";
            lblOrigennn.Size = new Size(51, 19);
            lblOrigennn.TabIndex = 4;
            lblOrigennn.Text = "Origen";
            // 
            // lblMarcaaa
            // 
            lblMarcaaa.AutoSize = true;
            lblMarcaaa.Location = new Point(20, 35);
            lblMarcaaa.Name = "lblMarcaaa";
            lblMarcaaa.Size = new Size(50, 19);
            lblMarcaaa.TabIndex = 3;
            lblMarcaaa.Text = "Marca:";
            // 
            // lstRepuestos
            // 
            lstRepuestos.FormattingEnabled = true;
            lstRepuestos.ItemHeight = 17;
            lstRepuestos.Location = new Point(21, 176);
            lstRepuestos.Name = "lstRepuestos";
            lstRepuestos.Size = new Size(240, 191);
            lstRepuestos.TabIndex = 2;
            // 
            // lstOrigenn
            // 
            lstOrigenn.DropDownStyle = ComboBoxStyle.DropDownList;
            lstOrigenn.FormattingEnabled = true;
            lstOrigenn.Location = new Point(21, 115);
            lstOrigenn.Name = "lstOrigenn";
            lstOrigenn.Size = new Size(240, 25);
            lstOrigenn.TabIndex = 1;
            lstOrigenn.SelectedIndexChanged += lstOrigenn_SelectedIndexChanged;
            // 
            // lstMarcaa
            // 
            lstMarcaa.DropDownStyle = ComboBoxStyle.DropDownList;
            lstMarcaa.FormattingEnabled = true;
            lstMarcaa.Location = new Point(21, 55);
            lstMarcaa.Name = "lstMarcaa";
            lstMarcaa.Size = new Size(240, 25);
            lstMarcaa.TabIndex = 0;
            lstMarcaa.SelectedIndexChanged += lstMarcaa_SelectedIndexChanged;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 510);
            Controls.Add(tbcPaginas);
            Font = new Font("Segoe UI", 10F);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar Repuestos";
            Load += frmPrincipal_Load;
            grbDatos.ResumeLayout(false);
            grbDatos.PerformLayout();
            tbcPaginas.ResumeLayout(false);
            tbpRegistrar.ResumeLayout(false);
            tbpConsultar.ResumeLayout(false);
            grbDatoss.ResumeLayout(false);
            grbDatoss.PerformLayout();
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
        private Label lblNúmeroo;
        private Label lblOrigenn;
        private Label lblMarcaa;
        private TabControl tbcPaginas;
        private TabPage tbpRegistrar;
        private TabPage tbpConsultar;
        private Button btnConsultar;
        private GroupBox grbDatoss;
        private Label lblRespuestoo;
        private Label lblOrigennn;
        private Label lblMarcaaa;
        private ListBox lstRepuestos;
        private ComboBox lstOrigenn;
        private ComboBox lstMarcaa;
    }
}
