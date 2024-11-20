namespace EjercicioEnClase;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
		InitializeComponent();
	}

    private void Boton2_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new FlexLayout());
    }
}