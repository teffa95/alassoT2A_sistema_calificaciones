using alassoT2A.SistemaCalificacionesMaui;

namespace alassoT2A.Views;

    public partial class LoginPage : ContentPage
{
    // Definir los vectores de usuarios y contraseñas
    string[] usuarios = { "Carlos", "Ana", "Jose" };
    string[] contraseñas = { "carlos123", "ana123", "jose123" };

    public LoginPage()
    {
        InitializeComponent();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        // Obtener los datos ingresados por el usuario
        string usuarioIngresado = txtUsuario.Text;
        string contraseñaIngresada = txtPassword.Text;

        // Validar las credenciales
        bool credencialesCorrectas = false;
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarioIngresado == usuarios[i] && contraseñaIngresada == contraseñas[i])
            {
                credencialesCorrectas = true;
                // Redirigir al usuario a la página principal
                Navigation.PushAsync(new MainPage(usuarioIngresado));
                break;
            }
        }

        // Mostrar mensaje de error si las credenciales no son correctas
        if (!credencialesCorrectas)
        {
            lblMensaje.Text = "Usuario o contraseña incorrectos.";
            lblMensaje.IsVisible = true;
        }
    }
}
