using Application.Services.CurrentService;
using Application.Services.TaxDepartmentService;
using Domain.Entities;
using Domain.Enums;
using FormUI.Extensions;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormUI
{
    public partial class CurrentCreateForm : Form
    {

        private readonly ITaxDepartmentService _taxDepartmentService;
        private readonly ICurrentService _currentService;
        private TaxDepartmentPopup _taxDepartmentPopup;
        private CurrentPopup _currentPopup;
        public Current selectedCurrent { get; set; } = default!;
        public TaxDepartment selectedTaxDepartment { get; set; } = default!;
        public CurrentCreateForm(ITaxDepartmentService taxDepartmentService, ICurrentService currentService, TaxDepartmentPopup taxDepartmentPopup, CurrentPopup currentPopup)
        {
            _currentPopup = currentPopup;
            _taxDepartmentService = taxDepartmentService;
            _currentService = currentService;
            InitializeComponent();
            lblCheckedCurrentCode.Visible = false;
            _taxDepartmentPopup = taxDepartmentPopup;
        }


        private async void btnCreateCurrentCode_Click(object sender, EventArgs e)
        {
            CurrentType currentType = CheckCurrentType();
            string currentCode = await GenerateCurrentCode(currentType);
            txtCurrentCode.Text = currentCode;
            lblCheckedCurrentCode.Image = Properties.Resources._1398911_correct_mark_success_tick_valid_icon;
            lblCheckedCurrentCode.Visible = true;
        }

        private async void btnSearchCurrentCode_Click(object sender, EventArgs e)
        {
            string txtCurrentCodeText = txtCurrentCode.Text;
            ICollection<Current>? currents = await _currentService.GetListAsync(withDeleted: true);

            foreach (Current current in currents)
            {
                if (current.CurrentCode == txtCurrentCodeText)
                {
                    MessageBox.Show("Cari Kod Kullanımda!");
                    lblCheckedCurrentCode.Image = Properties.Resources._282471_cross_remove_delete_icon;
                    lblCheckedCurrentCode.Visible = true;

                }
                lblCheckedCurrentCode.Image = Properties.Resources._1398911_correct_mark_success_tick_valid_icon;
            }
        }

        private void btnSearchTaxDepartments_Click(object sender, EventArgs e)
        {
            if (_taxDepartmentPopup.ShowDialog() == DialogResult.OK)
            {
                selectedTaxDepartment = _taxDepartmentPopup.TaxDepartment;
                txtTaxDepartmentName.Text = selectedTaxDepartment.Name;

            }
        }

        private async void btnCreateCurrent_Click(object sender, EventArgs e)
        {
            Current current = new()
            {
                Id = Guid.NewGuid(),
                TaxDepartmentId = selectedTaxDepartment.Id,
                CurrentCode = txtCurrentCode.Text,
                CurrentName = txtCurrentName.Text,
                CardType = getCardType(),
                CurrentType = CheckCurrentType(),
                Status = getStatus(),
                CurrentFirstName = txtCurrentFirstName.Text,
                CurrentLastName = txtCurrentLastName.Text,
                TaxNumberOrIdentityNumber = txtTaxNumberOrIdentityNumber.Text,
                Email = txtEmail.Text,
                AddressHeader = txtAddressHeader.Text,
                AddressBABNo = txtAddressBABNo.Text,
                AddressCity = txtAddressCity.Text,
                AddressDistrict = txtAddressDistrict.Text,
                AddressMainStreet = txtAddressMainStreet.Text,
                AddressNeighbourhood = txtAddressNeighbourhood.Text,
                AddressNote = txtAddressNote.Text,
                AddressPostCode = txtAddressPostCode.Text,
                AddressStreet = txtAddressStreet.Text,
                PhoneNumber = txtPhoneNumber.Text,
                FaxNumber = txtFaxNumber.Text,
            };

            Current addedCurrent = await _currentService.AddAsync(current);
            await ClearAllTextBox(this);

            await ShowInfoMessage($"{addedCurrent.CurrentName} İsimli Cari Kaydedildi!");

        }

        private void btnImportCurrent_Click(object sender, EventArgs e)
        {

            if (_currentPopup.ShowDialog() == DialogResult.OK)
            {
                selectedCurrent = _currentPopup._current;

                if (selectedCurrent.CardType == true)
                    rdRealPerson.Checked = true;
                if (selectedCurrent.CardType == false)
                    rdCorporate.Checked = true;

                if (selectedCurrent.Status == true)
                    rdActive.Checked = true;
                if (selectedCurrent.Status == false)
                    rdPassive.Checked = true;

                switch (selectedCurrent.CurrentType)
                {
                    case CurrentType.Buyer: rdBuyer.Checked = true; break;
                    case CurrentType.Seller: rdSeller.Checked = true; break;
                    case CurrentType.BuyerSeler: rdBuyerSeller.Checked = true; break;
                }

                txtTaxDepartmentName.Text = selectedCurrent.TaxDepartment.Name;
                txtCurrentCode.Text = selectedCurrent.CurrentCode;
                txtCurrentName.Text = selectedCurrent.CurrentName;
                selectedCurrent.CurrentFirstName = txtCurrentFirstName.Text;
                txtCurrentLastName.Text = selectedCurrent.CurrentLastName;
                txtTaxNumberOrIdentityNumber.Text = selectedCurrent.TaxNumberOrIdentityNumber;
                txtEmail.Text = selectedCurrent.Email;
                txtAddressHeader.Text = selectedCurrent.AddressHeader;
                txtAddressBABNo.Text = selectedCurrent.AddressBABNo;
                txtAddressCity.Text = selectedCurrent.AddressCity;
                txtAddressDistrict.Text = selectedCurrent.AddressDistrict;
                txtAddressMainStreet.Text = selectedCurrent.AddressMainStreet;
                txtAddressNeighbourhood.Text = selectedCurrent.AddressNeighbourhood;
                txtAddressNote.Text = selectedCurrent.AddressNote;
                txtAddressPostCode.Text = selectedCurrent.AddressPostCode;
                txtAddressStreet.Text = selectedCurrent.AddressStreet;
                txtPhoneNumber.Text = selectedCurrent.PhoneNumber;
                txtFaxNumber.Text = selectedCurrent.FaxNumber;

                ShowInfoMessage($"{selectedCurrent.CurrentName} İsimli Carinin Bilgileri Yüklendi!");
            }
        }

        private async void btnCurrentUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCurrent != null)
            {
                Current? updateCurrent = await _currentService.GetAsync(predicate: c => c.Id.Equals(selectedCurrent.Id));
                TaxDepartment? taxDepartment = await _taxDepartmentService.GetAsync(predicate: td => td.Name.Equals(txtTaxDepartmentName.Text));

                updateCurrent.TaxDepartmentId = taxDepartment.Id;
                updateCurrent.CurrentCode = txtCurrentCode.Text;
                updateCurrent.CurrentName = txtCurrentName.Text;
                updateCurrent.CardType = getCardType();
                updateCurrent.CurrentType = CheckCurrentType();
                updateCurrent.Status = getStatus();
                updateCurrent.CurrentFirstName = txtCurrentFirstName.Text;
                updateCurrent.CurrentLastName = txtCurrentLastName.Text;
                updateCurrent.TaxNumberOrIdentityNumber = txtTaxNumberOrIdentityNumber.Text;
                updateCurrent.Email = txtEmail.Text;
                updateCurrent.AddressHeader = txtAddressHeader.Text;
                updateCurrent.AddressBABNo = txtAddressBABNo.Text;
                updateCurrent.AddressCity = txtAddressCity.Text;
                updateCurrent.AddressDistrict = txtAddressDistrict.Text;
                updateCurrent.AddressMainStreet = txtAddressMainStreet.Text;
                updateCurrent.AddressNeighbourhood = txtAddressNeighbourhood.Text;
                updateCurrent.AddressNote = txtAddressNote.Text;
                updateCurrent.AddressPostCode = txtAddressPostCode.Text;
                updateCurrent.AddressStreet = txtAddressStreet.Text;
                updateCurrent.PhoneNumber = txtPhoneNumber.Text;
                updateCurrent.FaxNumber = txtFaxNumber.Text;

                Current updatedCurrent = await _currentService.UpdateAsync(updateCurrent);
                selectedCurrent = null;
                ShowInfoMessage($"{updatedCurrent.CurrentName} İsimli Cari Güncellendi!");

                ClearAllTextBox(this);
            }
        }

        private async void btnCurrentDelete_Click(object sender, EventArgs e)
        {
            if (selectedCurrent != null)
            {
                Current deletedCurrent = await _currentService.DeleteAsync(selectedCurrent);
                selectedCurrent = null;
                ShowInfoMessage($"{deletedCurrent} İsimli Cari Silindi!");
                ClearAllTextBox(this);
            }
        }

        private bool getCardType()
        {
            if (rdCorporate.Checked == true)
                return false;

            return true;
        }

        private bool getStatus()
        {
            if (rdPassive.Checked == true)
                return false;
            return true;
        }

        private async Task ClearAllTextBox(Form form)
        {
            List<System.Windows.Forms.TextBox> textBoxs = FormExtensions.GetAllTextBox(form);
            foreach (System.Windows.Forms.TextBox textBox in textBoxs)
            {
                textBox.Clear();
            }
        }

        private async Task ShowInfoMessage(string message)
        {
            lblInfo.Text = message;
            await Task.Delay(5000);
            lblInfo.Text = string.Empty;
        }

        private async Task<string> GenerateCurrentCode(CurrentType currentType)
        {
            string currentCode = "";

            ICollection<Current>? currentsByCurrentType = await _currentService.GetListAsync(
                    predicate: c => c.CurrentType == currentType,
                    cancellationToken: CancellationToken.None
                );

            int currentCount = currentsByCurrentType.Count() + 1;

            string startChar = currentType switch
            {
                CurrentType.Seller => "S",
                CurrentType.Buyer => "A",
                CurrentType.BuyerSeler => "A/S",
            };

            currentCode = startChar + "-" + currentCount;


            return currentCode;
        }

        private CurrentType CheckCurrentType()
        {
            CurrentType currentType = CurrentType.None;

            if (rdBuyer.Checked == false && rdSeller.Checked == false && rdBuyerSeller.Checked == false)
                throw new Exception("Kart Tipi Seçili Değil");



            if (rdBuyer.Checked)
                currentType = CurrentType.Buyer;
            else if (rdSeller.Checked)
                currentType = CurrentType.Seller;
            else if (rdBuyerSeller.Checked)
                currentType = CurrentType.BuyerSeler;

            return currentType;
        }

        
    }
}
