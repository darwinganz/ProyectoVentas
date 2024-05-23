using Academico.Entities;
using Academico.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academico.Presentacion
{
    public partial class Frm_HoraDocente : Form
    {
        public Frm_HoraDocente()
        {
            InitializeComponent();
        }

        DocenteNegocio objnegocio = new DocenteNegocio();
        Docente objDocente = new Docente();

        void Limpiar()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        bool validar(string p1)
        {
            if (p1.Length == 0)
                return false;
            else
                return true;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validar(txtNum_doc.Text) == true)
            {
                objDocente.Num_doc = txtNum_doc.Text;
                objDocente.Horaentrada = DateTime.Now; ;
                
                try
                {
                    objnegocio.Agregar(objDocente);
                    MessageBox.Show("Se ha registrado su ingreso");
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar los Datos");
            }
        }

        private void hora_entrada_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
