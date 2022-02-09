using MobileApp.Views;
using Xamarin.Forms;

namespace MobileApp
{
	public partial class App
	{
		public App()
		{
			InitializeComponent();

			MainPage =  new Views.MyLocationPage();
		}

        protected override void OnStart()
        {
            base.OnStart();
			//Checkear permisos ubicación
        }
    }
}
