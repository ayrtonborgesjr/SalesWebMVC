using SalesWebMVC.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Range(1.0, 1000000.0, ErrorMessage = "{0} size should be between {1} and {2}")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Sales Staus")]
        public SaleStatus SaleStatus { get; set; }
        
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus saleStatus, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            SaleStatus = saleStatus;
            Seller = seller;
        }
    }
}
