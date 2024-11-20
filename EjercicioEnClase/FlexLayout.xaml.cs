namespace EjercicioEnClase;

public partial class FlexLayout : ContentPage
{
	public FlexLayout()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AbsoluteLayout());
    }
}