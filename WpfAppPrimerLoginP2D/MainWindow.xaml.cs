using System;
using System.IO;
using System.Windows;

namespace WpfAppPrimerLoginP2D
{
    public partial class LoginEmpleado : Window
    {
        string rutaArchivo = "c:\\DatosPersonales\\usuariosSignUp.txt";

        public LoginEmpleado()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            string ci = txtCI.Text;
            string pass = txtContrasena.Password;

            if (!File.Exists(rutaArchivo))
            {
                txtResultado.Text = "No hay usuarios registrados.";
                return;
            }

            string[] lineas = File.ReadAllLines(rutaArchivo);

            for (int i = 0; i < lineas.Length; i++)
            {
                if (lineas[i].StartsWith("Código (CI):"))
                {
                    string ciGuardado = lineas[i].Replace("Código (CI): ", "");
                    string passGuardada = lineas[i + 1].Replace("Contraseña: ", "");
                    string nombreCompleto = lineas[i + 2].Replace("Nombre Completo: ", "");

                    if (ci == ciGuardado && pass == passGuardada)
                    {
                        Empleado emp = new Empleado
                        {
                            CI = ciGuardado,
                            Contrasena = passGuardada,
                            Nombre = nombreCompleto
                        };

                        MessageBox.Show("Bienvenido " + emp.Nombre);
                        txtResultado.Text = "Acceso permitido.";
                        return;
                    }
                }
            }

            txtResultado.Text = "CI o contraseña incorrectos.";
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            WindowsinAPP registro = new WindowsinAPP();
            registro.Show();
            this.Close();
        }
    }
}
