using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using FluentAssertions;
using Model;
using NSubstitute;
using Services;
using TechTalk.SpecFlow;

namespace BDDTest
{

    [Binding]
    public sealed class AccessFrameworkAnalyzerSteps
    {
        [Given(@"the membershiptypes")]
        public void GivenTheMembershiptypes(Table table)
        {
            var membershipTypes = this.GetMembershipTypeModelsFromTable(table);
            ScenarioContext.Current.Add("MembershipTypes", membershipTypes);
        }

        [Given(@"a user")]
        public void GivenAUser(Table table)
        {
            var user = this.GetUserModelFromTable(table);
            ScenarioContext.Current.Add("User", user);
        }

        [When(@"access result is required")]
        public void WhenAccessResultIsRequired()
        {
            //data from context
            var membershipTypes = (List<MembershipTypeModel>)ScenarioContext.Current["MembershipTypes"];
            var user = (UserModel)ScenarioContext.Current["User"];
            //setup the mocks
            var configurationRetrieval = Substitute.For<IConfigurationRetrieval>();
            configurationRetrieval.RetrieveMembershipTypes().Returns(membershipTypes);
            
            var userDataRetrieval = Substitute.For<IUserDataRetrieval>();
            userDataRetrieval.RetrieveUserDetails(Arg.Any<string>()).Returns(user);

            //call to AccessFrameworkAnalyser
            var accessResult = new AccessFrameworkAnalyser(configurationRetrieval,
            userDataRetrieval).DetermineAccessResults(user.Username);
            
            ScenarioContext.Current.Add("AccessResult", accessResult);
        }

        [Then(@"access result should be")]
        public void ThenAccessResultShouldBe(Table table)
        {
            var expectedAccessResult = this.GetAccessResultFromTable(table);
            var accessResult = (AccessResultModel)ScenarioContext.Current["AccessResult"];

            expectedAccessResult.ShouldBeEquivalentTo(accessResult);
        }

        #region Private Methods

        //Private Methods
        private List<MembershipTypeModel> GetMembershipTypeModelsFromTable(Table table)
        {
            var results = new List<MembershipTypeModel>();
            foreach (var row in table.Rows)
            {
                var model = new MembershipTypeModel();
                model.Restriction = new RestrictionModel();
                model.MembershipTypeName = row.ContainsKey("MembershipTypeName") ?  row["MembershipTypeName"] : string.Empty;
                if (row.ContainsKey("MaxSearchesPerDay"))
                {
                    int maxSearchesPerDay = 0;
                    if (int.TryParse(row["MaxSearchesPerDay"], out maxSearchesPerDay))
                    {
                        model.Restriction.MaxSearchesPerDay = maxSearchesPerDay;
                    }
                }
                if (row.ContainsKey("MaxApplicationsPerDay"))
                {
                    int maxApplicationsPerDay = 0;
                    if (int.TryParse(row["MaxApplicationsPerDay"], out maxApplicationsPerDay))
                    {
                        model.Restriction.MaxApplicationsPerDay = maxApplicationsPerDay;
                    }
                }
                results.Add(model);
            }
            return results;
        }

        private UserModel GetUserModelFromTable(Table table)
        {
            var userModel = new UserModel();
            var userUsageModel = new UserUsageModel();
            var row = table.Rows[0];
            if (row.ContainsKey("ID"))
            {
                int id = 0;
                if (int.TryParse(row["ID"], out id))
                {
                    userModel.ID = id;
                }
            }
            userModel.Username = row.ContainsKey("Username") ? row["Username"] : string.Empty;
            userModel.FirstName = row.ContainsKey("FirstName") ? row["FirstName"] : string.Empty;
            userModel.LastName = row.ContainsKey("LastName") ? row["LastName"] : string.Empty;
            userModel.MembershipTypeName = row.ContainsKey("MembershipTypeName") ? row["MembershipTypeName"] : string.Empty;

            if (row.ContainsKey("CurrentSearchesCount"))
            {
                int currentSearchesCount = 0;
                if (int.TryParse(row["CurrentSearchesCount"], out currentSearchesCount))
                {
                    userUsageModel.CurrentSearchesCount = currentSearchesCount;
                }
            }

            if (row.ContainsKey("CurrentApplicationsCount"))
            {
                int currentApplicationsCount = 0;
                if (int.TryParse(row["CurrentApplicationsCount"], out currentApplicationsCount))
                {
                    userUsageModel.CurrentApplicationsCount = currentApplicationsCount;
                }
            }

            userModel.CurrentUsage = userUsageModel;

            return userModel;
        }

        private AccessResultModel GetAccessResultFromTable(Table table)
        {
            var accessResultModel = new AccessResultModel();

            var row = table.Rows[0];

            if (row.ContainsKey("CanSearch"))
            {
                bool canSearch = false;
                if (bool.TryParse(row["CanSearch"], out canSearch))
                {
                    accessResultModel.CanSearch = canSearch;
                }

                accessResultModel.CanSearch = canSearch;
            }

            if (row.ContainsKey("CanApply"))
            {
                bool canApply = false;
                if (bool.TryParse(row["CanApply"], out canApply))
                {
                    accessResultModel.CanApply = canApply;
                }

                accessResultModel.CanApply = canApply;
            }

            return accessResultModel;
        }

    }
    #endregion
}
