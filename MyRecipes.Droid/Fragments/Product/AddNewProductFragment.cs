using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Shared.Attributes;
using MyRecipes.Core.ViewModels.Main;
using MyRecipes.Core.ViewModels.Product;
using MyRecipes.Droid.Fragments.Base;

namespace MyRecipes.Droid.Fragments.Product
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame)]
    [Register("myrecipes.droid.fragments.product.AddNewProductFragment")]
    public class AddNewProductFragment : BaseFragment<AddNewProductsViewModel>
    {
        private string _oldTitle;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ShowHamburgerMenu = true;
            _oldTitle = ((MainActivity)Activity).Title;
            ((MainActivity)Activity).Title = "Добавление продукта";
            return base.OnCreateView(inflater, container, savedInstanceState);
        }


        public override void OnDestroyView()
        {
            ((MainActivity)Activity).Title = _oldTitle;
            base.OnDestroyView();
        }

        public override void OnStop()
        {
            base.OnStop();
        }

        protected override int FragmentId => Resource.Layout.fragment_add_new_product;
    }
}