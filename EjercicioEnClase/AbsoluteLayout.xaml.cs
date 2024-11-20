namespace EjercicioEnClase;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();
	}

    private void BotonGrind_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}