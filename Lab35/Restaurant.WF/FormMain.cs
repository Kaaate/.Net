using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant.Bl.Abstract.IServices;
using Restaurant.Bl.Impl.Mappers;
using Restaurant.Bl.Impl.Services;
using Restaurant.Dal.Ef.Postgres;
using Restaurant.Dal.Ef.Postgres.Repository;
using Restaurant.Entities;
using Restaurant.Models;

namespace Restaurant
{
    public partial class FormMain : Form
    {

        private List<RestaurantModel> _RestaurantModels;
        private readonly IRestaurantService _RestaurantService = new RestaurantService(new RestaurantMapper(), new RestaurantRepository());

        public FormMain()
        {
            InitializeComponent();
            Update();
        }

        private async void buttonAddRestaurant_Click(object sender, EventArgs e)
        {
            await _RestaurantService.Create(new RestaurantModel()
            {
                Name = textBoxNameBakerie.Text,
                Address = textBoxAddressBakerie.Text,
            });
            Update();
        }

        private new async void Update()
        {
            listBoxRestaurant.Items.Clear();
            _RestaurantModels = await _RestaurantService.GetAll();
            foreach (RestaurantModel model in _RestaurantModels)
            {
                listBoxRestaurant.Items.Add(model);
            }
        }

        private async void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            await _RestaurantService.DeleteById(((RestaurantModel)listBoxRestaurant.SelectedItem).Id);
            Update();
        }


        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout createForm = new FormAbout();
            createForm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void buttonDishManagement_Click(object sender, EventArgs e)
        {
            FormDishManagement createForm = new FormDishManagement((RestaurantModel)listBoxRestaurant.SelectedItem);
            createForm.ShowDialog();
        }

        private void buttonIngradientManagement_Click(object sender, EventArgs e)
        {
            FormIngradientsManagement createForm = new FormIngradientsManagement();
            createForm.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ((Control) this).Update();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {

        }
    }
}
