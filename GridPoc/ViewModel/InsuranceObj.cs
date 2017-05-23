using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace GridPoc.ViewModel
{
    public class Insurance
    {
        [Display(Name = "Policy No.")]
        public int PolicyNumber { get; set; }
        [Display(Name = "Pol Type")]
        public string PolicyType { get; set; }
        [Display(Name ="Proc Date")]
        [DisplayFormat(DataFormatString ="mm/dd/yyyy")]
        public DateTime ProcurementDate { get; set; }
        [Display(Name = "Eff Date")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime EffectiveDate { get; set; }
        [Display(Name = "Exp Date")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime ExpiryDate { get; set; }
        [Display(Name = "Agency")]
        public int AgencyID { get; set; }
        [Display(Name ="Named Insurer")]
        public string NamedInsurer { get; set; }

    }
}
