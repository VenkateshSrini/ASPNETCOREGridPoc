using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GridPoc.ViewModel;
using System.Globalization;
using OfficeOpenXml;
using OfficeOpenXml.Style;
namespace GridPoc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View(GetInsuranceDetails());
        }
        public IActionResult ExportIndex()
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                Int32 row = 2;
                Int32 col = 1;
               ExcelWorksheet dataSheet =  package.Workbook.Worksheets.Add("Data");
                
                dataSheet.Cells[1, 1].Value = "Policy No.";
                
                dataSheet.Cells[1, 2].Value = "Policy Type";
                dataSheet.Cells[1, 3].Value = "Procurement Date";
                dataSheet.Cells[1, 4].Value = "Effective Date";
                dataSheet.Cells[1, 5].Value = "Expiry Date";
                dataSheet.Cells[1, 6].Value = "Agency ID";
                dataSheet.Cells[1, 7].Value = "Insured";
                var dataSet = GetInsuranceDetails();
                for(int objIndex=0; objIndex<dataSet.Count;objIndex++)
                {
                    dataSheet.Cells[row, 1].Value = dataSet[objIndex].PolicyNumber.ToString();
                    dataSheet.Cells[row, 2].Value = dataSet[objIndex].PolicyType;
                    dataSheet.Cells[row, 3].Value = dataSet[objIndex].ProcurementDate.ToString("mm/dd/yyyy");
                    dataSheet.Cells[row, 4].Value = dataSet[objIndex].EffectiveDate.ToString("mm/dd/yyyy");
                    dataSheet.Cells[row, 5].Value = dataSet[objIndex].ExpiryDate.ToString("mm/dd/yyyy");
                    dataSheet.Cells[row, 6].Value = dataSet[objIndex].AgencyID.ToString();
                    dataSheet.Cells[row, 7].Value = dataSet[objIndex].NamedInsurer;
                    row++;

                }
                dataSheet.Column(1).BestFit = true;
                dataSheet.Column(2).BestFit = true;
                dataSheet.Column(3).BestFit = true;
                dataSheet.Column(4).BestFit = true;
                dataSheet.Column(5).BestFit = true;
                dataSheet.Column(6).BestFit = true;
                dataSheet.Column(7).BestFit = true;
                
                return File(package.GetAsByteArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","policies.xlsx");

            }
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
                PolicyNumber = 11111111,
                EffectiveDate = new DateTime(2005,2,27),
                ExpiryDate = new DateTime(2006, 2, 27),
                ProcurementDate = new DateTime(2005,3,29),
                NamedInsurer = "Tata & Sons",
                AgencyID = 2222222,
                PolicyType = "Delayed Payment Cancellation Memo"
            });
            insurances.Add(new Insurance
            {
                PolicyNumber = 11111111,
                EffectiveDate = new DateTime(2005, 2, 27),
                ExpiryDate = new DateTime(2006, 2, 27),
                ProcurementDate = new DateTime(2005, 3, 4),
                NamedInsurer = "TVS and Sons",
                AgencyID = 2222222,
                PolicyType = "Cancelled"
            });
            insurances.Add(new Insurance
            {
                PolicyNumber = 11111111,
                EffectiveDate = new DateTime(2005, 2, 27),
                ExpiryDate = new DateTime(2006, 2, 27),
                ProcurementDate = new DateTime(2005, 3, 4),
                NamedInsurer = "Tata & Sons",
                AgencyID = 2222222,
                PolicyType = "Cancelled"
            });
            insurances.Add(new Insurance
            {
                PolicyNumber = 11111111,
                EffectiveDate = new DateTime(2005, 2, 27),
                ExpiryDate = new DateTime(2006, 2, 27),
                ProcurementDate = new DateTime(2005, 1, 13),
                NamedInsurer = "Tata & Sons",
                AgencyID = 2222222,
                PolicyType = "Repeat Renewal"
            });
            insurances.Add(new Insurance
            {
                PolicyNumber = 11111111,
                EffectiveDate = new DateTime(2005, 2, 27),
                ExpiryDate = new DateTime(2006, 2, 27),
                ProcurementDate = new DateTime(2004, 1, 15),
                NamedInsurer = "Tata & Sons",
                AgencyID = 2222222,
                PolicyType = "Repeat Renewal"
            });
            insurances.Add(new Insurance
            {
                PolicyNumber = 11111111,
                EffectiveDate = new DateTime(2005, 2, 27),
                ExpiryDate = new DateTime(2006, 2, 27),
                ProcurementDate = new DateTime(2003, 2, 27),
                NamedInsurer = "Tata & Sons",
                AgencyID = 2222222,
                PolicyType = "Modified"
            });
            insurances.Add(new Insurance
            {
                PolicyNumber = 11111111,
                EffectiveDate = new DateTime(2005, 2, 27),
                ExpiryDate = new DateTime(2006, 2, 27),
                ProcurementDate = new DateTime(2003, 1, 29),
                NamedInsurer = "Tata & Sons",
                AgencyID = 2222222,
                PolicyType = "New"
            });
            return insurances;
        }
        #endregion
    }
}
