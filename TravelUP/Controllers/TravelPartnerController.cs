using App.BLL.Interface;
using App.DLL.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Newtonsoft.Json;
using RestSharp;
using static App.DLL.Model.Global;
namespace TravelUP.Controllers
{
    public class TravelPartnerController : Controller
    {
        private readonly IDBManagerBL _dbmanager;


        public TravelPartnerController(IDBManagerBL IDBManagerBL)
        {
            this._dbmanager = IDBManagerBL;
        }
        public IActionResult TravelPartner()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SavePartnerData(TravelPartner partner)
        {

            if (int.Parse(HttpContext.Session.GetString("UserID")) == 0)
            {
                LoginDetails _LoginDetails_RS = new LoginDetails();
                return PartialView("Login", _LoginDetails_RS);
            }
            try
            {
                //var _response = _dbmanager.SavePartnerData(partner);

                //return Json(_response);
                var client = new RestClient("https://localhost:7232/api/Home/CreateTravelpartner");
                var request = new RestRequest() { Method = Method.Post };
                var jsondata = MakeRequest(partner);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", jsondata, ParameterType.RequestBody);
                var response = client.Execute(request);
                var _serializedata = JsonConvert.DeserializeObject<TravelPartner>(response.Content);
                if (_serializedata != null)
                {
                    return Json(_serializedata);
                }
            }

            catch (Exception ex)
            {
                return Json(null);
            }

            return Json(new TravelPartner());

        }

        [HttpPost]
        public ActionResult UpdatePartnerData(TravelPartner partner)
        {

            if (int.Parse(HttpContext.Session.GetString("UserID")) == 0)
            {
                LoginDetails _LoginDetails_RS = new LoginDetails();
                return PartialView("Login", _LoginDetails_RS);
            }
            try
            {
                //var _response = _dbmanager.SavePartnerData(partner);

                //return Json(_response);
                var client = new RestClient("https://localhost:7232/api/Home/CreateTravelpartner");
                var request = new RestRequest() { Method = Method.Post };
                var jsondata = MakeRequest(partner);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", jsondata, ParameterType.RequestBody);
                var response = client.Execute(request);
                var _serializedata = JsonConvert.DeserializeObject<TravelPartner>(response.Content);
                if (_serializedata != null)
                {
                    return Json(_serializedata);
                }

            }

            catch (Exception ex)
            {
                return Json(null);
            }
            return Json(new TravelPartner());


        }
        


        [HttpGet]
        public ActionResult GetTravelPartners()
        {

            if (int.Parse(HttpContext.Session.GetString("UserID")) == 0)
            {
                LoginDetails _LoginDetails_RS = new LoginDetails();
                return PartialView("Login", _LoginDetails_RS);
            }
            try
            {
                //var _response = _dbmanager.GetTravelPartners();

                //return Json(_response);

                var client = new RestClient("https://localhost:7232/api/Home/GetTravelpartner");
                var request = new RestRequest() { Method = Method.Get };
                request.AddHeader("Content-Type", "application/json");
                var response = client.Execute(request);
                var _serializedata = JsonConvert.DeserializeObject<List<TravelPartner>>(response.Content);
                if(_serializedata != null)
                {
                    return Json(_serializedata);
                }
            }

            catch (Exception ex)
            {
                return Json(null);
            }
            return Json(new List<TravelPartner>());


        }

        [HttpPost]
        public ActionResult GetTravelPartnerById(string PartnerId)
        {

            if (int.Parse(HttpContext.Session.GetString("UserID")) == 0)
            {
                LoginDetails _LoginDetails_RS = new LoginDetails();
                return PartialView("Login", _LoginDetails_RS);
            }
            try
            {
                var _response = _dbmanager.GetTravelPartnerById(PartnerId);

                return Json(_response);
            }

            catch (Exception ex)
            {
                return Json(null);
            }



        }



        private string MakeRequest(TravelPartner partner)
        {

            var reqPartner = new TravelPartner()
            {
                Name = partner.Name,
                PartnerType = partner.PartnerType,
                Address1 = partner.Address1,
                Address2 = partner.Address2,
                City = partner.City,
                Country = partner.Country,  
                Phone = partner.Phone,
                Email = partner.Email,
                Website = partner.Website,
                LiNo = partner.LiNo
            };
           
            var _json = jsonSerialize(reqPartner);
            return _json;
        }
    }
}
