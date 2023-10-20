using CapaData;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmTrabajadorUsuarioNormal : Form
    {
        List<Trabajador> trabajadores;
        string operacion; //operaciones del crud

        int indice;

        public frmTrabajadorUsuarioNormal(string operacion)
        {
            InitializeComponent();
            this.operacion = operacion;
            CargarComboBoxs();
            trabajadores = Data.trabajadores;
        }

        private void frmTrabajadorUsuarioNormal_Load(object sender, EventArgs e)
        {
            if (operacion == "Consultar")
            {
                btnOperacion.Text = "Calcular";
                btnCancelar.Text = "Cerrar";
                lblOperacion.Text = "Consultar trabajador";
            }
            else if (operacion == "Actualizar")
            {
                btnOperacion.Text = "Guardar Cambios";
                btnCancelar.Text = "Cancelar";
                lblOperacion.Text = "Actualizar datos de trabajador";
            }

            lblSueldoBruto.Text = "";
            lblSueldoLiquido.Text = "";
        }

        private void txtRut_Leave(object sender, EventArgs e)
        {
            try
            {
                if (ExisteRut())
                {
                    for (int i = 0; i < trabajadores.Count; i++)
                    {
                        if (txtRut.Text == trabajadores[i].Rut)
                        {
                            txtHorasTrabajadas.Text = trabajadores[i].HorasTrabajadas.ToString();
                            txtHorasExtra.Text = trabajadores[i].HorasExtra.ToString();
                            cbxAfp.SelectedItem = trabajadores[i].Afp;
                            cbxSalud.SelectedItem = trabajadores[i].Salud;

                            CalcularSueldo();
                            //lblSueldoBruto.Text = Sueldo.SueldoBruto(trabajadores[i].HorasTrabajadas, trabajadores[i].HorasExtra).ToString();
                            //lblSueldoLiquido.Text = Sueldo.SueldoLiquido(trabajadores[i].HorasTrabajadas, trabajadores[i].HorasExtra, trabajadores[i].Afp, trabajadores[i].Salud).ToString();

                            if (operacion == "Actualizar")
                            {
                                indice = i;
                            }
                            break;
                        }
                    }
                }
                else
                {
                    txtHorasExtra.Text = "";
                    txtHorasTrabajadas.Text = "";
                    cbxAfp.Text = "";
                    cbxSalud.Text = "";
                    txtRut.Focus();
                    MessageBox.Show("No existe un trabajador con ese rut en nuestros registros", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al intentar calcular el sueldo, por favor revise la información contenida en el formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


        }



        private void btnOperacion_Click(object sender, EventArgs e)
        {
            switch (operacion)
            {
                case "Consultar": ConsultarTrabajador(); break;
                case "Actualizar": ActualizarTrabajador(); break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }

      

        


        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHorasTrabajadas_Leave(object sender, EventArgs e)
        {
            LeaveHoras(txtHorasTrabajadas);
        }

        private void txtHorasExtra_Leave(object sender, EventArgs e)
        {
            LeaveHoras(txtHorasExtra);
        }

        private void ConsultarTrabajador() { CalcularSueldo(); }

        private void ActualizarTrabajador()
        {
            trabajadores[indice].HorasTrabajadas = Convert.ToInt32(txtHorasTrabajadas.Text);
            trabajadores[indice].HorasExtra = Convert.ToInt32(txtHorasExtra.Text);
            trabajadores[indice].Afp = cbxAfp.Text;
            trabajadores[indice].Salud = cbxSalud.Text;
            MessageBox.Show("El trabajador se ha actualizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private bool ExisteRut()
        {
            foreach (var trabajador in trabajadores)
                if (txtRut.Text == trabajador.Rut) return true;
            return false;
        }

        private void CalcularSueldo()
        {
            try
            {
                if (txtHorasTrabajadas.Text == "") throw new HorasTrabajadasException("El campo Horas trabajadas debe contener un valor");
                if (txtHorasExtra.Text == "") throw new HorasExtraException("El campo Horas extra debe contener un valor");
                if (cbxAfp.Text == "") throw new AfpException("El campo Afp debe contener un valor");
                if (cbxSalud.Text == "") throw new SaludException("El campo Afp debe contener un valor");

                if (Convert.ToInt32(txtHorasTrabajadas.Text) > 9 * 22) throw new ArgumentOutOfRangeException("El valor maximo de horas trabajadas en un mes es 198 hrs ");
                if (Convert.ToInt32(txtHorasExtra.Text) > 9 * 8) throw new ArgumentOutOfRangeException("El valor máximo de horas extra es de 72 hrs");

                int horasTrabajadas = Convert.ToInt32(txtHorasTrabajadas.Text);
                int horasExtra = Convert.ToInt32(txtHorasExtra.Text);
                lblSueldoBruto.Text = Sueldo.SueldoBruto(horasTrabajadas, horasExtra).ToString("C0", CultureInfo.GetCultureInfo("es-CL"));
                lblSueldoLiquido.Text = Sueldo.SueldoLiquido(horasTrabajadas, horasExtra, cbxAfp.Text, cbxSalud.Text).ToString("C0", CultureInfo.GetCultureInfo("es-CL"));


            }
            catch (HorasTrabajadasException ex)
            {
                txtHorasTrabajadas.Focus();
                MessageBox.Show(ex.Message, "Valor nulo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (HorasExtraException ex)
            {
                txtHorasExtra.Focus();
                MessageBox.Show(ex.Message, "Valor nulo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (AfpException ex)
            {
                cbxAfp.Focus();
                MessageBox.Show(ex.Message, "Valor nulo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (SaludException ex)
            {
                cbxSalud.Focus();
                MessageBox.Show(ex.Message, "Valor nulo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message.Substring(74, ex.Message.Length - 74), "Excede Valor Máximo de horas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (FormatException)
            {
                MessageBox.Show("Escriba la cantidad de horas en un formato de número.", "Formato incorrecto.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void CargarComboBoxs()
        {
            foreach (string afp in SistemaPensiones.afp) cbxAfp.Items.Add(afp);
            foreach (string salud in SistemaSalud.prevision) cbxSalud.Items.Add(salud);
        }

        private void LeaveHoras(TextBox textBox)
        {
            //valida si no se puede convertir a int
            try
            {
                Convert.ToInt32(textBox.Text);
                
            }
            catch (FormatException)
            {
                textBox.Text = "";
                //textBox.Focus();
                MessageBox.Show("Escriba un numero", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarElementoLista(int indiceAEliminar)
        {
            trabajadores.RemoveAt(indiceAEliminar);
            MessageBox.Show("El trabajador ha sido removido de la base de datos", "Mensaje", MessageBoxButtons.OK);
            this.Close();
        }

    }
}


