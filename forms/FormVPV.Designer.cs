namespace ABT2023.forms
{
    partial class FormVPV
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
            txtAfavorDe = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            cboDepartamento = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            dtpFechaPdf = new DateTimePicker();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            dtpInicioViaje = new DateTimePicker();
            dtpFinViaje = new DateTimePicker();
            nudHoradeGira = new NumericUpDown();
            txtHoraInicio = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            txtHoraFin = new MaterialSkin.Controls.MaterialMaskedTextBox();
            cboMediodeTransporte = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            txtLugardeVisita = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            txtMotivodeViaje = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            chkDesayuno = new MaterialSkin.Controls.MaterialCheckbox();
            chkAlmuerzo = new MaterialSkin.Controls.MaterialCheckbox();
            chkCena = new MaterialSkin.Controls.MaterialCheckbox();
            npdDiaDesayuno = new NumericUpDown();
            npdDiaAlmuerzo = new NumericUpDown();
            npdDiaCena = new NumericUpDown();
            materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            txtGastoDiaDesayuno = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtGastoDiaAlmuerzo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtGastoDiaCena = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            txtGastoDiaCombustible = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            txtGastoDiaImpuesto = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtGastoDiaHotel = new MaterialSkin.Controls.MaterialMaskedTextBox();
            npdDiaCombustible = new NumericUpDown();
            npdDiaImpuestos = new NumericUpDown();
            npdDiaHotel = new NumericUpDown();
            txtHotel = new MaterialSkin.Controls.MaterialTextBox();
            txtImpuestos = new MaterialSkin.Controls.MaterialTextBox();
            txtCombustible = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            btnCrearPdf = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtCargo = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)nudHoradeGira).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdDiaDesayuno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdDiaAlmuerzo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdDiaCena).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdDiaCombustible).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdDiaImpuestos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdDiaHotel).BeginInit();
            SuspendLayout();
            // 
            // txtAfavorDe
            // 
            txtAfavorDe.AnimateReadOnly = false;
            txtAfavorDe.BorderStyle = BorderStyle.None;
            txtAfavorDe.Depth = 0;
            txtAfavorDe.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAfavorDe.LeadingIcon = null;
            txtAfavorDe.Location = new Point(95, 7);
            txtAfavorDe.Margin = new Padding(2);
            txtAfavorDe.MaxLength = 50;
            txtAfavorDe.MouseState = MaterialSkin.MouseState.OUT;
            txtAfavorDe.Multiline = false;
            txtAfavorDe.Name = "txtAfavorDe";
            txtAfavorDe.Size = new Size(264, 50);
            txtAfavorDe.TabIndex = 1;
            txtAfavorDe.Text = "";
            txtAfavorDe.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(415, 25);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(106, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Departamento:";
            // 
            // cboDepartamento
            // 
            cboDepartamento.AutoResize = false;
            cboDepartamento.BackColor = Color.FromArgb(255, 255, 255);
            cboDepartamento.Depth = 0;
            cboDepartamento.DrawMode = DrawMode.OwnerDrawVariable;
            cboDepartamento.DropDownHeight = 174;
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.DropDownWidth = 121;
            cboDepartamento.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboDepartamento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.IntegralHeight = false;
            cboDepartamento.ItemHeight = 43;
            cboDepartamento.Items.AddRange(new object[] { "Ventas", "Servicios Varios", "Laboratorio", "Administrativo", "Gerencia" });
            cboDepartamento.Location = new Point(538, 8);
            cboDepartamento.MaxDropDownItems = 4;
            cboDepartamento.MouseState = MaterialSkin.MouseState.OUT;
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(226, 49);
            cboDepartamento.StartIndex = 0;
            cboDepartamento.TabIndex = 3;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(862, 95);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(48, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Fecha:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(779, 25);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(47, 19);
            materialLabel4.TabIndex = 5;
            materialLabel4.Text = "Cargo:";
            // 
            // dtpFechaPdf
            // 
            dtpFechaPdf.Format = DateTimePickerFormat.Short;
            dtpFechaPdf.Location = new Point(939, 92);
            dtpFechaPdf.MaxDate = new DateTime(2080, 12, 31, 0, 0, 0, 0);
            dtpFechaPdf.MinDate = new DateTime(2023, 8, 17, 0, 0, 0, 0);
            dtpFechaPdf.Name = "dtpFechaPdf";
            dtpFechaPdf.Size = new Size(105, 23);
            dtpFechaPdf.TabIndex = 6;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(103, 95);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(173, 19);
            materialLabel6.TabIndex = 10;
            materialLabel6.Text = "Fecha de Inicio del viaje:";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(81, 136);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(195, 19);
            materialLabel7.TabIndex = 11;
            materialLabel7.Text = "Fecha de Regrego del Viaje:";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(74, 175);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(202, 19);
            materialLabel8.TabIndex = 12;
            materialLabel8.Text = "Tiempo aprox. de la gira (H):";
            // 
            // dtpInicioViaje
            // 
            dtpInicioViaje.Format = DateTimePickerFormat.Short;
            dtpInicioViaje.Location = new Point(322, 90);
            dtpInicioViaje.MaxDate = new DateTime(2080, 12, 31, 0, 0, 0, 0);
            dtpInicioViaje.MinDate = new DateTime(2023, 8, 17, 0, 0, 0, 0);
            dtpInicioViaje.Name = "dtpInicioViaje";
            dtpInicioViaje.Size = new Size(105, 23);
            dtpInicioViaje.TabIndex = 13;
            // 
            // dtpFinViaje
            // 
            dtpFinViaje.Format = DateTimePickerFormat.Short;
            dtpFinViaje.Location = new Point(322, 131);
            dtpFinViaje.MaxDate = new DateTime(2080, 12, 31, 0, 0, 0, 0);
            dtpFinViaje.MinDate = new DateTime(2023, 8, 17, 0, 0, 0, 0);
            dtpFinViaje.Name = "dtpFinViaje";
            dtpFinViaje.Size = new Size(105, 23);
            dtpFinViaje.TabIndex = 14;
            // 
            // nudHoradeGira
            // 
            nudHoradeGira.Location = new Point(322, 174);
            nudHoradeGira.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHoradeGira.Name = "nudHoradeGira";
            nudHoradeGira.Size = new Size(105, 23);
            nudHoradeGira.TabIndex = 15;
            nudHoradeGira.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.AllowPromptAsInput = true;
            txtHoraInicio.AnimateReadOnly = false;
            txtHoraInicio.AsciiOnly = false;
            txtHoraInicio.BackgroundImageLayout = ImageLayout.None;
            txtHoraInicio.BeepOnError = false;
            txtHoraInicio.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtHoraInicio.Depth = 0;
            txtHoraInicio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHoraInicio.HidePromptOnLeave = false;
            txtHoraInicio.HideSelection = true;
            txtHoraInicio.InsertKeyMode = InsertKeyMode.Default;
            txtHoraInicio.LeadingIcon = null;
            txtHoraInicio.Location = new Point(700, 90);
            txtHoraInicio.Mask = "00:00";
            txtHoraInicio.MaxLength = 32767;
            txtHoraInicio.MouseState = MaterialSkin.MouseState.OUT;
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.PasswordChar = '\0';
            txtHoraInicio.PrefixSuffixText = null;
            txtHoraInicio.PromptChar = '_';
            txtHoraInicio.ReadOnly = false;
            txtHoraInicio.RejectInputOnFirstFailure = false;
            txtHoraInicio.ResetOnPrompt = true;
            txtHoraInicio.ResetOnSpace = true;
            txtHoraInicio.RightToLeft = RightToLeft.No;
            txtHoraInicio.SelectedText = "";
            txtHoraInicio.SelectionLength = 0;
            txtHoraInicio.SelectionStart = 5;
            txtHoraInicio.ShortcutsEnabled = true;
            txtHoraInicio.Size = new Size(88, 48);
            txtHoraInicio.SkipLiterals = true;
            txtHoraInicio.TabIndex = 16;
            txtHoraInicio.TabStop = false;
            txtHoraInicio.Text = "00:00";
            txtHoraInicio.TextAlign = HorizontalAlignment.Left;
            txtHoraInicio.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtHoraInicio.TrailingIcon = null;
            txtHoraInicio.UseSystemPasswordChar = false;
            txtHoraInicio.ValidatingType = null;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(572, 95);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(92, 19);
            materialLabel9.TabIndex = 17;
            materialLabel9.Text = "Hora (Inicio):";
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(588, 174);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(76, 19);
            materialLabel10.TabIndex = 19;
            materialLabel10.Text = "Hora (Fin):";
            // 
            // txtHoraFin
            // 
            txtHoraFin.AllowPromptAsInput = true;
            txtHoraFin.AnimateReadOnly = false;
            txtHoraFin.AsciiOnly = false;
            txtHoraFin.BackgroundImageLayout = ImageLayout.None;
            txtHoraFin.BeepOnError = false;
            txtHoraFin.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtHoraFin.Depth = 0;
            txtHoraFin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHoraFin.HidePromptOnLeave = false;
            txtHoraFin.HideSelection = true;
            txtHoraFin.InsertKeyMode = InsertKeyMode.Default;
            txtHoraFin.LeadingIcon = null;
            txtHoraFin.Location = new Point(700, 161);
            txtHoraFin.Mask = "00:00";
            txtHoraFin.MaxLength = 32767;
            txtHoraFin.MouseState = MaterialSkin.MouseState.OUT;
            txtHoraFin.Name = "txtHoraFin";
            txtHoraFin.PasswordChar = '\0';
            txtHoraFin.PrefixSuffixText = null;
            txtHoraFin.PromptChar = '_';
            txtHoraFin.ReadOnly = false;
            txtHoraFin.RejectInputOnFirstFailure = false;
            txtHoraFin.ResetOnPrompt = true;
            txtHoraFin.ResetOnSpace = true;
            txtHoraFin.RightToLeft = RightToLeft.No;
            txtHoraFin.SelectedText = "";
            txtHoraFin.SelectionLength = 0;
            txtHoraFin.SelectionStart = 5;
            txtHoraFin.ShortcutsEnabled = true;
            txtHoraFin.Size = new Size(88, 48);
            txtHoraFin.SkipLiterals = true;
            txtHoraFin.TabIndex = 18;
            txtHoraFin.TabStop = false;
            txtHoraFin.Text = "00:00";
            txtHoraFin.TextAlign = HorizontalAlignment.Left;
            txtHoraFin.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtHoraFin.TrailingIcon = null;
            txtHoraFin.UseSystemPasswordChar = false;
            txtHoraFin.ValidatingType = null;
            // 
            // cboMediodeTransporte
            // 
            cboMediodeTransporte.AutoResize = false;
            cboMediodeTransporte.BackColor = Color.FromArgb(255, 255, 255);
            cboMediodeTransporte.Depth = 0;
            cboMediodeTransporte.DrawMode = DrawMode.OwnerDrawVariable;
            cboMediodeTransporte.DropDownHeight = 174;
            cboMediodeTransporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMediodeTransporte.DropDownWidth = 121;
            cboMediodeTransporte.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboMediodeTransporte.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboMediodeTransporte.FormattingEnabled = true;
            cboMediodeTransporte.IntegralHeight = false;
            cboMediodeTransporte.ItemHeight = 43;
            cboMediodeTransporte.Items.AddRange(new object[] { "Vía aérea", "Terrestre", "Vehículo Propio", "Vehículo Empresa", "Terrestre", "Otros medios" });
            cboMediodeTransporte.Location = new Point(832, 160);
            cboMediodeTransporte.MaxDropDownItems = 4;
            cboMediodeTransporte.MouseState = MaterialSkin.MouseState.OUT;
            cboMediodeTransporte.Name = "cboMediodeTransporte";
            cboMediodeTransporte.Size = new Size(226, 49);
            cboMediodeTransporte.StartIndex = 0;
            cboMediodeTransporte.TabIndex = 21;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(832, 134);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(211, 19);
            materialLabel11.TabIndex = 20;
            materialLabel11.Text = "Medio de transporte a utilizar:";
            // 
            // txtLugardeVisita
            // 
            txtLugardeVisita.AnimateReadOnly = false;
            txtLugardeVisita.BorderStyle = BorderStyle.None;
            txtLugardeVisita.Depth = 0;
            txtLugardeVisita.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLugardeVisita.LeadingIcon = null;
            txtLugardeVisita.Location = new Point(148, 252);
            txtLugardeVisita.Margin = new Padding(2);
            txtLugardeVisita.MaxLength = 50;
            txtLugardeVisita.MouseState = MaterialSkin.MouseState.OUT;
            txtLugardeVisita.Multiline = false;
            txtLugardeVisita.Name = "txtLugardeVisita";
            txtLugardeVisita.Size = new Size(910, 50);
            txtLugardeVisita.TabIndex = 23;
            txtLugardeVisita.Text = "";
            txtLugardeVisita.TrailingIcon = null;
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(12, 268);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(124, 19);
            materialLabel12.TabIndex = 22;
            materialLabel12.Text = "Lugares a Visitar:";
            // 
            // txtMotivodeViaje
            // 
            txtMotivodeViaje.AnimateReadOnly = false;
            txtMotivodeViaje.BorderStyle = BorderStyle.None;
            txtMotivodeViaje.Depth = 0;
            txtMotivodeViaje.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMotivodeViaje.LeadingIcon = null;
            txtMotivodeViaje.Location = new Point(148, 326);
            txtMotivodeViaje.Margin = new Padding(2);
            txtMotivodeViaje.MaxLength = 50;
            txtMotivodeViaje.MouseState = MaterialSkin.MouseState.OUT;
            txtMotivodeViaje.Multiline = false;
            txtMotivodeViaje.Name = "txtMotivodeViaje";
            txtMotivodeViaje.Size = new Size(910, 50);
            txtMotivodeViaje.TabIndex = 25;
            txtMotivodeViaje.Text = "";
            txtMotivodeViaje.TrailingIcon = null;
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(20, 341);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(116, 19);
            materialLabel13.TabIndex = 24;
            materialLabel13.Text = "Motivo del viaje:";
            // 
            // materialLabel14
            // 
            materialLabel14.AutoSize = true;
            materialLabel14.Depth = 0;
            materialLabel14.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel14.Location = new Point(416, 398);
            materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.Size = new Size(175, 19);
            materialLabel14.TabIndex = 26;
            materialLabel14.Text = "DETALLES DE VIATICOS";
            // 
            // chkDesayuno
            // 
            chkDesayuno.AutoSize = true;
            chkDesayuno.Depth = 0;
            chkDesayuno.Location = new Point(30, 467);
            chkDesayuno.Margin = new Padding(0);
            chkDesayuno.MouseLocation = new Point(-1, -1);
            chkDesayuno.MouseState = MaterialSkin.MouseState.HOVER;
            chkDesayuno.Name = "chkDesayuno";
            chkDesayuno.ReadOnly = false;
            chkDesayuno.Ripple = true;
            chkDesayuno.Size = new Size(106, 37);
            chkDesayuno.TabIndex = 28;
            chkDesayuno.Text = "Desayuno";
            chkDesayuno.UseVisualStyleBackColor = true;
            // 
            // chkAlmuerzo
            // 
            chkAlmuerzo.AutoSize = true;
            chkAlmuerzo.Depth = 0;
            chkAlmuerzo.Location = new Point(30, 547);
            chkAlmuerzo.Margin = new Padding(0);
            chkAlmuerzo.MouseLocation = new Point(-1, -1);
            chkAlmuerzo.MouseState = MaterialSkin.MouseState.HOVER;
            chkAlmuerzo.Name = "chkAlmuerzo";
            chkAlmuerzo.ReadOnly = false;
            chkAlmuerzo.Ripple = true;
            chkAlmuerzo.Size = new Size(102, 37);
            chkAlmuerzo.TabIndex = 29;
            chkAlmuerzo.Text = "Almuerzo";
            chkAlmuerzo.UseVisualStyleBackColor = true;
            // 
            // chkCena
            // 
            chkCena.AutoSize = true;
            chkCena.Depth = 0;
            chkCena.Location = new Point(30, 617);
            chkCena.Margin = new Padding(0);
            chkCena.MouseLocation = new Point(-1, -1);
            chkCena.MouseState = MaterialSkin.MouseState.HOVER;
            chkCena.Name = "chkCena";
            chkCena.ReadOnly = false;
            chkCena.Ripple = true;
            chkCena.Size = new Size(71, 37);
            chkCena.TabIndex = 30;
            chkCena.Text = "Cena";
            chkCena.UseVisualStyleBackColor = true;
            // 
            // npdDiaDesayuno
            // 
            npdDiaDesayuno.Location = new Point(178, 475);
            npdDiaDesayuno.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            npdDiaDesayuno.Name = "npdDiaDesayuno";
            npdDiaDesayuno.Size = new Size(46, 23);
            npdDiaDesayuno.TabIndex = 32;
            npdDiaDesayuno.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // npdDiaAlmuerzo
            // 
            npdDiaAlmuerzo.Location = new Point(178, 555);
            npdDiaAlmuerzo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            npdDiaAlmuerzo.Name = "npdDiaAlmuerzo";
            npdDiaAlmuerzo.Size = new Size(46, 23);
            npdDiaAlmuerzo.TabIndex = 33;
            npdDiaAlmuerzo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // npdDiaCena
            // 
            npdDiaCena.Location = new Point(178, 625);
            npdDiaCena.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            npdDiaCena.Name = "npdDiaCena";
            npdDiaCena.Size = new Size(46, 23);
            npdDiaCena.TabIndex = 34;
            npdDiaCena.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // materialLabel15
            // 
            materialLabel15.AutoSize = true;
            materialLabel15.Depth = 0;
            materialLabel15.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel15.Location = new Point(95, 391);
            materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel15.Name = "materialLabel15";
            materialLabel15.Size = new Size(179, 19);
            materialLabel15.TabIndex = 27;
            materialLabel15.Text = "Viáticos de alimentación:";
            // 
            // materialLabel17
            // 
            materialLabel17.AutoSize = true;
            materialLabel17.Depth = 0;
            materialLabel17.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel17.Location = new Point(270, 424);
            materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel17.Name = "materialLabel17";
            materialLabel17.Size = new Size(76, 19);
            materialLabel17.TabIndex = 32;
            materialLabel17.Text = "Monto/día";
            // 
            // txtGastoDiaDesayuno
            // 
            txtGastoDiaDesayuno.AllowPromptAsInput = true;
            txtGastoDiaDesayuno.AnimateReadOnly = false;
            txtGastoDiaDesayuno.AsciiOnly = false;
            txtGastoDiaDesayuno.BackgroundImageLayout = ImageLayout.None;
            txtGastoDiaDesayuno.BeepOnError = false;
            txtGastoDiaDesayuno.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtGastoDiaDesayuno.Depth = 0;
            txtGastoDiaDesayuno.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGastoDiaDesayuno.HidePromptOnLeave = false;
            txtGastoDiaDesayuno.HideSelection = true;
            txtGastoDiaDesayuno.InsertKeyMode = InsertKeyMode.Default;
            txtGastoDiaDesayuno.LeadingIcon = null;
            txtGastoDiaDesayuno.Location = new Point(270, 467);
            txtGastoDiaDesayuno.Mask = "0.00";
            txtGastoDiaDesayuno.MaxLength = 32767;
            txtGastoDiaDesayuno.MouseState = MaterialSkin.MouseState.OUT;
            txtGastoDiaDesayuno.Name = "txtGastoDiaDesayuno";
            txtGastoDiaDesayuno.PasswordChar = '\0';
            txtGastoDiaDesayuno.PrefixSuffixText = null;
            txtGastoDiaDesayuno.PromptChar = '_';
            txtGastoDiaDesayuno.ReadOnly = false;
            txtGastoDiaDesayuno.RejectInputOnFirstFailure = false;
            txtGastoDiaDesayuno.ResetOnPrompt = true;
            txtGastoDiaDesayuno.ResetOnSpace = true;
            txtGastoDiaDesayuno.RightToLeft = RightToLeft.No;
            txtGastoDiaDesayuno.SelectedText = "";
            txtGastoDiaDesayuno.SelectionLength = 0;
            txtGastoDiaDesayuno.SelectionStart = 4;
            txtGastoDiaDesayuno.ShortcutsEnabled = true;
            txtGastoDiaDesayuno.Size = new Size(88, 48);
            txtGastoDiaDesayuno.SkipLiterals = true;
            txtGastoDiaDesayuno.TabIndex = 33;
            txtGastoDiaDesayuno.TabStop = false;
            txtGastoDiaDesayuno.Text = "0.00";
            txtGastoDiaDesayuno.TextAlign = HorizontalAlignment.Left;
            txtGastoDiaDesayuno.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtGastoDiaDesayuno.TrailingIcon = null;
            txtGastoDiaDesayuno.UseSystemPasswordChar = false;
            txtGastoDiaDesayuno.ValidatingType = null;
            // 
            // txtGastoDiaAlmuerzo
            // 
            txtGastoDiaAlmuerzo.AllowPromptAsInput = true;
            txtGastoDiaAlmuerzo.AnimateReadOnly = false;
            txtGastoDiaAlmuerzo.AsciiOnly = false;
            txtGastoDiaAlmuerzo.BackgroundImageLayout = ImageLayout.None;
            txtGastoDiaAlmuerzo.BeepOnError = false;
            txtGastoDiaAlmuerzo.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtGastoDiaAlmuerzo.Depth = 0;
            txtGastoDiaAlmuerzo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGastoDiaAlmuerzo.HidePromptOnLeave = false;
            txtGastoDiaAlmuerzo.HideSelection = true;
            txtGastoDiaAlmuerzo.InsertKeyMode = InsertKeyMode.Default;
            txtGastoDiaAlmuerzo.LeadingIcon = null;
            txtGastoDiaAlmuerzo.Location = new Point(270, 539);
            txtGastoDiaAlmuerzo.Mask = "0.00";
            txtGastoDiaAlmuerzo.MaxLength = 32767;
            txtGastoDiaAlmuerzo.MouseState = MaterialSkin.MouseState.OUT;
            txtGastoDiaAlmuerzo.Name = "txtGastoDiaAlmuerzo";
            txtGastoDiaAlmuerzo.PasswordChar = '\0';
            txtGastoDiaAlmuerzo.PrefixSuffixText = null;
            txtGastoDiaAlmuerzo.PromptChar = '_';
            txtGastoDiaAlmuerzo.ReadOnly = false;
            txtGastoDiaAlmuerzo.RejectInputOnFirstFailure = false;
            txtGastoDiaAlmuerzo.ResetOnPrompt = true;
            txtGastoDiaAlmuerzo.ResetOnSpace = true;
            txtGastoDiaAlmuerzo.RightToLeft = RightToLeft.No;
            txtGastoDiaAlmuerzo.SelectedText = "";
            txtGastoDiaAlmuerzo.SelectionLength = 0;
            txtGastoDiaAlmuerzo.SelectionStart = 4;
            txtGastoDiaAlmuerzo.ShortcutsEnabled = true;
            txtGastoDiaAlmuerzo.Size = new Size(88, 48);
            txtGastoDiaAlmuerzo.SkipLiterals = true;
            txtGastoDiaAlmuerzo.TabIndex = 34;
            txtGastoDiaAlmuerzo.TabStop = false;
            txtGastoDiaAlmuerzo.Text = "0.00";
            txtGastoDiaAlmuerzo.TextAlign = HorizontalAlignment.Left;
            txtGastoDiaAlmuerzo.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtGastoDiaAlmuerzo.TrailingIcon = null;
            txtGastoDiaAlmuerzo.UseSystemPasswordChar = false;
            txtGastoDiaAlmuerzo.ValidatingType = null;
            // 
            // txtGastoDiaCena
            // 
            txtGastoDiaCena.AllowPromptAsInput = true;
            txtGastoDiaCena.AnimateReadOnly = false;
            txtGastoDiaCena.AsciiOnly = false;
            txtGastoDiaCena.BackgroundImageLayout = ImageLayout.None;
            txtGastoDiaCena.BeepOnError = false;
            txtGastoDiaCena.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtGastoDiaCena.Depth = 0;
            txtGastoDiaCena.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGastoDiaCena.HidePromptOnLeave = false;
            txtGastoDiaCena.HideSelection = true;
            txtGastoDiaCena.InsertKeyMode = InsertKeyMode.Default;
            txtGastoDiaCena.LeadingIcon = null;
            txtGastoDiaCena.Location = new Point(271, 606);
            txtGastoDiaCena.Mask = "0.00";
            txtGastoDiaCena.MaxLength = 32767;
            txtGastoDiaCena.MouseState = MaterialSkin.MouseState.OUT;
            txtGastoDiaCena.Name = "txtGastoDiaCena";
            txtGastoDiaCena.PasswordChar = '\0';
            txtGastoDiaCena.PrefixSuffixText = null;
            txtGastoDiaCena.PromptChar = '_';
            txtGastoDiaCena.ReadOnly = false;
            txtGastoDiaCena.RejectInputOnFirstFailure = false;
            txtGastoDiaCena.ResetOnPrompt = true;
            txtGastoDiaCena.ResetOnSpace = true;
            txtGastoDiaCena.RightToLeft = RightToLeft.No;
            txtGastoDiaCena.SelectedText = "";
            txtGastoDiaCena.SelectionLength = 0;
            txtGastoDiaCena.SelectionStart = 4;
            txtGastoDiaCena.ShortcutsEnabled = true;
            txtGastoDiaCena.Size = new Size(88, 48);
            txtGastoDiaCena.SkipLiterals = true;
            txtGastoDiaCena.TabIndex = 37;
            txtGastoDiaCena.TabStop = false;
            txtGastoDiaCena.Text = "0.00";
            txtGastoDiaCena.TextAlign = HorizontalAlignment.Left;
            txtGastoDiaCena.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtGastoDiaCena.TrailingIcon = null;
            txtGastoDiaCena.UseSystemPasswordChar = false;
            txtGastoDiaCena.ValidatingType = null;
            // 
            // materialLabel16
            // 
            materialLabel16.AutoSize = true;
            materialLabel16.Depth = 0;
            materialLabel16.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel16.Location = new Point(178, 424);
            materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel16.Name = "materialLabel16";
            materialLabel16.Size = new Size(33, 19);
            materialLabel16.TabIndex = 38;
            materialLabel16.Text = "Días";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(827, 413);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(33, 19);
            materialLabel5.TabIndex = 47;
            materialLabel5.Text = "Días";
            // 
            // txtGastoDiaCombustible
            // 
            txtGastoDiaCombustible.AllowPromptAsInput = true;
            txtGastoDiaCombustible.AnimateReadOnly = false;
            txtGastoDiaCombustible.AsciiOnly = false;
            txtGastoDiaCombustible.BackgroundImageLayout = ImageLayout.None;
            txtGastoDiaCombustible.BeepOnError = false;
            txtGastoDiaCombustible.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtGastoDiaCombustible.Depth = 0;
            txtGastoDiaCombustible.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGastoDiaCombustible.HidePromptOnLeave = false;
            txtGastoDiaCombustible.HideSelection = true;
            txtGastoDiaCombustible.InsertKeyMode = InsertKeyMode.Default;
            txtGastoDiaCombustible.LeadingIcon = null;
            txtGastoDiaCombustible.Location = new Point(919, 581);
            txtGastoDiaCombustible.Mask = "0.00";
            txtGastoDiaCombustible.MaxLength = 32767;
            txtGastoDiaCombustible.MouseState = MaterialSkin.MouseState.OUT;
            txtGastoDiaCombustible.Name = "txtGastoDiaCombustible";
            txtGastoDiaCombustible.PasswordChar = '\0';
            txtGastoDiaCombustible.PrefixSuffixText = null;
            txtGastoDiaCombustible.PromptChar = '_';
            txtGastoDiaCombustible.ReadOnly = false;
            txtGastoDiaCombustible.RejectInputOnFirstFailure = false;
            txtGastoDiaCombustible.ResetOnPrompt = true;
            txtGastoDiaCombustible.ResetOnSpace = true;
            txtGastoDiaCombustible.RightToLeft = RightToLeft.No;
            txtGastoDiaCombustible.SelectedText = "";
            txtGastoDiaCombustible.SelectionLength = 0;
            txtGastoDiaCombustible.SelectionStart = 4;
            txtGastoDiaCombustible.ShortcutsEnabled = true;
            txtGastoDiaCombustible.Size = new Size(88, 48);
            txtGastoDiaCombustible.SkipLiterals = true;
            txtGastoDiaCombustible.TabIndex = 46;
            txtGastoDiaCombustible.TabStop = false;
            txtGastoDiaCombustible.Text = "0.00";
            txtGastoDiaCombustible.TextAlign = HorizontalAlignment.Left;
            txtGastoDiaCombustible.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtGastoDiaCombustible.TrailingIcon = null;
            txtGastoDiaCombustible.UseSystemPasswordChar = false;
            txtGastoDiaCombustible.ValidatingType = null;
            // 
            // materialLabel18
            // 
            materialLabel18.AutoSize = true;
            materialLabel18.Depth = 0;
            materialLabel18.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel18.Location = new Point(919, 413);
            materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel18.Name = "materialLabel18";
            materialLabel18.Size = new Size(76, 19);
            materialLabel18.TabIndex = 40;
            materialLabel18.Text = "Monto/día";
            // 
            // txtGastoDiaImpuesto
            // 
            txtGastoDiaImpuesto.AllowPromptAsInput = true;
            txtGastoDiaImpuesto.AnimateReadOnly = false;
            txtGastoDiaImpuesto.AsciiOnly = false;
            txtGastoDiaImpuesto.BackgroundImageLayout = ImageLayout.None;
            txtGastoDiaImpuesto.BeepOnError = false;
            txtGastoDiaImpuesto.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtGastoDiaImpuesto.Depth = 0;
            txtGastoDiaImpuesto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGastoDiaImpuesto.HidePromptOnLeave = false;
            txtGastoDiaImpuesto.HideSelection = true;
            txtGastoDiaImpuesto.InsertKeyMode = InsertKeyMode.Default;
            txtGastoDiaImpuesto.LeadingIcon = null;
            txtGastoDiaImpuesto.Location = new Point(919, 513);
            txtGastoDiaImpuesto.Mask = "0.00";
            txtGastoDiaImpuesto.MaxLength = 32767;
            txtGastoDiaImpuesto.MouseState = MaterialSkin.MouseState.OUT;
            txtGastoDiaImpuesto.Name = "txtGastoDiaImpuesto";
            txtGastoDiaImpuesto.PasswordChar = '\0';
            txtGastoDiaImpuesto.PrefixSuffixText = null;
            txtGastoDiaImpuesto.PromptChar = '_';
            txtGastoDiaImpuesto.ReadOnly = false;
            txtGastoDiaImpuesto.RejectInputOnFirstFailure = false;
            txtGastoDiaImpuesto.ResetOnPrompt = true;
            txtGastoDiaImpuesto.ResetOnSpace = true;
            txtGastoDiaImpuesto.RightToLeft = RightToLeft.No;
            txtGastoDiaImpuesto.SelectedText = "";
            txtGastoDiaImpuesto.SelectionLength = 0;
            txtGastoDiaImpuesto.SelectionStart = 4;
            txtGastoDiaImpuesto.ShortcutsEnabled = true;
            txtGastoDiaImpuesto.Size = new Size(88, 48);
            txtGastoDiaImpuesto.SkipLiterals = true;
            txtGastoDiaImpuesto.TabIndex = 44;
            txtGastoDiaImpuesto.TabStop = false;
            txtGastoDiaImpuesto.Text = "0.00";
            txtGastoDiaImpuesto.TextAlign = HorizontalAlignment.Left;
            txtGastoDiaImpuesto.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtGastoDiaImpuesto.TrailingIcon = null;
            txtGastoDiaImpuesto.UseSystemPasswordChar = false;
            txtGastoDiaImpuesto.ValidatingType = null;
            // 
            // txtGastoDiaHotel
            // 
            txtGastoDiaHotel.AllowPromptAsInput = true;
            txtGastoDiaHotel.AnimateReadOnly = false;
            txtGastoDiaHotel.AsciiOnly = false;
            txtGastoDiaHotel.BackgroundImageLayout = ImageLayout.None;
            txtGastoDiaHotel.BeepOnError = false;
            txtGastoDiaHotel.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtGastoDiaHotel.Depth = 0;
            txtGastoDiaHotel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGastoDiaHotel.HidePromptOnLeave = false;
            txtGastoDiaHotel.HideSelection = true;
            txtGastoDiaHotel.InsertKeyMode = InsertKeyMode.Default;
            txtGastoDiaHotel.LeadingIcon = null;
            txtGastoDiaHotel.Location = new Point(919, 447);
            txtGastoDiaHotel.Mask = "0.00";
            txtGastoDiaHotel.MaxLength = 32767;
            txtGastoDiaHotel.MouseState = MaterialSkin.MouseState.OUT;
            txtGastoDiaHotel.Name = "txtGastoDiaHotel";
            txtGastoDiaHotel.PasswordChar = '\0';
            txtGastoDiaHotel.PrefixSuffixText = null;
            txtGastoDiaHotel.PromptChar = '_';
            txtGastoDiaHotel.ReadOnly = false;
            txtGastoDiaHotel.RejectInputOnFirstFailure = false;
            txtGastoDiaHotel.ResetOnPrompt = true;
            txtGastoDiaHotel.ResetOnSpace = true;
            txtGastoDiaHotel.RightToLeft = RightToLeft.No;
            txtGastoDiaHotel.SelectedText = "";
            txtGastoDiaHotel.SelectionLength = 0;
            txtGastoDiaHotel.SelectionStart = 4;
            txtGastoDiaHotel.ShortcutsEnabled = true;
            txtGastoDiaHotel.Size = new Size(88, 48);
            txtGastoDiaHotel.SkipLiterals = true;
            txtGastoDiaHotel.TabIndex = 42;
            txtGastoDiaHotel.TabStop = false;
            txtGastoDiaHotel.Text = "0.00";
            txtGastoDiaHotel.TextAlign = HorizontalAlignment.Left;
            txtGastoDiaHotel.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtGastoDiaHotel.TrailingIcon = null;
            txtGastoDiaHotel.UseSystemPasswordChar = false;
            txtGastoDiaHotel.ValidatingType = null;
            // 
            // npdDiaCombustible
            // 
            npdDiaCombustible.Location = new Point(827, 588);
            npdDiaCombustible.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            npdDiaCombustible.Name = "npdDiaCombustible";
            npdDiaCombustible.Size = new Size(46, 23);
            npdDiaCombustible.TabIndex = 45;
            npdDiaCombustible.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // npdDiaImpuestos
            // 
            npdDiaImpuestos.Location = new Point(827, 523);
            npdDiaImpuestos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            npdDiaImpuestos.Name = "npdDiaImpuestos";
            npdDiaImpuestos.Size = new Size(46, 23);
            npdDiaImpuestos.TabIndex = 43;
            npdDiaImpuestos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // npdDiaHotel
            // 
            npdDiaHotel.Location = new Point(827, 460);
            npdDiaHotel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            npdDiaHotel.Name = "npdDiaHotel";
            npdDiaHotel.Size = new Size(46, 23);
            npdDiaHotel.TabIndex = 41;
            npdDiaHotel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtHotel
            // 
            txtHotel.AnimateReadOnly = false;
            txtHotel.BorderStyle = BorderStyle.None;
            txtHotel.Depth = 0;
            txtHotel.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHotel.LeadingIcon = null;
            txtHotel.Location = new Point(612, 445);
            txtHotel.MaxLength = 50;
            txtHotel.MouseState = MaterialSkin.MouseState.OUT;
            txtHotel.Multiline = false;
            txtHotel.Name = "txtHotel";
            txtHotel.Size = new Size(180, 50);
            txtHotel.TabIndex = 48;
            txtHotel.Text = "";
            txtHotel.TrailingIcon = null;
            // 
            // txtImpuestos
            // 
            txtImpuestos.AnimateReadOnly = false;
            txtImpuestos.BorderStyle = BorderStyle.None;
            txtImpuestos.Depth = 0;
            txtImpuestos.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtImpuestos.LeadingIcon = null;
            txtImpuestos.Location = new Point(612, 511);
            txtImpuestos.MaxLength = 50;
            txtImpuestos.MouseState = MaterialSkin.MouseState.OUT;
            txtImpuestos.Multiline = false;
            txtImpuestos.Name = "txtImpuestos";
            txtImpuestos.Size = new Size(180, 50);
            txtImpuestos.TabIndex = 50;
            txtImpuestos.Text = "";
            txtImpuestos.TrailingIcon = null;
            // 
            // txtCombustible
            // 
            txtCombustible.AnimateReadOnly = false;
            txtCombustible.BorderStyle = BorderStyle.None;
            txtCombustible.Depth = 0;
            txtCombustible.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCombustible.LeadingIcon = null;
            txtCombustible.Location = new Point(612, 579);
            txtCombustible.MaxLength = 50;
            txtCombustible.MouseState = MaterialSkin.MouseState.OUT;
            txtCombustible.Multiline = false;
            txtCombustible.Name = "txtCombustible";
            txtCombustible.Size = new Size(180, 50);
            txtCombustible.TabIndex = 52;
            txtCombustible.Text = "";
            txtCombustible.TrailingIcon = null;
            // 
            // materialLabel19
            // 
            materialLabel19.AutoSize = true;
            materialLabel19.Depth = 0;
            materialLabel19.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel19.Location = new Point(475, 464);
            materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel19.Name = "materialLabel19";
            materialLabel19.Size = new Size(42, 19);
            materialLabel19.TabIndex = 53;
            materialLabel19.Text = "Hotel:";
            // 
            // materialLabel20
            // 
            materialLabel20.AutoSize = true;
            materialLabel20.Depth = 0;
            materialLabel20.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel20.Location = new Point(475, 592);
            materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel20.Name = "materialLabel20";
            materialLabel20.Size = new Size(88, 19);
            materialLabel20.TabIndex = 54;
            materialLabel20.Text = "combustible";
            // 
            // materialLabel21
            // 
            materialLabel21.AutoSize = true;
            materialLabel21.Depth = 0;
            materialLabel21.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel21.Location = new Point(475, 527);
            materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel21.Name = "materialLabel21";
            materialLabel21.Size = new Size(79, 19);
            materialLabel21.TabIndex = 55;
            materialLabel21.Text = "impuestos:";
            // 
            // btnCrearPdf
            // 
            btnCrearPdf.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCrearPdf.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCrearPdf.Depth = 0;
            btnCrearPdf.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearPdf.HighEmphasis = true;
            btnCrearPdf.Icon = null;
            btnCrearPdf.Location = new Point(415, 657);
            btnCrearPdf.Margin = new Padding(4, 6, 4, 6);
            btnCrearPdf.MinimumSize = new Size(98, 60);
            btnCrearPdf.MouseState = MaterialSkin.MouseState.HOVER;
            btnCrearPdf.Name = "btnCrearPdf";
            btnCrearPdf.NoAccentTextColor = Color.Empty;
            btnCrearPdf.Size = new Size(98, 60);
            btnCrearPdf.TabIndex = 56;
            btnCrearPdf.Text = "Crear PDF";
            btnCrearPdf.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCrearPdf.UseAccentColor = false;
            btnCrearPdf.UseVisualStyleBackColor = true;
            btnCrearPdf.Click += materialButton1_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(12, 25);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(77, 19);
            materialLabel1.TabIndex = 57;
            materialLabel1.Text = "A favor de:";
            // 
            // txtCargo
            // 
            txtCargo.AnimateReadOnly = false;
            txtCargo.BorderStyle = BorderStyle.None;
            txtCargo.Depth = 0;
            txtCargo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCargo.LeadingIcon = null;
            txtCargo.Location = new Point(832, 7);
            txtCargo.MaxLength = 50;
            txtCargo.MouseState = MaterialSkin.MouseState.OUT;
            txtCargo.Multiline = false;
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(226, 50);
            txtCargo.TabIndex = 58;
            txtCargo.Text = "";
            txtCargo.TrailingIcon = null;
            // 
            // FormVPV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1107, 749);
            Controls.Add(txtCargo);
            Controls.Add(materialLabel1);
            Controls.Add(btnCrearPdf);
            Controls.Add(materialLabel21);
            Controls.Add(materialLabel20);
            Controls.Add(materialLabel19);
            Controls.Add(txtCombustible);
            Controls.Add(txtImpuestos);
            Controls.Add(txtHotel);
            Controls.Add(materialLabel5);
            Controls.Add(txtGastoDiaCombustible);
            Controls.Add(materialLabel18);
            Controls.Add(txtGastoDiaImpuesto);
            Controls.Add(txtGastoDiaHotel);
            Controls.Add(npdDiaCombustible);
            Controls.Add(npdDiaImpuestos);
            Controls.Add(npdDiaHotel);
            Controls.Add(materialLabel16);
            Controls.Add(txtGastoDiaCena);
            Controls.Add(materialLabel15);
            Controls.Add(materialLabel17);
            Controls.Add(txtGastoDiaAlmuerzo);
            Controls.Add(txtGastoDiaDesayuno);
            Controls.Add(npdDiaCena);
            Controls.Add(npdDiaAlmuerzo);
            Controls.Add(npdDiaDesayuno);
            Controls.Add(chkCena);
            Controls.Add(chkAlmuerzo);
            Controls.Add(chkDesayuno);
            Controls.Add(materialLabel14);
            Controls.Add(txtMotivodeViaje);
            Controls.Add(materialLabel13);
            Controls.Add(txtLugardeVisita);
            Controls.Add(materialLabel12);
            Controls.Add(cboMediodeTransporte);
            Controls.Add(materialLabel11);
            Controls.Add(materialLabel10);
            Controls.Add(txtHoraFin);
            Controls.Add(materialLabel9);
            Controls.Add(txtHoraInicio);
            Controls.Add(nudHoradeGira);
            Controls.Add(dtpFinViaje);
            Controls.Add(dtpInicioViaje);
            Controls.Add(materialLabel8);
            Controls.Add(materialLabel7);
            Controls.Add(materialLabel6);
            Controls.Add(dtpFechaPdf);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(cboDepartamento);
            Controls.Add(materialLabel2);
            Controls.Add(txtAfavorDe);
            Name = "FormVPV";
            Text = "BITACORA DE VIATICOS ";
            ((System.ComponentModel.ISupportInitialize)nudHoradeGira).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdDiaDesayuno).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdDiaAlmuerzo).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdDiaCena).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdDiaCombustible).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdDiaImpuestos).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdDiaHotel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtAfavorDe;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cboDepartamento;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private DateTimePicker dtpFechaPdf;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private DateTimePicker dtpInicioViaje;
        private DateTimePicker dtpFinViaje;
        private NumericUpDown nudHoradeGira;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtHoraInicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtHoraFin;
        private MaterialSkin.Controls.MaterialComboBox cboMediodeTransporte;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox txtLugardeVisita;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialTextBox txtMotivodeViaje;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialCheckbox chkDesayuno;
        private MaterialSkin.Controls.MaterialCheckbox chkAlmuerzo;
        private MaterialSkin.Controls.MaterialCheckbox chkCena;
        private NumericUpDown npdDiaDesayuno;
        private NumericUpDown npdDiaAlmuerzo;
        private NumericUpDown npdDiaCena;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtGastoDiaDesayuno;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtGastoDiaAlmuerzo;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtGastoDiaCena;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtGastoDiaCombustible;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtGastoDiaImpuesto;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtGastoDiaHotel;
        private NumericUpDown npdDiaCombustible;
        private NumericUpDown npdDiaImpuestos;
        private NumericUpDown npdDiaHotel;
        private MaterialSkin.Controls.MaterialTextBox txtHotel;
        private MaterialSkin.Controls.MaterialTextBox txtImpuestos;
        private MaterialSkin.Controls.MaterialTextBox txtCombustible;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialButton btnCrearPdf;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtCargo;
    }
}