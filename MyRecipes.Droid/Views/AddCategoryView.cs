using Android.App;
using MvvmCross.Droid.Views;

namespace MyRecipes.Droid.Views
{
    [Activity(Label = "���������� ���������", MainLauncher = false)]
    public class AddCategoryView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Add_Category_Layout);
        }
    }
}