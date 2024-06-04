using Application.Services.CurrentService;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
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
    public partial class CurrentPopup : Form
    {
        private readonly ICurrentService _currentService;
        public Current _current = default!;
        public CurrentPopup(ICurrentService current)
        {
            _currentService = current;
            InitializeComponent();
            this.Load += CurrentPopup_Load;
        }

        private void CurrentPopup_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void dgwCurrents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgwCurrents.Rows[e.RowIndex];

            Guid currentId = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());

            Current? current = await _currentService.GetAsync(predicate: c => c.Id.Equals(currentId));
            this.DialogResult = DialogResult.OK;
            _current = current;
            
        }


        private async void LoadData()
        {
            ICollection<Current>? currents = await _currentService.GetListAsync(
                    include:c => c.Include(c => c.TaxDepartment),
                    withDeleted:true
                );
            dgwCurrents.DataSource = currents;

            foreach(DataGridViewColumn column in dgwCurrents.Columns)
            {
                if (column.Name != "CurrentCode" && column.Name != "CurrentName")
                    column.Visible = false;
            }
            dgwCurrents.Columns["CurrentName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
