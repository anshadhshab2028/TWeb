using App.DLL.Interface;
using App.DLL.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DLL.Implementation
{
    public class DBManagerDL : IDBManagerDL
    {
        private readonly IDapperHelper dapperHelper;


        public DBManagerDL(IDapperHelper dapperHelper)
        {
            this.dapperHelper = dapperHelper;
        }

        public LoginDetails ValidateCredential(LoginDetails inputlogin)
        {
            var parameters = new DynamicParameters();
            try
            {
                parameters.Add("UNAME", inputlogin.Username, DbType.String);
                parameters.Add("PWD", inputlogin.Password, DbType.String);
                using var dbConnection = dapperHelper.CreateConnection();
                var proc = "SP_USER_Login";
                var data = dbConnection.QueryFirstOrDefault<LoginDetails>(proc, parameters, commandType: CommandType.StoredProcedure);
                if (data != null)
                {
                    if (data.Returnvalue == 0)
                    {
                        data.Status = "error";
                        data.Msg = "Invalid UserName!";
                        return data;

                    }
                    else if (data.Returnvalue == 1)
                    {
                        data.Status = "error";
                        data.Msg = "Invalid Password!";
                        return data;

                    }
                    else
                        data.Status = "success";
                }
                return data;
            }
            catch (Exception ex)
            {
            }
            return new LoginDetails();


        }



        public TravelPartner SavePartnerData(TravelPartner partner)
        {
            var parameters = new DynamicParameters();
            try
            {
                parameters.Add("PartnerType", partner.PartnerType, DbType.Int16);
                parameters.Add("Name", partner.Name, DbType.String);
                parameters.Add("Address1", partner.Address1, DbType.String);
                parameters.Add("Address2", partner.Address2, DbType.String);
                parameters.Add("City", partner.City, DbType.String);
                parameters.Add("Country", partner.Country, DbType.String);
                parameters.Add("Phone", partner.Phone, DbType.String);
                parameters.Add("Email", partner.Email, DbType.String);
                parameters.Add("Website", partner.Website, DbType.String);
                parameters.Add("PartnerID", partner.LiNo, DbType.Int16);
                using var dbConnection = dapperHelper.CreateConnection();
                var proc = "SP_Set_TravelPartner";
                var data = dbConnection.Query<TravelPartner>(proc, parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                if (data != null)
                {
                    return data;
                }

            }
            catch (Exception ex)
            {
            }

            return new TravelPartner();

        }


        public List<TravelPartner> GetTravelPartners()
        {
           try
            {
                using var dbConnection = dapperHelper.CreateConnection();
                var proc = "SP_Get_TravelPartner";
                var data = dbConnection.Query<TravelPartner>(proc, commandType: CommandType.StoredProcedure).ToList();
                if (data != null && data.Count() > 0)
                {
                    return data;
                }

            }
            catch (Exception ex)
            {
            }

            return new List<TravelPartner>();

        }

        public TravelPartner GetTravelPartnerById(string PartnerId)
        {
            var parameters = new DynamicParameters();
            try
            {
                parameters.Add("PartnerId", PartnerId, DbType.Int16);
                using var dbConnection = dapperHelper.CreateConnection();
                var proc = "SP_Get_TravelPartnerById";
                var data = dbConnection.Query<TravelPartner>(proc, parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                if (data != null )
                {
                    return data;
                }

            }
            catch (Exception ex)
            {
            }

            return new TravelPartner();

        }


    }

}