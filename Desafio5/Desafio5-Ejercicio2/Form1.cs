using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio5_Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            string strRadioSexo;
            string strEsExtranjero;

            // Todos los campos deben ser obligatorios, menos el de fecha de registro y es extranjero

            if(ingresadoAlgunDatoVacio())
            {
                mostrarLblIngresoDatosVacios();
            } else
            {
                esconderLblIngresoDatosVacios();

                if (radioHombre.Checked)
                {
                    strRadioSexo = radioHombre.Text;
                }
                else
                {
                    strRadioSexo = radioMujer.Text;
                }

                if(checkBoxExtranjero.Checked)
                {
                    strEsExtranjero = "Si";
                } else
                {
                    strEsExtranjero = "No";
                }

                dataGridAlumnos.Rows.Add(textNombre.Text, datePickerFecha.Text, comboBoxEstado.Text, strRadioSexo, strEsExtranjero);
            }

            

        }

        private bool ingresadoAlgunDatoVacio()
        {
            if (string.IsNullOrEmpty(textNombre.Text) || string.IsNullOrEmpty(comboBoxEstado.Text)
                || (!radioHombre.Checked && !radioMujer.Checked)) 
            {
                return true;
            }

            return false;
        }

        private void mostrarLblIngresoDatosVacios()
        {
            lblAviso.Visible = true;
        }
        private void esconderLblIngresoDatosVacios()
        {
            lblAviso.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
