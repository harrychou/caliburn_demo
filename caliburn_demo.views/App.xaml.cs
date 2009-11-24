using Caliburn.PresentationFramework.ApplicationModel;
using caliburn_demo.wpf.ViewModels;

namespace caliburn_demo.wpf
{
    public partial class App : CaliburnApplication
    {
        public App()
        {
           // InitializeComponent();
        }

        protected override object CreateRootModel()
        {
            return new ShellViewModel();
        }
    }
}