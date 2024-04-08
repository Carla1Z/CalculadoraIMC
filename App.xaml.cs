using CalculadoraIMC.MVVM.Views;

namespace CalculadoraIMC;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new IMCView();
	}
}
