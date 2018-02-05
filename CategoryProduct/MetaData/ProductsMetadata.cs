using System;
using System.ComponentModel.DataAnnotations;

namespace CategoryProduct.Models
{
    public class ProductsMetadata
    {
        [Display(Name = "ProductName")]
        [Required(ErrorMessageResourceName = "ProductNameEmpty",ErrorMessageResourceType =typeof(Resource1))]
        public string ProductName { get; set; }

        [Display(Name = "產品單價")]
        [DisplayFormat(DataFormatString ="{0:c}")]
        public Nullable<decimal> UnitPrice { get; set; }

        [Display(Name = "訂購單位")]
        [Range(1,100,ErrorMessage = "{0}必須介於{1}~{2}之間")]
        public Nullable<short> UnitsOnOrder { get; set; }
       
    }
}