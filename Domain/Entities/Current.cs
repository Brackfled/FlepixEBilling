using Domain.Abstract;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Current: Entity<Guid>
    {
        public int TaxDepartmentId {  get; set; }
        public string CurrentCode { get; set; }
        public string CurrentName { get; set; }
        public bool CardType { get; set; }
        public CurrentType CurrentType { get; set; }
        public bool Status { get; set; }
        public string? CurrentFirstName { get; set; }
        public string? CurrentLastName { get; set; }
        public string TaxNumberOrIdentityNumber { get; set; }
        public string Email {  get; set; }
        public string AddressHeader { get; set; }
        public string? AddressMainStreet { get; set; }
        public string AddressNeighbourhood { get; set; }
        public string? AddressStreet { get; set; }
        public string AddressBABNo { get; set; }
        public string AddressDistrict { get; set; }
        public string AddressCity { get; set; }
        public string AddressPostCode { get; set; }
        public string? AddressNote { get; set; }
        public string PhoneNumber { get; set; }
        public string? FaxNumber { get; set; }


        public TaxDepartment TaxDepartment { get; set; } = default!;

        public Current()
        {
            CurrentCode = string.Empty;
            CurrentName = string.Empty;
            CurrentLastName = string.Empty;
            CurrentFirstName = string.Empty;
            TaxNumberOrIdentityNumber = string.Empty;
            Email = string.Empty;
            AddressHeader = string.Empty;
            AddressMainStreet = string.Empty;
            AddressNeighbourhood = string.Empty;
            AddressStreet = string.Empty;
            AddressBABNo = string.Empty;
            AddressDistrict = string.Empty;
            AddressCity = string.Empty;
            AddressPostCode = string.Empty;
            AddressNote = string.Empty;
            PhoneNumber = string.Empty;
            FaxNumber = string.Empty;
        }

        public Current(int taxDepartmentId, string currentCode, string currentName, bool cardType, CurrentType currentType, bool status, string? currentFirstName, string? currentLastName, string taxNumberOrIdentityNumber, string email, string addressHeader, string? addressMainStreet, string addressNeighbourhood, string? addressStreet, string addressBABNo, string addressDistrict, string addressCity, string addressPostCode, string? addressNote, string phoneNumber, string? faxNumber, TaxDepartment taxDepartment)
        {
            TaxDepartmentId = taxDepartmentId;
            CurrentCode = currentCode;
            CurrentName = currentName;
            CardType = cardType;
            CurrentType = currentType;
            Status = status;
            CurrentFirstName = currentFirstName;
            CurrentLastName = currentLastName;
            TaxNumberOrIdentityNumber = taxNumberOrIdentityNumber;
            Email = email;
            AddressHeader = addressHeader;
            AddressMainStreet = addressMainStreet;
            AddressNeighbourhood = addressNeighbourhood;
            AddressStreet = addressStreet;
            AddressBABNo = addressBABNo;
            AddressDistrict = addressDistrict;
            AddressCity = addressCity;
            AddressPostCode = addressPostCode;
            AddressNote = addressNote;
            PhoneNumber = phoneNumber;
            FaxNumber = faxNumber;
            TaxDepartment = taxDepartment;
        }
    }
}
