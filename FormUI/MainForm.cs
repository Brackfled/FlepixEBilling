using Application.Services.CurrentService;
using Application.Services.TaxDepartmentService;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class MainForm : Form
    {

        private readonly ITaxDepartmentService _taxDepartmentService;
        private readonly ICurrentService _currentService;
        private readonly IServiceProvider _serviceProvider;
        public MainForm(ITaxDepartmentService taxDepartmentService, ICurrentService currentService, IServiceProvider serviceProvider)
        {
            _taxDepartmentService = taxDepartmentService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void btnCurrentCreate_Click(object sender, EventArgs e)
        {
            ShowPanel(new CurrentCreateForm(_taxDepartmentService, _currentService));
        }

        private void ShowPanel(Form form)
        {
            pnlContent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.None;
            pnlContent.Controls.Add(form);
            form.Show();
        }
    }
}
