using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas.UI
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }

              
        private void btn_Categorias_Click(object sender, EventArgs e)
        {
            Frm_Estudiante frm1 = new Frm_Estudiante();
            frm1.MdiParent = this;
            frm1.Show();
            

        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
           
            
        }

     

        private void btn_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
