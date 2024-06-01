using Application.Services.CurrentService;
using Application.Services.TaxDepartmentService;
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
    public partial class CurrentCreateForm : Form
    {

        private readonly ITaxDepartmentService _taxDepartmentService;
        private readonly ICurrentService _currentService;
        public CurrentCreateForm(ITaxDepartmentService taxDepartmentService, ICurrentService currentService)
        {
            _taxDepartmentService = taxDepartmentService;
            _currentService = currentService;
            InitializeComponent();
        }


        private string GenerateCurrentCode()
        {
            if (!rdBuyer.Checked || !rdSeller.Checked || !rdBuyerSeller.Checked)
                MessageBox.Show("Kart Tipi Seçili Değil!");

            return "";
        }

        private void btnCreateCurrentCode_Click(object sender, EventArgs e)
        {
            GenerateCurrentCode();
        }
    }
}
