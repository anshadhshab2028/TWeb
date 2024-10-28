using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DLL.Interface
{
    public interface IDapperHelper
    {

        IDbConnection CreateConnection();
      
    }
}
