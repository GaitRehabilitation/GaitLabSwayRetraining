using MvvmCross;
using MvvmCross.ViewModels;
using PartialSway.Services;
using PartialSway.ViewModels;

namespace PartialSway
{
    public class BaseApp : MvxApplication
    {

        public override void Initialize()
        {
            RegisterAppStart<MainPageViewModel>();

            Mvx.IoCProvider.RegisterSingleton< IBluetoothService>(new BluetoothService());

            base.Initialize();
        }
    }
}
