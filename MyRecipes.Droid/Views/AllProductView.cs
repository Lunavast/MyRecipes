using Android.App;
using MvvmCross.Droid.Views;

namespace MyRecipes.Droid.Views
{
    
    [Activity(Label = "��������� ��������", MainLauncher = false)]
    public class AllProductView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.All_Product_Layout);
        }
    }
}