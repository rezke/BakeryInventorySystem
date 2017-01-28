using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DAL.Models;
using System.Data.Entity;
using BakeryInventorySystem.ViewModels;

namespace BakeryInventorySystem.UserControls
{
    public partial class ucItems : UserControl
    {
        private static ucItems _instance;
        BakeryContext _context;
        BindingSource ingredientsBindingSource = new BindingSource();       
        List<IngredientViewModel> _ingredientsViewModel;

        public static ucItems Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucItems();
                return _instance;
            }
        }

        public ucItems()
        {
            InitializeComponent();
            _context = new BakeryContext();
            _ingredientsViewModel = _context.Ingredients.Select(o => new IngredientViewModel()
            { Name = o.Name, Id = o.Id }).ToList();

            ingredientsBindingSource.DataSource = _ingredientsViewModel;
            dgvIngredients.DataSource = ingredientsBindingSource;
            dgvIngredients.Columns[0].Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = new Ingredient();
            _context.Ingredients.Load();

            ingredient.Name = this.tbName.Text;
            _context.Ingredients.Add(ingredient);
            _context.SaveChanges();
            tbName.Clear();

            refreshDataGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {    
            
            int id = (int) dgvIngredients.CurrentRow.Cells[0].Value;
            Ingredient ingredient = _context.Ingredients.Find(id);
            Ingredient newIngredient = new Ingredient();
            newIngredient.Name = tbName.Text;
            newIngredient.Id = ingredient.Id;

            if (ingredient != null)
            {
                _context.Entry(ingredient).CurrentValues.SetValues(newIngredient);
                _context.SaveChanges();
            }
            tbName.Clear();
            refreshDataGridView();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int id = (int)dgvIngredients.CurrentRow.Cells[0].Value;
            Ingredient ingredient = _context.Ingredients.Find(id);
            _context.Ingredients.Remove(ingredient);
            _context.SaveChanges();

            refreshDataGridView();
            tbName.Clear();

        }

        private void refreshDataGridView()
        {
            _ingredientsViewModel = _context.Ingredients.Select(o => new IngredientViewModel()
            { Name = o.Name, Id = o.Id }).ToList();

            ingredientsBindingSource.DataSource = _ingredientsViewModel;
            ingredientsBindingSource.ResetBindings(true);
            dgvIngredients.Refresh();
        }
    }
}
