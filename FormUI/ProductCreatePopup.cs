using Application.Services.ProductService;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class ProductCreatePopup : Form
    {
        private readonly IProductService _productService;

        public ProductCreatePopup(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new()
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text,
                UnitPrice = double.Parse(txtUnitPrice.Text),
                StockAmount  = int.Parse(txtStockAmount.Text),
            };

            Product addedProduct = await _productService.AddAsync(product);
            DialogResult = DialogResult.OK;
            Close();
            
        }
    }
}
