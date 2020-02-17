using System.Collections.Generic;

namespace SalesWebMVC.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public List<Department> Departments { get; set; }
    }
}
