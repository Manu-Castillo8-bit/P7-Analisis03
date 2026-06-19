using Microsoft.Extensions.DependencyInjection;

namespace P7_Analisis03
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new producto();
        }

        
    }
}