namespace ABT2023.forms
{
    partial class FormBV
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            cboArea = new MaterialSkin.Controls.MaterialComboBox();
            cboDependencia = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            txtMarca = new MaterialSkin.Controls.MaterialTextBox();
            txtTipo = new MaterialSkin.Controls.MaterialTextBox();
            txtModelo = new MaterialSkin.Controls.MaterialTextBox();
            txtPlaca = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            txtHora = new MaterialSkin.Controls.MaterialMaskedTextBox();
            dtpFecha = new DateTimePicker();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            tctKmInicial = new MaterialSkin.Controls.MaterialTextBox();
            txtKmFinal = new MaterialSkin.Controls.MaterialTextBox();
            txtDestino = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            txtNombreConductor = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            txtNombreConductor2 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            txtDestino2 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            txtKmFinal2 = new MaterialSkin.Controls.MaterialTextBox();
            tctKmInicial2 = new MaterialSkin.Controls.MaterialTextBox();
            dtpFecha2 = new DateTimePicker();
            materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            txtHora2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            groupBox1 = new GroupBox();
            materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            txtKmRecorrido = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            txtKmRecorrido2 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            btnCrearPDF = new MaterialSkin.Controls.MaterialButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(129, 36);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(37, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Area:";
            // 
            // cboArea
            // 
            cboArea.AutoResize = false;
            cboArea.BackColor = Color.FromArgb(255, 255, 255);
            cboArea.Depth = 0;
            cboArea.DrawMode = DrawMode.OwnerDrawVariable;
            cboArea.DropDownHeight = 174;
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea.DropDownWidth = 121;
            cboArea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboArea.FormattingEnabled = true;
            cboArea.IntegralHeight = false;
            cboArea.ItemHeight = 43;
            cboArea.Items.AddRange(new object[] { "Ventas", "Servicios Varios", "Laboratorio", "Administrativo", "Gerencia" });
            cboArea.Location = new Point(193, 17);
            cboArea.MaxDropDownItems = 4;
            cboArea.MouseState = MaterialSkin.MouseState.OUT;
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(246, 49);
            cboArea.StartIndex = 0;
            cboArea.TabIndex = 1;
            // 
            // cboDependencia
            // 
            cboDependencia.AutoResize = false;
            cboDependencia.BackColor = Color.FromArgb(255, 255, 255);
            cboDependencia.Depth = 0;
            cboDependencia.DrawMode = DrawMode.OwnerDrawVariable;
            cboDependencia.DropDownHeight = 174;
            cboDependencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDependencia.DropDownWidth = 121;
            cboDependencia.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboDependencia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboDependencia.FormattingEnabled = true;
            cboDependencia.IntegralHeight = false;
            cboDependencia.ItemHeight = 43;
            cboDependencia.Items.AddRange(new object[] { "Gerencia de Negocios", "gerencia Adminstrativa", "Gerencia de Laboratorio", "Gerencia de Servicio", "Gerencia General" });
            cboDependencia.Location = new Point(666, 16);
            cboDependencia.MaxDropDownItems = 4;
            cboDependencia.MouseState = MaterialSkin.MouseState.OUT;
            cboDependencia.Name = "cboDependencia";
            cboDependencia.Size = new Size(246, 49);
            cboDependencia.StartIndex = 0;
            cboDependencia.TabIndex = 3;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(531, 35);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(97, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Dependencia:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(129, 135);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(50, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Marca:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(142, 219);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(37, 19);
            materialLabel4.TabIndex = 5;
            materialLabel4.Text = "Tipo:";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(531, 135);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(58, 19);
            materialLabel5.TabIndex = 6;
            materialLabel5.Text = "Modelo:";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(544, 219);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(45, 19);
            materialLabel6.TabIndex = 7;
            materialLabel6.Text = "Placa:";
            // 
            // txtMarca
            // 
            txtMarca.AnimateReadOnly = false;
            txtMarca.BorderStyle = BorderStyle.None;
            txtMarca.Depth = 0;
            txtMarca.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMarca.LeadingIcon = null;
            txtMarca.Location = new Point(215, 119);
            txtMarca.MaxLength = 50;
            txtMarca.MouseState = MaterialSkin.MouseState.OUT;
            txtMarca.Multiline = false;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(179, 50);
            txtMarca.TabIndex = 8;
            txtMarca.Text = "";
            txtMarca.TrailingIcon = null;
            // 
            // txtTipo
            // 
            txtTipo.AnimateReadOnly = false;
            txtTipo.BorderStyle = BorderStyle.None;
            txtTipo.Depth = 0;
            txtTipo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTipo.LeadingIcon = null;
            txtTipo.Location = new Point(215, 199);
            txtTipo.MaxLength = 50;
            txtTipo.MouseState = MaterialSkin.MouseState.OUT;
            txtTipo.Multiline = false;
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(179, 50);
            txtTipo.TabIndex = 9;
            txtTipo.Text = "";
            txtTipo.TrailingIcon = null;
            // 
            // txtModelo
            // 
            txtModelo.AnimateReadOnly = false;
            txtModelo.BorderStyle = BorderStyle.None;
            txtModelo.Depth = 0;
            txtModelo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtModelo.LeadingIcon = null;
            txtModelo.Location = new Point(647, 118);
            txtModelo.MaxLength = 50;
            txtModelo.MouseState = MaterialSkin.MouseState.OUT;
            txtModelo.Multiline = false;
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(179, 50);
            txtModelo.TabIndex = 10;
            txtModelo.Text = "";
            txtModelo.TrailingIcon = null;
            // 
            // txtPlaca
            // 
            txtPlaca.AnimateReadOnly = false;
            txtPlaca.BorderStyle = BorderStyle.None;
            txtPlaca.Depth = 0;
            txtPlaca.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPlaca.LeadingIcon = null;
            txtPlaca.Location = new Point(647, 199);
            txtPlaca.MaxLength = 50;
            txtPlaca.MouseState = MaterialSkin.MouseState.OUT;
            txtPlaca.Multiline = false;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(179, 50);
            txtPlaca.TabIndex = 11;
            txtPlaca.Text = "";
            txtPlaca.TrailingIcon = null;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(47, 321);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(39, 19);
            materialLabel10.TabIndex = 21;
            materialLabel10.Text = "Hora:";
            // 
            // txtHora
            // 
            txtHora.AllowPromptAsInput = true;
            txtHora.AnimateReadOnly = false;
            txtHora.AsciiOnly = false;
            txtHora.BackgroundImageLayout = ImageLayout.None;
            txtHora.BeepOnError = false;
            txtHora.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtHora.Depth = 0;
            txtHora.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHora.HidePromptOnLeave = false;
            txtHora.HideSelection = true;
            txtHora.InsertKeyMode = InsertKeyMode.Default;
            txtHora.LeadingIcon = null;
            txtHora.Location = new Point(23, 360);
            txtHora.Mask = "00:00";
            txtHora.MaxLength = 32767;
            txtHora.MouseState = MaterialSkin.MouseState.OUT;
            txtHora.Name = "txtHora";
            txtHora.PasswordChar = '\0';
            txtHora.PrefixSuffixText = null;
            txtHora.PromptChar = '_';
            txtHora.ReadOnly = false;
            txtHora.RejectInputOnFirstFailure = false;
            txtHora.ResetOnPrompt = true;
            txtHora.ResetOnSpace = true;
            txtHora.RightToLeft = RightToLeft.No;
            txtHora.SelectedText = "";
            txtHora.SelectionLength = 0;
            txtHora.SelectionStart = 5;
            txtHora.ShortcutsEnabled = true;
            txtHora.Size = new Size(88, 48);
            txtHora.SkipLiterals = true;
            txtHora.TabIndex = 20;
            txtHora.TabStop = false;
            txtHora.Text = "00:00";
            txtHora.TextAlign = HorizontalAlignment.Left;
            txtHora.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtHora.TrailingIcon = null;
            txtHora.UseSystemPasswordChar = false;
            txtHora.ValidatingType = null;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(134, 372);
            dtpFecha.MaxDate = new DateTime(2080, 12, 31, 0, 0, 0, 0);
            dtpFecha.MinDate = new DateTime(2023, 8, 17, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(105, 23);
            dtpFecha.TabIndex = 23;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(165, 322);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(48, 19);
            materialLabel7.TabIndex = 22;
            materialLabel7.Text = "Fecha:";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(265, 323);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(82, 19);
            materialLabel8.TabIndex = 24;
            materialLabel8.Text = "Km Inicial\r\n";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(359, 36);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(64, 19);
            materialLabel9.TabIndex = 25;
            materialLabel9.Text = "Km Final";
            // 
            // tctKmInicial
            // 
            tctKmInicial.AnimateReadOnly = false;
            tctKmInicial.BorderStyle = BorderStyle.None;
            tctKmInicial.Depth = 0;
            tctKmInicial.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tctKmInicial.LeadingIcon = null;
            tctKmInicial.Location = new Point(265, 360);
            tctKmInicial.MaxLength = 50;
            tctKmInicial.MouseState = MaterialSkin.MouseState.OUT;
            tctKmInicial.Multiline = false;
            tctKmInicial.Name = "tctKmInicial";
            tctKmInicial.Size = new Size(82, 50);
            tctKmInicial.TabIndex = 26;
            tctKmInicial.Text = "";
            tctKmInicial.TrailingIcon = null;
            // 
            // txtKmFinal
            // 
            txtKmFinal.AnimateReadOnly = false;
            txtKmFinal.BorderStyle = BorderStyle.None;
            txtKmFinal.Depth = 0;
            txtKmFinal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtKmFinal.LeadingIcon = null;
            txtKmFinal.Location = new Point(346, 74);
            txtKmFinal.MaxLength = 50;
            txtKmFinal.MouseState = MaterialSkin.MouseState.OUT;
            txtKmFinal.Multiline = false;
            txtKmFinal.Name = "txtKmFinal";
            txtKmFinal.Size = new Size(117, 50);
            txtKmFinal.TabIndex = 27;
            txtKmFinal.Text = "";
            txtKmFinal.TrailingIcon = null;
            // 
            // txtDestino
            // 
            txtDestino.AnimateReadOnly = false;
            txtDestino.BorderStyle = BorderStyle.None;
            txtDestino.Depth = 0;
            txtDestino.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDestino.LeadingIcon = null;
            txtDestino.Location = new Point(632, 73);
            txtDestino.MaxLength = 50;
            txtDestino.MouseState = MaterialSkin.MouseState.OUT;
            txtDestino.Multiline = false;
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(178, 50);
            txtDestino.TabIndex = 29;
            txtDestino.Text = "";
            txtDestino.TrailingIcon = null;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(694, 35);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(55, 19);
            materialLabel11.TabIndex = 28;
            materialLabel11.Text = "Destino";
            // 
            // txtNombreConductor
            // 
            txtNombreConductor.AnimateReadOnly = false;
            txtNombreConductor.BorderStyle = BorderStyle.None;
            txtNombreConductor.Depth = 0;
            txtNombreConductor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreConductor.LeadingIcon = null;
            txtNombreConductor.Location = new Point(859, 358);
            txtNombreConductor.MaxLength = 50;
            txtNombreConductor.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreConductor.Multiline = false;
            txtNombreConductor.Name = "txtNombreConductor";
            txtNombreConductor.Size = new Size(230, 50);
            txtNombreConductor.TabIndex = 31;
            txtNombreConductor.Text = "";
            txtNombreConductor.TrailingIcon = null;
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(878, 323);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(134, 19);
            materialLabel12.TabIndex = 30;
            materialLabel12.Text = "Nombre Conductor";
            // 
            // txtNombreConductor2
            // 
            txtNombreConductor2.AnimateReadOnly = false;
            txtNombreConductor2.BorderStyle = BorderStyle.None;
            txtNombreConductor2.Depth = 0;
            txtNombreConductor2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreConductor2.LeadingIcon = null;
            txtNombreConductor2.Location = new Point(859, 468);
            txtNombreConductor2.MaxLength = 50;
            txtNombreConductor2.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreConductor2.Multiline = false;
            txtNombreConductor2.Name = "txtNombreConductor2";
            txtNombreConductor2.Size = new Size(230, 50);
            txtNombreConductor2.TabIndex = 43;
            txtNombreConductor2.Text = "";
            txtNombreConductor2.TrailingIcon = null;
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(878, 433);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(134, 19);
            materialLabel13.TabIndex = 42;
            materialLabel13.Text = "Nombre Conductor";
            // 
            // txtDestino2
            // 
            txtDestino2.AnimateReadOnly = false;
            txtDestino2.BorderStyle = BorderStyle.None;
            txtDestino2.Depth = 0;
            txtDestino2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDestino2.LeadingIcon = null;
            txtDestino2.Location = new Point(632, 182);
            txtDestino2.MaxLength = 50;
            txtDestino2.MouseState = MaterialSkin.MouseState.OUT;
            txtDestino2.Multiline = false;
            txtDestino2.Name = "txtDestino2";
            txtDestino2.Size = new Size(178, 50);
            txtDestino2.TabIndex = 41;
            txtDestino2.Text = "";
            txtDestino2.TrailingIcon = null;
            // 
            // materialLabel14
            // 
            materialLabel14.AutoSize = true;
            materialLabel14.Depth = 0;
            materialLabel14.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel14.Location = new Point(694, 147);
            materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.Size = new Size(55, 19);
            materialLabel14.TabIndex = 40;
            materialLabel14.Text = "Destino";
            // 
            // txtKmFinal2
            // 
            txtKmFinal2.AnimateReadOnly = false;
            txtKmFinal2.BorderStyle = BorderStyle.None;
            txtKmFinal2.Depth = 0;
            txtKmFinal2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtKmFinal2.LeadingIcon = null;
            txtKmFinal2.Location = new Point(346, 184);
            txtKmFinal2.MaxLength = 50;
            txtKmFinal2.MouseState = MaterialSkin.MouseState.OUT;
            txtKmFinal2.Multiline = false;
            txtKmFinal2.Name = "txtKmFinal2";
            txtKmFinal2.Size = new Size(117, 50);
            txtKmFinal2.TabIndex = 39;
            txtKmFinal2.Text = "";
            txtKmFinal2.TrailingIcon = null;
            // 
            // tctKmInicial2
            // 
            tctKmInicial2.AnimateReadOnly = false;
            tctKmInicial2.BorderStyle = BorderStyle.None;
            tctKmInicial2.Depth = 0;
            tctKmInicial2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tctKmInicial2.LeadingIcon = null;
            tctKmInicial2.Location = new Point(265, 470);
            tctKmInicial2.MaxLength = 50;
            tctKmInicial2.MouseState = MaterialSkin.MouseState.OUT;
            tctKmInicial2.Multiline = false;
            tctKmInicial2.Name = "tctKmInicial2";
            tctKmInicial2.Size = new Size(82, 50);
            tctKmInicial2.TabIndex = 38;
            tctKmInicial2.Text = "";
            tctKmInicial2.TrailingIcon = null;
            // 
            // dtpFecha2
            // 
            dtpFecha2.Format = DateTimePickerFormat.Short;
            dtpFecha2.Location = new Point(134, 482);
            dtpFecha2.MaxDate = new DateTime(2080, 12, 31, 0, 0, 0, 0);
            dtpFecha2.MinDate = new DateTime(2023, 8, 17, 0, 0, 0, 0);
            dtpFecha2.Name = "dtpFecha2";
            dtpFecha2.Size = new Size(105, 23);
            dtpFecha2.TabIndex = 35;
            // 
            // materialLabel17
            // 
            materialLabel17.AutoSize = true;
            materialLabel17.Depth = 0;
            materialLabel17.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel17.Location = new Point(165, 432);
            materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel17.Name = "materialLabel17";
            materialLabel17.Size = new Size(48, 19);
            materialLabel17.TabIndex = 34;
            materialLabel17.Text = "Fecha:";
            // 
            // materialLabel18
            // 
            materialLabel18.AutoSize = true;
            materialLabel18.Depth = 0;
            materialLabel18.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel18.Location = new Point(47, 431);
            materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel18.Name = "materialLabel18";
            materialLabel18.Size = new Size(39, 19);
            materialLabel18.TabIndex = 33;
            materialLabel18.Text = "Hora:";
            // 
            // txtHora2
            // 
            txtHora2.AllowPromptAsInput = true;
            txtHora2.AnimateReadOnly = false;
            txtHora2.AsciiOnly = false;
            txtHora2.BackgroundImageLayout = ImageLayout.None;
            txtHora2.BeepOnError = false;
            txtHora2.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtHora2.Depth = 0;
            txtHora2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHora2.HidePromptOnLeave = false;
            txtHora2.HideSelection = true;
            txtHora2.InsertKeyMode = InsertKeyMode.Default;
            txtHora2.LeadingIcon = null;
            txtHora2.Location = new Point(23, 470);
            txtHora2.Mask = "00:00";
            txtHora2.MaxLength = 32767;
            txtHora2.MouseState = MaterialSkin.MouseState.OUT;
            txtHora2.Name = "txtHora2";
            txtHora2.PasswordChar = '\0';
            txtHora2.PrefixSuffixText = null;
            txtHora2.PromptChar = '_';
            txtHora2.ReadOnly = false;
            txtHora2.RejectInputOnFirstFailure = false;
            txtHora2.ResetOnPrompt = true;
            txtHora2.ResetOnSpace = true;
            txtHora2.RightToLeft = RightToLeft.No;
            txtHora2.SelectedText = "";
            txtHora2.SelectionLength = 0;
            txtHora2.SelectionStart = 5;
            txtHora2.ShortcutsEnabled = true;
            txtHora2.Size = new Size(88, 48);
            txtHora2.SkipLiterals = true;
            txtHora2.TabIndex = 32;
            txtHora2.TabStop = false;
            txtHora2.Text = "00:00";
            txtHora2.TextAlign = HorizontalAlignment.Left;
            txtHora2.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtHora2.TrailingIcon = null;
            txtHora2.UseSystemPasswordChar = false;
            txtHora2.ValidatingType = null;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(materialLabel15);
            groupBox1.Controls.Add(txtKmRecorrido);
            groupBox1.Controls.Add(materialLabel14);
            groupBox1.Controls.Add(txtDestino2);
            groupBox1.Controls.Add(materialLabel20);
            groupBox1.Controls.Add(txtKmRecorrido2);
            groupBox1.Controls.Add(materialLabel19);
            groupBox1.Controls.Add(materialLabel16);
            groupBox1.Controls.Add(txtKmFinal);
            groupBox1.Controls.Add(txtDestino);
            groupBox1.Controls.Add(materialLabel11);
            groupBox1.Controls.Add(materialLabel9);
            groupBox1.Controls.Add(txtKmFinal2);
            groupBox1.Location = new Point(16, 286);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1079, 265);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            // 
            // materialLabel15
            // 
            materialLabel15.AutoSize = true;
            materialLabel15.Depth = 0;
            materialLabel15.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel15.Location = new Point(482, 145);
            materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel15.Name = "materialLabel15";
            materialLabel15.Size = new Size(91, 19);
            materialLabel15.TabIndex = 49;
            materialLabel15.Text = "Km recorrido";
            // 
            // txtKmRecorrido
            // 
            txtKmRecorrido.AnimateReadOnly = false;
            txtKmRecorrido.BorderStyle = BorderStyle.None;
            txtKmRecorrido.Depth = 0;
            txtKmRecorrido.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtKmRecorrido.LeadingIcon = null;
            txtKmRecorrido.Location = new Point(482, 73);
            txtKmRecorrido.MaxLength = 50;
            txtKmRecorrido.MouseState = MaterialSkin.MouseState.OUT;
            txtKmRecorrido.Multiline = false;
            txtKmRecorrido.Name = "txtKmRecorrido";
            txtKmRecorrido.Size = new Size(130, 50);
            txtKmRecorrido.TabIndex = 47;
            txtKmRecorrido.Text = "";
            txtKmRecorrido.TrailingIcon = null;
            // 
            // materialLabel20
            // 
            materialLabel20.AutoSize = true;
            materialLabel20.Depth = 0;
            materialLabel20.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel20.Location = new Point(482, 35);
            materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel20.Name = "materialLabel20";
            materialLabel20.Size = new Size(91, 19);
            materialLabel20.TabIndex = 46;
            materialLabel20.Text = "Km recorrido";
            // 
            // txtKmRecorrido2
            // 
            txtKmRecorrido2.AnimateReadOnly = false;
            txtKmRecorrido2.BorderStyle = BorderStyle.None;
            txtKmRecorrido2.Depth = 0;
            txtKmRecorrido2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtKmRecorrido2.LeadingIcon = null;
            txtKmRecorrido2.Location = new Point(482, 184);
            txtKmRecorrido2.MaxLength = 50;
            txtKmRecorrido2.MouseState = MaterialSkin.MouseState.OUT;
            txtKmRecorrido2.Multiline = false;
            txtKmRecorrido2.Name = "txtKmRecorrido2";
            txtKmRecorrido2.Size = new Size(130, 50);
            txtKmRecorrido2.TabIndex = 48;
            txtKmRecorrido2.Text = "";
            txtKmRecorrido2.TrailingIcon = null;
            // 
            // materialLabel19
            // 
            materialLabel19.AutoSize = true;
            materialLabel19.Depth = 0;
            materialLabel19.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel19.Location = new Point(359, 145);
            materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel19.Name = "materialLabel19";
            materialLabel19.Size = new Size(64, 19);
            materialLabel19.TabIndex = 45;
            materialLabel19.Text = "Km Final";
            // 
            // materialLabel16
            // 
            materialLabel16.AutoSize = true;
            materialLabel16.Depth = 0;
            materialLabel16.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel16.Location = new Point(249, 147);
            materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel16.Name = "materialLabel16";
            materialLabel16.Size = new Size(82, 19);
            materialLabel16.TabIndex = 45;
            materialLabel16.Text = "Km Inicial\r\n";
            // 
            // btnCrearPDF
            // 
            btnCrearPDF.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCrearPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCrearPDF.Depth = 0;
            btnCrearPDF.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearPDF.HighEmphasis = true;
            btnCrearPDF.Icon = null;
            btnCrearPDF.Location = new Point(474, 560);
            btnCrearPDF.Margin = new Padding(4, 6, 4, 6);
            btnCrearPDF.MinimumSize = new Size(98, 60);
            btnCrearPDF.MouseState = MaterialSkin.MouseState.HOVER;
            btnCrearPDF.Name = "btnCrearPDF";
            btnCrearPDF.NoAccentTextColor = Color.Empty;
            btnCrearPDF.Size = new Size(98, 60);
            btnCrearPDF.TabIndex = 57;
            btnCrearPDF.Text = "Crear PDF";
            btnCrearPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCrearPDF.UseAccentColor = false;
            btnCrearPDF.UseVisualStyleBackColor = true;
            btnCrearPDF.Click += btnCrearPDF_Click;
            // 
            // FormBV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1107, 593);
            Controls.Add(btnCrearPDF);
            Controls.Add(txtNombreConductor2);
            Controls.Add(materialLabel13);
            Controls.Add(tctKmInicial2);
            Controls.Add(dtpFecha2);
            Controls.Add(materialLabel17);
            Controls.Add(materialLabel18);
            Controls.Add(txtHora2);
            Controls.Add(txtNombreConductor);
            Controls.Add(materialLabel12);
            Controls.Add(tctKmInicial);
            Controls.Add(materialLabel8);
            Controls.Add(dtpFecha);
            Controls.Add(materialLabel7);
            Controls.Add(materialLabel10);
            Controls.Add(txtHora);
            Controls.Add(txtPlaca);
            Controls.Add(txtModelo);
            Controls.Add(txtTipo);
            Controls.Add(txtMarca);
            Controls.Add(materialLabel6);
            Controls.Add(materialLabel5);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(cboDependencia);
            Controls.Add(materialLabel2);
            Controls.Add(cboArea);
            Controls.Add(materialLabel1);
            Controls.Add(groupBox1);
            Name = "FormBV";
            Text = "BITACORA DE VEHICULO";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cboArea;
        private MaterialSkin.Controls.MaterialComboBox cboDependencia;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txtMarca;
        private MaterialSkin.Controls.MaterialTextBox txtTipo;
        private MaterialSkin.Controls.MaterialTextBox txtModelo;
        private MaterialSkin.Controls.MaterialTextBox txtPlaca;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtHora;
        private DateTimePicker dtpFecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox tctKmInicial;
        private MaterialSkin.Controls.MaterialTextBox txtKmFinal;
        private MaterialSkin.Controls.MaterialTextBox txtDestino;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox txtNombreConductor;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialTextBox txtNombreConductor2;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialTextBox txtDestino2;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialTextBox txtKmFinal2;
        private MaterialSkin.Controls.MaterialTextBox tctKmInicial2;
        private DateTimePicker dtpFecha2;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtHora2;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialTextBox txtKmRecorrido;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialTextBox txtKmRecorrido2;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialButton btnCrearPDF;
    }
}