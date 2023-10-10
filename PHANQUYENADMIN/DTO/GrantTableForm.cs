using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHANQUYENADMIN.DTO
{
        struct GrantTableForm
        {
            public string TableName;
            public bool Select;
            public bool Update;
            public bool Insert;
        public bool Delete;
            public bool revoke;

            public GrantTableForm(string tableName, bool select, bool update, bool insert,bool del,bool revok)
            {
                TableName = tableName;
                Select = select;
                Update = update;
                Insert = insert;
                Delete = del;
                revoke = revok;
            }
        }
}
