using App.DLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL.Interface
{
    public interface IDBManagerBL
    {
        LoginDetails ValidateCredential(LoginDetails inputlogin);
        TravelPartner SavePartnerData(TravelPartner partner);
        List<TravelPartner> GetTravelPartners();
        TravelPartner GetTravelPartnerById(string PartnerId);
    }
}
