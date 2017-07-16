using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public sealed class MembershipTypeModel
    {
        public string MembershipTypeName { get; set; }
        public RestrictionModel Restriction { get; set; }
    }

    public sealed class RestrictionModel
    {
        public int MaxSearchesPerDay { get; set; }
        public int MaxApplicationsPerDay { get; set; }
    }

    public sealed class UserModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MembershipTypeName { get; set; }
        public UserUsageModel CurrentUsage { get; set; }
    }

    public sealed class UserUsageModel
    {
        public int CurrentSearchesCount { get; set; }
        public int CurrentApplicationsCount { get; set; }
    }
    public sealed class AccessResultModel
    {
        public bool CanSearch { get; set; }
        public bool CanApply { get; set; }
    }
}
