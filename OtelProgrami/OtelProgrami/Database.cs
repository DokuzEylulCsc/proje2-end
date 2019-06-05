using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace OtelProgrami
{
    class Database
    {
        public SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-89UBDQO;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
    }
}
