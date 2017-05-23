using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GridPoc.ViewModel;
using System.Globalization;
namespace GridPoc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View(GetInsuranceDetails());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        #region Private Methods
        private List<Insurance>GetInsuranceDetails()
        {
            List<Insurance> insurances = new List<Insurance>();
            insurances.Add(new Insurance {
                PolicyNumber = 1010457489,
                EffectiveDate = new DateTime(2005,2,27),
                ExpiryDate = new DateTime(2006, 2, 27),
                ProcurementDate = new DateTime(2005,3,29),
                NamedInsurer = "EDWARD & LISA COHEN",
                AgencyID = 2303525,
                PolicyType = "Loss Payee Cancellation Memo"
            });
            insurances.Add(new Insurance
            {
                PolicyNumber = 1010457489,
                EffectiveDate = new DateTime(2005, 2, 27),
                ExpiryDate = new DateTime(2006, 2, 27),
                ProcurementDate = new DateTime(2005, 3, 4),
                NamedInsurer = "Gorga Agency",
                AgencyID = 2303525,
                PolicyType = "Cancellation"
            });
            insurances.Add(new Insurance
            {
                PolicyNumber = 1010457489,
                EffectiveDate = new DateTime(2005, 2, 27),
                ExpiryDate = new DateTime(2006, 2, 27),
                ProcurementDate = new DateTime(2005, 3, 4),
                NamedInsurer = "EDWARD & LISA COHEN",
                AgencyID = 2303525,
                PolicyType = "Cancellation"
            });
            insurances.Add(new Insurance
            {
                PolicyNumber = 1010457489,
                EffectiveDate = new DateTime(2005, 2, 27),
                ExpiryDate = new DateTime(2006, 2, 27),
                ProcurementDate = new DateTime(2005, 1, 13),
                NamedInsurer = "EDWARD & LISA COHEN",
                AgencyID = 2303525,
                PolicyType = "Renewal"
            });
            insurances.Add(new Insurance
            {
                PolicyNumber = 1010457489,
                EffectiveDate = new DateTime(2005, 2, 27),
                ExpiryDate = new DateTime(2006, 2, 27),
                ProcurementDate = new DateTime(2004, 1, 15),
                NamedInsurer = "EDWARD & LISA COHEN",
                AgencyID = 2303525,
                PolicyType = "Renewal"
            });
            insurances.Add(new Insurance
            {
                PolicyNumber = 1010457489,
                EffectiveDate = new DateTime(2005, 2, 27),
                ExpiryDate = new DateTime(2006, 2, 27),
                ProcurementDate = new DateTime(2003, 2, 27),
                NamedInsurer = "EDWARD & LISA COHEN",
                AgencyID = 2303525,
                PolicyType = "Amendment"
            });
            insurances.Add(new Insurance
            {
                PolicyNumber = 1010457489,
                EffectiveDate = new DateTime(2005, 2, 27),
                ExpiryDate = new DateTime(2006, 2, 27),
                ProcurementDate = new DateTime(2003, 1, 29),
                NamedInsurer = "EDWARD & LISA COHEN",
                AgencyID = 2303525,
                PolicyType = "New"
            });
            return insurances;
        }
        #endregion
    }
}
