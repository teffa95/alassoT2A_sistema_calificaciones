using alassoT2A.SistemaCalificacionesMaui;

namespace alassoT2A.Views;

    public partial class LoginPage : ContentPage
{
    // Definir los vectores de usuarios y contrase�as
    string[] usuarios = { "Carlos", "Ana", "Jose" };
    string[] contrase�as = { "carlos123", "ana123", "jose123" };

    public LoginPage()
    {
        InitializeComponent();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        // Obtener los datos ingresados por el usuario
        string usuarioIngresado = txtUsuario.Text;
        string contrase�aIngresada = txtPassword.Text;

        // Validar las credenciales
        bool credencialesCorrectas = false;
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarioIngresado == usuarios[i] && contrase�aIngresada == contrase�as[i])
            {
                credencialesCorrectas = true;
                // Redirigir al usuario a la p�gina principal
                Navigation.PushAsync(new MainPage(usuarioIngresado));
                break;
            }
        }

        // Mostrar mensaje de error si las credenciales no son correctas
        if (!credencialesCorrectas)
        {
            lblMensaje.Text = "Usuario o contrase�a incorrectos.";
            lblMensaje.IsVisible = true;
        }
    }
}
