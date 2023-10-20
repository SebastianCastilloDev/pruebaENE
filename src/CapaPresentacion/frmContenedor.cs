using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaData;
using System.Globalization;
using CapaNegocios;
namespace CapaPresentacion
{
    public partial class frmContenedor : Form
    {
        private List<string> crud = new List<string> { "Agregar", "Consultar","Actualizar","Eliminar" };

        private List<Trabajador> trabajadores;
        private static Usuario usuarioActual;
        private static ToolStripMenuItem menuActivo = null;
        private static Form formularioActivo = null;
        //private frmContenedor EsteFormulario;
        public frmContenedor(Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
            //EsteFormulario = this;
        }

        private void frmContenedor_Load(object sender, EventArgs e)
        {
            CargarDataGridView();
            lblUsuario.Text = usuarioActual.Nombre;
            lblRol.Text = usuarioActual.Rol;
            if (usuarioActual.Rol != "Admin")
            {
                administradorMenu.Enabled = false;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void agregarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnContenedor(administradorMenu, new frmTrabajadorAdmin(crud[0]));
            CargarDataGridView();
        }

        private void consultarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnContenedor(administradorMenu, new frmTrabajadorAdmin(crud[1]));
            CargarDataGridView();
        }

        private void actualizarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnContenedor(administradorMenu, new frmTrabajadorAdmin(crud[2]));
            CargarDataGridView();
        }

        private void eliminarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnContenedor(administradorMenu, new frmTrabajadorAdmin(crud[3]));
            CargarDataGridView();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private void consultarTrabajadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnContenedor(usuarioNormalMenu, new frmTrabajadorUsuarioNormal(crud[1]));
            CargarDataGridView();
        }

        private void editarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnContenedor(usuarioNormalMenu, new frmTrabajadorUsuarioNormal(crud[2]));
            CargarDataGridView();
        }

        //Metodos
        public void CargarDataGridView()
        {
            dataGridViewTrabajadores.Rows.Clear();
            trabajadores = Data.trabajadores;
            foreach (var trabajador in trabajadores)
            {
                int n = dataGridViewTrabajadores.Rows.Add();
                dataGridViewTrabajadores.Rows[n].Cells[0].Value = trabajador.Rut;
                dataGridViewTrabajadores.Rows[n].Cells[1].Value = trabajador.Nombre;
                dataGridViewTrabajadores.Rows[n].Cells[2].Value = trabajador.Direccion;
                dataGridViewTrabajadores.Rows[n].Cells[3].Value = trabajador.Afp;
                dataGridViewTrabajadores.Rows[n].Cells[4].Value = trabajador.Salud;
                dataGridViewTrabajadores.Rows[n].Cells[5].Value = trabajador.HorasTrabajadas;
                dataGridViewTrabajadores.Rows[n].Cells[6].Value = trabajador.HorasExtra;
                dataGridViewTrabajadores.Rows[n].Cells[7].Value = Sueldo.SueldoBruto(trabajador.HorasTrabajadas, trabajador.HorasExtra);
                dataGridViewTrabajadores.Rows[n].Cells[8].Value = Sueldo.SueldoLiquido(trabajador.HorasTrabajadas, trabajador.HorasExtra,trabajador.Afp, trabajador.Salud);

                dataGridViewTrabajadores.Columns[7].DefaultCellStyle.Format = "c";
                dataGridViewTrabajadores.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CL");

                dataGridViewTrabajadores.Columns[8].DefaultCellStyle.Format = "c";
                dataGridViewTrabajadores.Columns[8].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-CL");
            }
        }


  
        private void AbrirFormularioEnContenedor(ToolStripMenuItem menu, Form formulario)
        {
            menuActivo = menu;
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            contenedor.Controls.Add(formulario);
            formulario.Show();
            CargarDataGridView();
        }








        //private void AbrirFormularioEnContenedor2(ToolStripMenuItem menu, frmContenedor formulario)
        //{
        //    menuActivo = menu;
        //    if (formularioActivo != null)
        //        formularioActivo.Close();
        //    formularioActivo = formulario;
        //    formulario.TopLevel = false;
        //    formulario.FormBorderStyle = FormBorderStyle.None;
        //    formulario.Dock = DockStyle.Fill;
        //    contenedor.Controls.Add(formulario);
        //    formulario.Show();
        //    CargarDataGridView();
        //}


        //private void AgreUpdateEventHandler(object sender, frmTrabajador.UpdateEventArgs args)
        //{
        //    CargarDataGridView();
        //}


    }
}
