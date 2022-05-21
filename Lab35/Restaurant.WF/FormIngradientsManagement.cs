using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Restaurant.Bl.Abstract.IServices;
using Restaurant.Bl.Impl.Mappers;
using Restaurant.Bl.Impl.Services;
using Restaurant.Dal.Ef.Postgres.Repository;
using Restaurant.Entities;
using Restaurant.Models;

namespace Restaurant
{
    public partial class FormIngradientsManagement : Form
    {
        private List<IngredientModel> _ingredientsModels;
        private readonly IIngredientService _ingredientService = new IngredientService(new IngredientMapper(), new IngredientRepository());
        public FormIngradientsManagement()
        {
            InitializeComponent();
            UpdateIngredients();
        }

        private void FormIngradientsManagement_Load(object sender, EventArgs e)
        {

        }

        private async void buttonAddIngradient_Click(object sender, EventArgs e)
        {
            await _ingredientService.Create(new IngredientModel()
            {
                Name = textBoxName.Text,
                Description = textBoxDescription.Text,
            });
            UpdateIngredients();
        }

        private async void UpdateIngredients()
        {
            listBoxIngradients.Items.Clear();
            _ingredientsModels = await _ingredientService.GetAll();
            foreach (IngredientModel model in _ingredientsModels)
            {
                listBoxIngradients.Items.Add(model);
            }
        }

        private async void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            await _ingredientService.DeleteById(((IngredientModel)listBoxIngradients.SelectedItem).Id);
            UpdateIngredients();
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateIngredients();
        }
    }
}
