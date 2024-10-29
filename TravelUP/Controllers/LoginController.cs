using App.BLL.Interface;
using App.DLL.Model;
using Microsoft.AspNetCore.Mvc;

namespace TravelUP.Controllers
{
    public class LoginController : Controller
    {
        private readonly IDBManagerBL _dbmanager;

        public LoginController(IDBManagerBL IDBManagerBL)
        {
            this._dbmanager = IDBManagerBL;
        }
        public ActionResult Login()
        {
            LoginDetails AlertResponse = new LoginDetails();

            try
            {
                var status = HttpContext.Session.GetString("Status");
                var userId = HttpContext.Session.GetString("UserID");

                if (string.IsNullOrEmpty(status))
                {
                    return PartialView(AlertResponse);
                }

                if (status == "success" && int.TryParse(userId, out var parsedUserId) && parsedUserId != 0)
                {
                    return RedirectToAction("Index", "Home");
                }

                return PartialView(AlertResponse);
            }


            catch (Exception ex)
            {
                return PartialView("Login", AlertResponse);
            }
        }


        [HttpPost]
        public ActionResult ValidateCredential(string Username, string Password)
        {
            LoginDetails inputlogin = new LoginDetails();
            inputlogin.Username = Username;
            inputlogin.Password = Password;
            var response = _dbmanager.ValidateCredential(inputlogin);
            if (response != null && response.Status == "success")
            {
                HttpContext.Session.SetString("Status", "success");
                HttpContext.Session.SetString("UserID", response.UserID.ToString());
                HttpContext.Session.SetString("Username", Username);
                HttpContext.Session.SetString("Loggedon", DateTime.Now.ToString());


            }
            return Json(response);
        }
    }
}
