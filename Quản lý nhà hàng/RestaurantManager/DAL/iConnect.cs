using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RestaurantManager.DAL
{
    interface iConnect
    {
        string DataSource { get; set; }
        string Database { get; set; }
        string UserName { get; set; }
        string PassWord { get; set; }
        SqlConnection SqlconnectionSQLSeverAuthentication();
        SqlConnection SqlConnectionWindowsAuthentication();
    }
}
