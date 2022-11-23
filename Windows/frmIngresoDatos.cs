using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = Entidades.Color;

namespace Windows
{
    public partial class frmIngresoDatos : Form
    {
        public frmIngresoDatos()
        {
            InitializeComponent();
        }
        #region Variables
        private Repositorio repositorio = new Repositorio();
        private Esfera esfera;

        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {


            if (ValidarDatos())
            {
                if (esfera == null)
                {
                    esfera = new Esfera();
                }

                esfera.radio = Convert.ToDouble(txtRadio.Text);
                esfera.Color = (Color)cbColor.SelectedIndex+1;
                esfera.Trazo = ValidarRadioButtons();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (!double.TryParse(txtRadio.Text, out double radio) || txtRadio.Text.Length <=0 || radio<=0)
            {
                valido = false;
                epValidacion.SetError(txtRadio, "Ingrese un numero positivo para el radio");
            }
            if (cbColor.SelectedIndex==-1)
            {
                valido = false;
                epValidacion.SetError(cbColor, "Elija un color");
            }
            
            return valido;
        }

        private Trazo ValidarRadioButtons()
        {
            if (rbContinuo.Checked==true)
            {
                esfera.Trazo=Trazo.Continuo;
                return esfera.Trazo;
            }
            else if (rbPuntos.Checked==true)
            {
                esfera.Trazo = Trazo.Puntos;
                return esfera.Trazo;
            }         
                esfera.Trazo = Trazo.Rayas;
                return esfera.Trazo;
             
        }
        public Esfera GetEsfera() { return esfera; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
