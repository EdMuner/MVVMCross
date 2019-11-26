using Fibonacci.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace Fibonacci.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<FibonacciViewModel>();
        }
    }
}
