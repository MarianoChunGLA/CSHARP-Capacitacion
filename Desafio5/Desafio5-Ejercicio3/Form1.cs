using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio5_Ejercicio3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSuma_Click(object sender, EventArgs e)
		{
			outputResultado.Text = Convert.ToString( inputPrimerNumero.Value + inputSegundoNumero.Value );
		}

		private void btnResta_Click(object sender, EventArgs e)
		{
			outputResultado.Text = Convert.ToString(inputPrimerNumero.Value - inputSegundoNumero.Value);
		}

		private void btnDivision_Click(object sender, EventArgs e)
		{
			if(inputSegundoNumero.Value == 0)
			{
				outputResultado.Text = "No se puede dividir por cero";
			} else
			{
				outputResultado.Text = Convert.ToString(inputPrimerNumero.Value / inputSegundoNumero.Value);
			}
			
		}

		private void btnMultiplicacion_Click(object sender, EventArgs e)
		{
			outputResultado.Text = Convert.ToString(inputPrimerNumero.Value * inputSegundoNumero.Value);
		}


	}
}
