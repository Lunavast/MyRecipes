using Android.App;
using MvvmCross.Droid.Views;

namespace MyRecipes.Droid.Views
{

    [Activity(Label = "���������� ��������", MainLauncher = false)]
    public class AddNewProductView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Add_New_Product_Layout);
        }

    }
}