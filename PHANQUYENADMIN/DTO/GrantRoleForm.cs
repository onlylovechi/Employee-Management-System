using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHANQUYENADMIN.DTO
{
    struct GrantRoleForm
    {
        public string RoleName;
        public bool Grant;
        public bool AdminOption;
        public bool Revoke;

        public GrantRoleForm(string roleName, bool grant, bool adminOption, bool revoke)
        {
            RoleName = roleName;
            Grant = grant;
            AdminOption = adminOption;
            Revoke = revoke;
        }
    }
}
