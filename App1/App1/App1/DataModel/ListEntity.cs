using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.DataModel
{
    public class ListEntity
    {
        public ListEntity()
        {
        }

        [PrimaryKey,AutoIncrement]
        public int uid { get; set; }
        public string ItemName { get; set; }
    }
}
