using CapaData;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;


// Delegados y Eventos para DataGridView: https://www.youtube.com/watch?v=yeN7fGrR4Fg


namespace CapaPresentacion
{
    public partial class frmTrabajadorAdmin : Form
    {
        string afp;
        string salud;
        List<Trabajador> trabajadoresList = Data.trabajadores;
        string operacion; //operaciones del crud
        int indiceAEliminar;
        int indiceAActualizar;

        // 
        public frmTrabajadorAdmin(string crud)
        {
            operacion = crud;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (operacion)
            {
                case "Agregar": AgregarTrabajador(); break;
                case "Consultar": ConsultarTrabajador(); break;
                case "Actualizar": ActualizarTrabajador(); break;
                case "Eliminar": EliminarElementoLista(indiceAEliminar); break;
            }
        }

       
        private void cbxAfp_SelectedIndexChanged(object sender, EventArgs e)
        {
            afp = cbxAfp.Text;
        }

        private void cbxSalud_SelectedIndexChanged(object sender, EventArgs e)
        {
            salud = cbxSalud.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void frmTrabajador_Load(object sender, EventArgs e)
        {
            CargarComboBoxs();
            switch (operacion)
            {
                case "Agregar":
                    lblOperacion.Text = "Agregar trabajador";
                    btnGuardar.Text = "Guardar";
                    break;
                case "Consultar":
                    lblOperacion.Text = "Consultar trabajador";
                    btnGuardar.Text = "Aceptar";
                    txtNombre.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtTelefono.Enabled = false;
                    cbxAfp.Enabled = false;
                    cbxSalud.Enabled = false;
                    break;
                case "Actualizar":
                    lblOperacion.Text = "Actualizar datos de trabajador";
                    btnGuardar.Text = "Actualizar";
                    break;
                case "Eliminar":
                    lblOperacion.Text = "Eliminar trabajador";
                    btnGuardar.Text = "Eliminar";
                    txtNombre.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtTelefono.Enabled = false;
                    cbxAfp.Enabled = false;
                    cbxSalud.Enabled = false;
                    break;
            }
        }

        private void txtRut_Leave(object sender, EventArgs e)
        {
            try
            {

            if (operacion == "Agregar")
                if  (ValidarSiExisteRut()) {throw new InvalidOperationException("El trabajador ya existe en nuestros registros"); }
                else if (operacion == "Eliminar") BuscarPorOperacion("Eliminar");
                else if (operacion == "Actualizar") BuscarPorOperacion("Actualizar");
                else if (operacion == "Consultar") BuscarPorOperacion("Consultar");
            } catch (InvalidOperationException ex)
            {
                txtRut.Focus();
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }



        }



        private bool ValidarSiExisteRut()
        {
            bool existe = false;
            List<Trabajador> trabajadores = Data.trabajadores;
            for (int i = 0; i < trabajadores.Count; i++)
            {
                return txtRut.Text == trabajadores[i].Rut;
            }
            return existe;
        }

        private void BuscarPorOperacion(string operacion)
        {
            List<Trabajador> trabajadores = Data.trabajadores;
            int contador = 0;
            foreach (Trabajador trabajador in trabajadores)
            {
                if (txtRut.Text == trabajador.Rut)
                {
                    txtNombre.Text = trabajador.Nombre;
                    txtDireccion.Text = trabajador.Direccion;
                    txtTelefono.Text = trabajador.Telefono;
                    cbxAfp.SelectedItem = trabajador.Afp;
                    cbxSalud.SelectedItem = trabajador.Salud;
                    switch (operacion)
                    {
                        case "Eliminar": indiceAEliminar = contador; break;
                        case "Actualizar": indiceAActualizar = contador; break;
                        case "Consultar": break;
                    }
                    break;
                }
                contador++;
            }

        }

        //: Metodos

        //Agrega un trabajador con sus campos de datos personales correspondientes, con 
        private void AgregarTrabajador()
        {
            try
            {
                if (txtRut.Text == "") throw new ArgumentException("Rut debe contener un valor");
                if (txtNombre.Text == "") throw new ArgumentException("Nombre debe contener un valor");
                if (txtDireccion.Text == "") throw new ArgumentException("Dirección debe contener un valor");
                if (txtTelefono.Text == "") throw new ArgumentException("Teléfono debe contener un valor");
                if (cbxAfp.Text == "") throw new ArgumentException("Afp debe contener un valor");
                if (cbxSalud.Text == "") throw new ArgumentException("Salud debe contener un valor");


                Trabajador trabajadorAAgregar = new Trabajador(txtRut.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, cbxAfp.Text, cbxSalud.Text, 0, 0);

                //Agregar trabajador a la lista trabajadoresList
                trabajadoresList.Add(trabajadorAAgregar);
                MessageBox.Show("El trabajador ha sido añadido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }

        }

        private void CargarComboBoxs()
        {
            foreach (string afp in SistemaPensiones.afp) cbxAfp.Items.Add(afp);
            foreach (string salud in SistemaSalud.prevision) cbxSalud.Items.Add(salud);
        }

        private void ActualizarTrabajador()
        {
            //logica de actualizar un registro
            List<Trabajador> trabajadores = Data.trabajadores;
            trabajadores[indiceAActualizar].Nombre = txtNombre.Text;
            trabajadores[indiceAActualizar].Direccion = txtDireccion.Text;
            trabajadores[indiceAActualizar].Telefono = txtTelefono.Text;
            trabajadores[indiceAActualizar].Afp = cbxAfp.Text;
            trabajadores[indiceAActualizar].Salud = cbxSalud.Text;
            MessageBox.Show("El trabajador se ha actualizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void ConsultarTrabajador() { this.Close(); }

        private void EliminarElementoLista(int indiceAEliminar)
        {
            trabajadoresList.RemoveAt(indiceAEliminar);
            MessageBox.Show("El trabajador ha sido removido de la base de datos", "Mensaje", MessageBoxButtons.OK);
            this.Close();
        }


    }
}
