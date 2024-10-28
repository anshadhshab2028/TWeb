using App.DLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DLL.Interface
{
    public interface IDBManagerDL
    {
        LoginDetails ValidateCredential(LoginDetails inputlogin);
        TravelPartner SavePartnerData(TravelPartner partner);
        List<TravelPartner> GetTravelPartners();
        TravelPartner GetTravelPartnerById(string PartnerId);
    }
}
