using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Core
{
    public interface IConfigurationRetrieval
    {
        List<MembershipTypeModel> RetrieveMembershipTypes();
    }

    public interface IUserDataRetrieval
    {
        UserModel RetrieveUserDetails(string username);
    }
}
