
using Android.App;
using Android.OS;
using Fibonacci.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace Fibonacci.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class FibonacciView : MvxActivity<FibonacciViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.FibonacciPage);
        }
    }
}