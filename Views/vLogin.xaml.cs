namespace emoralesTarea2.Views;

public partial class vLogin : ContentPage
{
    public vLogin()
    {
        InitializeComponent();
    }
    private void btnInicio_Clicked(object sender, EventArgs e)
    { 
    // Definir un vector para almacenar nombres de usuario
        string[] usuario = { "carlos", "ana", "jose" };

    // Definir un vector para almacenar contrase�as correspondientes
    string[] contrasena = { "carlos123", "ana123", "jose123" };

    // Solicitar al usuario que ingrese su nombre de usuario
    Console.Write("Ingrese su nombre de usuario: ");
        string usuarioIngresado = txtUsuario.Text;

    // Solicitar al usuario que ingrese su contrase�a
    Console.Write("Ingrese su contrase�a: ");
        string contrasenaIngresada = txtContrase�a.Text;

    // Verificar si el usuario y la contrase�a coinciden
    bool usuarioValido = false;
        for (int i = 0; i<usuario.Length; i++)
        {
            if (usuario[i] == usuarioIngresado && contrasena[i] == contrasenaIngresada)
            {
                Navigation.PushAsync(new vHome(usuarioIngresado));
                break;
            }
        }
        // Mostrar mensaje seg�n la validaci�n
        if (usuarioValido)
        {
            DisplayAlert("Alerta", "Inicio de sesi�n exitoso", "OK");

        }
        else
        {
            DisplayAlert("ALERTA", "USUARIO Y CONTRASE�A SON INCORRECTOS", "OK");
            
        }

    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());
    }
}