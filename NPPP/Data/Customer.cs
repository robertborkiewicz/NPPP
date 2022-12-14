using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NPPP.Data
{
    public class Customer   
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? PESEL { get; set; }

        public string? ParentFirstName { get; set; }

        public string? ParentLastName { get; set; }

        public string? ParentPESEL { get; set; }

        public string? ParentPhone { get; set; }

        public string? ParentEmail { get; set; }

        public string? AddressStreet { get; set; }

        public string? AddressCity { get; set; }

        public override string ToString()
        {
            return FirstName + ' ' +
                   LastName + ' ' +
                   PESEL + ' ' +
                   ParentFirstName + ' ' +
                   ParentLastName + ' ' +
                   ParentPESEL + ' ' +
                   ParentPhone + ' ' +
                   ParentEmail + ' ' +
                   AddressStreet + ' ' +
                   AddressCity;
        }

    }
}
