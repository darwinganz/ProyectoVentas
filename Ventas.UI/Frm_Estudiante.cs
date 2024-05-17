using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academico.Negocio;
using Academico.Entities;

namespace Academico.Presentacion

{
    public partial class Frm_Estudiante : Form
    {
        public Frm_Estudiante()
        {
            InitializeComponent();
        }

        EstudianteNegocio bll = new EstudianteNegocio();
        Estudiante objCat = new Estudiante();




        private void Frm_Categoria_Load(object sender, EventArgs e)
        {
            dataCategoria.DataSource = bll.ListarEstudiante();
            this.dataCategoria.Columns[0].Width = 45;
            this.dataCategoria.Columns[1].Width = 80;
            this.dataCategoria.Columns[2].Width = 80;
            this.dataCategoria.Columns[3].Width = 50;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
            {
                dataCategoria.DataSource = bll.ListarEstudiante();
            }
            else
            {
                dataCategoria.DataSource = bll.ListarEstudiantesxNombre(txtBuscar.Text); 
            }
        }

     
   
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Panel_Agregar.Visible = false;
            this.btn_Actualizar.Enabled = true;
            this.btn_Nuevo.Enabled = true;
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.checkBox1.Checked = false;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (btn_Guardar.Text == "Guardar")
            {
                objCat.Nombres = txtNombre.Text;
                objCat.Estado = (this.checkBox1.Checked == true) ? true : false;

            try
                {
                    bll.Agregar(objCat);
                    MessageBox.Show("Se ha registrado una Nueva Categoria");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (btn_Guardar.Text == "Actualizar")
            {
                
                Estudiante categoria = bll.Buscar(Convert.ToInt32(txtId.Text));
                categoria.Nombres = txtNombre.Text;
                categoria.Estado = (this.checkBox1.Checked == true) ? true : false;

                try
                {
                    bll.Actualizar(categoria);
                    MessageBox.Show("Se ha Actualizado la Categoria");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            Panel_Agregar.Visible = false;
            dataCategoria.DataSource = bll.ListarEstudiante();
            this.btn_Actualizar.Enabled = true;
            this.btn_Nuevo.Enabled = true;

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
     
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Panel_Agregar.Visible = true;
            btn_Guardar.Text = "Actualizar";

            txtId.Text = dataCategoria.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataCategoria.CurrentRow.Cells[1].Value.ToString();
            if (dataCategoria.CurrentRow.Cells[2].Value is true)
            {
                this.checkBox1.Checked = true;
            }
            else
            {
                this.checkBox1.Checked = false;
            }

            this.btn_Actualizar.Enabled = false;
            this.btn_Nuevo.Enabled = false;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Panel_Agregar.Visible = true;
            this.btn_Actualizar.Enabled = false;
            this.btn_Nuevo.Enabled = false;
            btn_Guardar.Text = "Guardar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
