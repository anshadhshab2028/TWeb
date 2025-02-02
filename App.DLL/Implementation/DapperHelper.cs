﻿using App.DLL.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DLL.Implementation
{
    public class DapperHelper : IDapperHelper
    {
        private readonly IConfiguration configuration;

        public DapperHelper(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(configuration.GetConnectionString("Connection"));
        }
    }
}
