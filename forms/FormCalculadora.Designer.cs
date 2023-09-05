namespace ABT2023.forms
{
    partial class FormCalculadora
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
            label1 = new Label();
            txtMilla = new MaterialSkin.Controls.MaterialTextBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(281, 171);
            label1.Name = "label1";
            label1.Size = new Size(508, 40);
            label1.TabIndex = 0;
            label1.Text = "INGRESA LAS MILLAS A CONVERTIR";
            // 
            // txtMilla
            // 
            txtMilla.Anchor = AnchorStyles.None;
            txtMilla.AnimateReadOnly = false;
            txtMilla.BorderStyle = BorderStyle.None;
            txtMilla.Depth = 0;
            txtMilla.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMilla.LeadingIcon = null;
            txtMilla.Location = new Point(420, 256);
            txtMilla.MaxLength = 50;
            txtMilla.MouseState = MaterialSkin.MouseState.OUT;
            txtMilla.Multiline = false;
            txtMilla.Name = "txtMilla";
            txtMilla.Size = new Size(262, 50);
            txtMilla.TabIndex = 1;
            txtMilla.Text = "";
            txtMilla.TrailingIcon = null;
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.None;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(510, 350);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(101, 36);
            materialButton1.TabIndex = 2;
            materialButton1.Text = "CONVERTIR";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // FormCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 563);
            Controls.Add(materialButton1);
            Controls.Add(txtMilla);
            Controls.Add(label1);
            Name = "FormCalculadora";
            Text = "CONVERTIR MI A KM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtMilla;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}