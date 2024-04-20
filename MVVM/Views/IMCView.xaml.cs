using CalculadoraIMC.MVVM.ViewModels;

namespace CalculadoraIMC.MVVM.Views;

public partial class IMCView : ContentPage
{
	public IMCView()
	{
		InitializeComponent();
		BindingContext = new IMCViewModel();
	}
}