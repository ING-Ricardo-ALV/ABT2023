using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.IO;
using Document = iTextSharp.text.Document;
using Paragraph = iTextSharp.text.Paragraph;
using iTextSharp.tool.xml;

namespace ABT2023.forms
{
    public partial class FormBV : Form
    {
        private string area;
        private string dependencia;
        private string marca;
        private string tipo;
        private string modelo;
        private string placa;
        private string hora;
        private DateTime fecha;
        private string kmInicial;
        private string kmFinal;
        private string destino;
        private string nombreConductor;
        private string nombreConductor2;
        private string destino2;
        private string kmFinal2;
        private string kmInicial2;
        private DateTime fecha2;
        private string hora2;
        private string kmRecorrido;
        private string kmRecorrido2;
        public FormBV()
        {
            InitializeComponent();
            Size = new System.Drawing.Size(1123, 602);
            MinimumSize = new System.Drawing.Size(1123, 602);
        }

        private void btnCrearPDF_Click(object sender, EventArgs e)
        {
            // Realiza las validaciones de campos vacíos
            if (string.IsNullOrWhiteSpace(cboArea.Text) ||
                string.IsNullOrWhiteSpace(cboDependencia.Text) ||
                string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtTipo.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtPlaca.Text) ||
                string.IsNullOrWhiteSpace(txtHora.Text) ||
                dtpFecha.Value == null ||
                string.IsNullOrWhiteSpace(tctKmInicial.Text) ||
                string.IsNullOrWhiteSpace(txtKmFinal.Text) ||
                string.IsNullOrWhiteSpace(txtDestino.Text) ||
                string.IsNullOrWhiteSpace(txtNombreConductor.Text) ||
                string.IsNullOrWhiteSpace(txtNombreConductor2.Text) ||
                string.IsNullOrWhiteSpace(txtDestino2.Text) ||
                string.IsNullOrWhiteSpace(txtKmFinal2.Text) ||
                string.IsNullOrWhiteSpace(tctKmInicial2.Text) ||
                dtpFecha2.Value == null ||
                string.IsNullOrWhiteSpace(txtHora2.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de generar el PDF.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            area = cboArea.Text;
            dependencia = cboDependencia.Text;
            marca = txtMarca.Text;
            tipo = txtTipo.Text;
            modelo = txtModelo.Text;
            placa = txtPlaca.Text;
            hora = txtHora.Text;
            fecha = dtpFecha.Value;
            kmInicial = tctKmInicial.Text;
            kmFinal = txtKmFinal.Text;
            destino = txtDestino.Text;
            nombreConductor = txtNombreConductor.Text;
            nombreConductor2 = txtNombreConductor2.Text;
            destino2 = txtDestino2.Text;
            kmFinal2 = txtKmFinal2.Text;
            kmInicial2 = tctKmInicial2.Text;
            fecha2 = dtpFecha2.Value;
            hora2 = txtHora2.Text;
            kmRecorrido = txtKmRecorrido.Text;
            kmRecorrido2 = txtKmRecorrido2.Text;
            // Si todos los campos están completos, puedes continuar con la generación

            //iTextSharp.text.Document report = new iTextSharp.text.Document(PageSize.LETTER.Rotate());

            // del PDF aquí

            try
            {
               

                MessageBox.Show("Informe generado exitosamente.", "Generación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el informe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}


   

