﻿using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MyRecipes.Core.Model;
using MyRecipes.Core.MvvmCrossExtension.Command;
using MyRecipes.Core.MvvmCrossExtension.ViewModels;
using MyRecipes.Core.Services;

namespace MyRecipes.Core.ViewModels
{
    public class AddCategoryViewModel : ParameterizedViewModel
    {
        private readonly IDbService _dbService;

        public AddCategoryViewModel(IDbService dbService)
        {
            _dbService = dbService;
            NewCategory = new Category();
            TitleNewCategory = "";

        }

        private Category _newCategory;
        public Category NewCategory
        {
            get { return _newCategory; }
            set { _newCategory = value; RaisePropertyChanged(() => NewCategory);}
        }


        private string _titleNewCategory;

        public string TitleNewCategory
        {
            get { return _titleNewCategory; }
            set { _titleNewCategory = value; RaisePropertyChanged(()=>TitleNewCategory); }
        }


        public override void Init(Parameters parameters)
        {
            
        }


        public ICommand AddNewCategoryCommand
        {
            get
            {
                return new MvxRelayCommand(AddNewCategory);
            }
        }

        private void AddNewCategory()
        {
            if (!string.IsNullOrEmpty(TitleNewCategory))
            {
                //NewCategory = new Category();
                NewCategory.Title = TitleNewCategory;
                _dbService.InsertItem<Category>(NewCategory);
                ShowViewModel<CategoryViewModel>();
            }
        }
    }
}
