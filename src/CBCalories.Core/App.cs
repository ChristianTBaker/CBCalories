using MvvmCross.IoC;
using MvvmCross.ViewModels;
using CBCalories.Core.ViewModels.Home;

namespace CBCalories.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
