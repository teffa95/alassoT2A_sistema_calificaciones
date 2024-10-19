namespace alassoT2A
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuarioIngresado)
        {
            InitializeComponent();
        }

        private void OnCalcularNotasClicked(object sender, EventArgs e)
        {
            // Variables de entrada
            string nombre = txtNombre.Text;
            DateTime fecha = datePicker.Date;

            // Validar y convertir las notas ingresadas a números
            if (double.TryParse(txtSeguimiento1.Text, out double seguimiento1) &&
                double.TryParse(txtExamen1.Text, out double examen1) &&
                double.TryParse(txtSeguimiento2.Text, out double seguimiento2) &&
                double.TryParse(txtExamen2.Text, out double examen2))
            {
                // Validar que las notas estén en el rango de 0 a 10
                if (!EsNotaValida(seguimiento1) || !EsNotaValida(examen1) ||
                    !EsNotaValida(seguimiento2) || !EsNotaValida(examen2))
                {
                    DisplayAlert("Error", "Todas las notas deben estar entre 0 y 10", "OK");
                    return;
                }

                // Calcular las notas parciales y la nota final
                double notaParcial1 = (seguimiento1 * 0.3) + (examen1 * 0.2);
                double notaParcial2 = (seguimiento2 * 0.3) + (examen2 * 0.2);
                double notaFinal = notaParcial1 + notaParcial2;

                // Determinar el estado del estudiante
                string estado;
                if (notaFinal >= 7)
                {
                    estado = "Aprobado";
                }
                else if (notaFinal >= 5 && notaFinal < 7)
                {
                    estado = "Complementario";
                }
                else
                {
                    estado = "Reprobado";
                }

                // Mostrar los resultados
                lblResultado.Text = $"Nombre: {nombre}\n" +
                                    $"Fecha: {fecha.ToShortDateString()}\n" +
                                    $"Nota Parcial 1: {notaParcial1:F2}\n" +
                                    $"Nota Parcial 2: {notaParcial2:F2}\n" +
                                    $"Nota Final: {notaFinal:F2}\n" +
                                    $"Estado: {estado}";
            }
            else
            {
                DisplayAlert("Error", "Por favor, ingresa todas las notas correctamente.", "OK");
            }
        }

        // Función para validar que la nota esté en el rango de 0 a 10
        private bool EsNotaValida(double nota)
        {
            return nota >= 0 && nota <= 10;
        }
    }
}