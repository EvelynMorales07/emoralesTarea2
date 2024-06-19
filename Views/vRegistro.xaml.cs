namespace emoralesTarea2.Views;

public partial class vRegistro : ContentPage
{
    public vRegistro()
    {
        InitializeComponent();
    }

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasena = txtContrasena.Text;
        DisplayAlert("ALERTA", "USUARIO GUARDADO", "OK");
        Navigation.PushAsync(new vLogin(usuario, contrasena));
    }

    private void btnCancelar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vLogin());
    }
}