namespace alassoT2A
{
    using System;
    using Microsoft.Maui.Controls;

    namespace SistemaCalificacionesMaui
    {
        public partial class MainPage : ContentPage
        {
            private object lblResultado;

            public MainPage(string nombreUsuario)
            {
                InitializeComponent();

                // Cambiar el título y mostrar un mensaje de bienvenida
                this.Title = "Sistema de Calificaciones";
                lblResultado.Text = $"Bienvenido, {nombreUsuario}";
            }
        }
    }
}
