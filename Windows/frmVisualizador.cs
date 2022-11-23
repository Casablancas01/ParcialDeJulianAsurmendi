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


namespace Windows
{
    public partial class frmVisualizador : Form
    {
        public frmVisualizador()
        {
            InitializeComponent();
        }
        #region Variables
        private Repositorio repositorio;
        private List<Esfera> lista;



        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmIngresoDatos nuevaEsfera = new frmIngresoDatos();
            DialogResult dr = nuevaEsfera.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Esfera esfera = nuevaEsfera.GetEsfera();
            repositorio.Agregar(esfera);
            MostrarDgv();
            MostrarCantidad();
        }

        private void MostrarCantidad()
        {
        
        lbCantidad.Text=repositorio.GetCantidad().ToString();
        }

        #region Data Grid View
        private void MostrarDgv()
        {
            dgvEsferas.Rows.Clear();
            foreach (var i in lista)
            {
                var r = ConstruirFila();
                SetearFila(r, i);
                AgergarFila(r);
            }
        }
        private void AgergarFila(DataGridViewRow e)
        {
            dgvEsferas.Rows.Add(e);
        }

        private void SetearFila(DataGridViewRow r, Esfera e)
        {

            r.Cells[ColRadio.Index].Value = e.radio.ToString();
            r.Cells[ColColor.Index].Value = e.Color;
            r.Cells[ColTrazo.Index].Value = e.Trazo;
            r.Cells[ColArea.Index].Value = e.GetArea().ToString("F2");
            r.Cells[ColVolumen.Index].Value = e.GetVolumen().ToString("F2");   

            r.Tag = e;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(dgvEsferas);
            return r;
        }

        #endregion

        private void frmVisualizador_Load(object sender, EventArgs e)
        {
            repositorio=new Repositorio();
            lista = repositorio.GetLista();
            if (repositorio.GetCantidad()>0)
            {
                MostrarDgv();
            }
            else
            {
                MessageBox.Show("No hay elementos en el repositorio",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            repositorio.Guardar();
            Application.Exit();
        }

        
    }
}
