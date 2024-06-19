namespace emoralesTarea2.Views;

public partial class vLogin : ContentPage
{
    public vLogin()
    {
        InitializeComponent();
    }
    string user;
    string password;

    public vLogin(string usuario, string contrasena)
    {
        InitializeComponent();
        user = usuario;
        password = contrasena;

    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        if (user == txtUsuario.Text && password == txtContraseña.Text)
        {
            Navigation.PushAsync(new vHome(user));
        }
        else
        {
            DisplayAlert("ALERTA", "USUARIO Y CONTRASEÑA SON INCORRECTOS", "OK");
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());
    }
}