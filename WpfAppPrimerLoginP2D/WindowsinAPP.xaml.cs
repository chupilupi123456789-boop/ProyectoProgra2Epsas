using System;
using System.IO;
using System.Windows;

namespace WpfAppPrimerLoginP2D
{
    public partial class WindowsinAPP : Window
    {
        string rutaArchivo = "c:\\DatosPersonales\\usuariosSignUp.txt";

        public WindowsinAPP()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtCI.Clear();
            txtContrasenaRegistro.Clear();
            txtNombre.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtCargo.Clear();
            txtDepartamento.Clear();
            txtTipoContrato.Clear();
            txtFechaIngreso.Clear();
            txtNivelAcademico.Clear();
            txtExperiencia.Clear();
            txtResultado.Text = "";
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Crear objeto Contrato
                Contrato contrato = new Contrato
                {
                    Cargo = txtCargo.Text,
                    Departamento = txtDepartamento.Text,
                    TipoContrato = txtTipoContrato.Text,
                    FechaIngreso = txtFechaIngreso.Text
                };

                // Crear Horario
                Horario horario = new Horario
                {
                    HoraEntrada = "08:00",
                    HoraSalida = "16:00",
                    DiasTrabajo = "Lunes a Viernes"
                };

                // Crear Rol
                Rol rol = new Rol
                {
                    NombreRol = "Empleado",
                    Descripcion = "Rol básico del sistema"
                };

                // Crear objeto Empleado
                Empleado emp = new Empleado
                {
                    CI = txtCI.Text,
                    Contrasena = txtContrasenaRegistro.Password,
                    Nombre = txtNombre.Text,
                    ApPaterno = txtApPaterno.Text,
                    ApMaterno = txtApMaterno.Text,
                    Email = txtEmail.Text,
                    Telefono = txtTelefono.Text,
                    DatosContrato = contrato,
                    DatosHorario = horario,
                    Puesto = rol,
                    NivelAcademico = txtNivelAcademico.Text,
                    Experiencia = txtExperiencia.Text
                };

                // Guardar en archivo
                GuardarEnArchivo(emp);

                MessageBox.Show("Empleado registrado con éxito.");
                txtResultado.Text = "Registro completado.";
                btnLimpiar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            LoginEmpleado login = new LoginEmpleado();
            login.Show();
            this.Close();
        }

        // Método para guardar todo en archivo
        private void GuardarEnArchivo(Empleado emp)
        {
            string empleado =
                "Código (CI): " + emp.CI + "\n" +
                "Contraseña: " + emp.Contrasena + "\n" +
                "Nombre Completo: " + emp.NombreCompleto + "\n" +
                "Correo: " + emp.Email + "\n" +
                "Teléfono: " + emp.Telefono + "\n" +

                "Cargo: " + emp.DatosContrato.Cargo + "\n" +
                "Departamento: " + emp.DatosContrato.Departamento + "\n" +
                "Tipo de Contrato: " + emp.DatosContrato.TipoContrato + "\n" +
                "Fecha Ingreso: " + emp.DatosContrato.FechaIngreso + "\n" +

                "Rol: " + emp.Puesto.NombreRol + "\n" +
                "Descripción Rol: " + emp.Puesto.Descripcion + "\n" +

                "Hora Entrada: " + emp.DatosHorario.HoraEntrada + "\n" +
                "Hora Salida: " + emp.DatosHorario.HoraSalida + "\n" +
                "Días de Trabajo: " + emp.DatosHorario.DiasTrabajo + "\n" +

                "Nivel Académico: " + emp.NivelAcademico + "\n" +
                "Experiencia: " + emp.Experiencia + "\n" +

                "-----------------------------\n";

            Directory.CreateDirectory("c:\\DatosPersonales");
            File.AppendAllText(rutaArchivo, empleado);
        }
    }
}
