using Android.App;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views;

namespace MyRecipes.Droid.Views
{

    [Activity(Label = "���������� ��������")]
    public class AddNewProductView : MvxAppCompatActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Add_New_Product_Layout);
        }

    }
}