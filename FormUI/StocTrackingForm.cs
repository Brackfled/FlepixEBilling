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
    public partial class StocTrackingForm : Form
    {
        private readonly IProductService _productService;
        private  ProductCreatePopup _productCreatePopup;

        public StocTrackingForm(IProductService productService, ProductCreatePopup productCreatePopup)
        {
            _productService = productService;
            InitializeComponent();
            _productCreatePopup = productCreatePopup;


            lswProductList.Columns.Add("Ürün Id", 200);
            lswProductList.Columns.Add("Ürün İsmi", 200);
            lswProductList.Columns.Add("Birim Fiyatı", 200);
            lswProductList.Columns.Add("Stok Miktarı", 200);
            lswProductList.Columns.Add("İşlemler", 200);

        }
        
        private async void StocTrackingForm_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void btnCreateCurrent_Click(object sender, EventArgs e)
        {
            if(_productCreatePopup.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        public async void LoadData()
        {
            lswProductList.Items.Clear();
            ICollection<Product>? products = await _productService.GetListAsync();

            foreach (Product product in products)
            {
                ListViewItem item = new ListViewItem(product.Id.ToString());

                item.SubItems.Add(product.Name);
                item.SubItems.Add(product.UnitPrice.ToString());
                item.SubItems.Add(product.StockAmount.ToString());
                lswProductList.Items.Add(item);
            }
        }
    }
}
