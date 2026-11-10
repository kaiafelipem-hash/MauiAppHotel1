namespace MauiAppHotel1.Views;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }

    private async void btn_avancar_Clicked(object sender, EventArgs e)
    {
        // Abre a tela HospedagemContratada ao clicar no botão
        await Navigation.PushAsync(new MauiAppHotel1.Views.HospedagemContratada());
    }
}
