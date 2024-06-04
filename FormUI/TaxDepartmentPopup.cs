using Application.Services.TaxDepartmentService;
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
    public partial class TaxDepartmentPopup : Form
    {
        private readonly ITaxDepartmentService _taxDepartmentService;
        public TaxDepartment TaxDepartment = default!;
        public TaxDepartmentPopup(ITaxDepartmentService taxDepartmentService)
        {
            _taxDepartmentService = taxDepartmentService;
            InitializeComponent();
            LoadData();
        }

        public async void LoadData()
        {
            ICollection<TaxDepartment>? taxDepartments = await _taxDepartmentService.GetListAsync();
            dgwTaxDepartments.DataSource = taxDepartments;
            dgwTaxDepartments.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgwTaxDepartments.Columns["Code"].Visible = false;
            dgwTaxDepartments.Columns["Id"].Visible = false;
            dgwTaxDepartments.Columns["CreatedDate"].Visible = false;
            dgwTaxDepartments.Columns["DeletedDate"].Visible = false;
            dgwTaxDepartments.Columns["UpdatedDate"].Visible = false;
        }

        private async void dgwTaxDepartments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selecetedRow = dgwTaxDepartments.Rows[e.RowIndex];

            int taxDepartmentId = (int)selecetedRow.Cells["Id"].Value;

            TaxDepartment? taxDepartment = await _taxDepartmentService.GetAsync(td => td.Id.Equals(taxDepartmentId));
            TaxDepartment = taxDepartment;
            this.DialogResult = DialogResult.OK;
            

        }
    }
}
