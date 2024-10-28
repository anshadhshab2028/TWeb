using App.BLL.Interface;
using App.DLL.Interface;
using App.DLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL.Implementation
{
    public class DBManagerBL : IDBManagerBL
    {
        public readonly IDBManagerDL dbmanagerDAL;

        public DBManagerBL(IDBManagerDL _dbmanagerDAL)
        {
            this.dbmanagerDAL = _dbmanagerDAL;
        }

        public LoginDetails ValidateCredential(LoginDetails inputlogin)
        {
            return dbmanagerDAL.ValidateCredential(inputlogin);
        }

        public TravelPartner SavePartnerData(TravelPartner partner)
        {
            return dbmanagerDAL.SavePartnerData(partner);
        }

        public List<TravelPartner> GetTravelPartners()
        {
            return dbmanagerDAL.GetTravelPartners();
        }

        public TravelPartner GetTravelPartnerById(string PartnerId)
        {
            return dbmanagerDAL.GetTravelPartnerById(PartnerId);
        }
    }
}
