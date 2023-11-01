using DoAnHQTCSDL.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnHQTCSDL.BS
{
    internal class BLXemThongTin
    {
        DBMain db = null;
        string username = "";
        public BLXemThongTin(string username, DBMain db)
        {
            this.username = username;
            this.db = db;
        }

        public DataSet LayThongTinCaNhan()
        {
            return this.db.ExecuteQueryDataSet("SELECT * FROM dbo.XemTTCaNhan('" + this.username + "');", CommandType.Text);
        }
    }
}
