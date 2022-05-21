using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant.Bl.Abstract.IServices;
using Restaurant.Bl.Impl.Mappers;
using Restaurant.Bl.Impl.Services;
using Restaurant.Dal.Ef.Postgres.Repository;
using Restaurant.Entities;
using Restaurant.Models;

namespace Restaurant
{
    public partial class FormDishManagement : Form
    {
        private readonly RestaurantModel _Restaurant;
        private List<IngredientModel> _ingredientModels;
        private List<DishModel> _dishModels;
        private readonly IDishService _dishService = new DishService(new DishMapper(), new DishRepository());
        private readonly IIngredientService _ingredientService = new IngredientService(new IngredientMapper(), new IngredientRepository());
        public FormDishManagement(RestaurantModel Restaurant)
        {
            _Restaurant = Restaurant;
            InitializeComponent();
            Update();
        }
        private async void FormDishManagement_Load(object sender, EventArgs e)
        {
        }

        private async void Update()
        {
            await UpdateDish();
            await UpdateIngredients();
        }

        private async Task UpdateDish()
        {
            listBoxDish.Items.Clear();
            _dishModels = await _dishService.GetAll(_Restaurant.Id);
            foreach (DishModel model in _dishModels)
            {
                listBoxDish.Items.Add(model);
            }
        }

        private async Task UpdateIngredients()
        {
            listBoxIngradients.Items.Clear();
            _ingredientModels = await _ingredientService.GetAll();
            foreach (IngredientModel model in _ingredientModels)
            {
                listBoxIngradients.Items.Add(model);
            }
        }

        private async void buttonAddDish_Click(object sender, EventArgs e)
        {
            await _dishService.Create(new DishModel()
            {
                Name = textBoxNameDish.Text,
                Recipe = textBoxRecipeDish.Text,
                RestaurantId = _Restaurant.Id,
                Price = 0,
            });
            UpdateDish();
        }

        private async void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            await _dishService.DeleteById(((DishModel) listBoxDish.SelectedItem).Id);
            UpdateDish();
        }

        private void buttonAddIngradient_Click(object sender, EventArgs e)
        {
            listBoDishIngradients.Items.Add(listBoxIngradients.SelectedItem);
        }

        private void buttonRemoveIngradient_Click(object sender, EventArgs e)
        {
            listBoDishIngradients.Items.Remove(listBoDishIngradients.SelectedItem);
        }

        private void listBoxDish_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private async void listBoxDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ingredientModels = await _ingredientService.GetAll();

            var dish = (DishModel)listBoxDish.SelectedItem;
            listBoDishIngradients.Items.Clear();
            
            foreach (IngredientModel ingredient in _ingredientModels)
            {
                listBoDishIngradients.Items.Add(ingredient);
            }

            textBoxNameDish.Text = dish.Name;
            textBoxRecipeDish.Text = dish.Recipe;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateDish();
        }

        private void listBoxIngradients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
