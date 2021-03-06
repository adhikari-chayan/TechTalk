﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BDDTest
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AccessFrameworkAnalyzer")]
    public partial class AccessFrameworkAnalyzerFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AccessFrameworkAnalyzer.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AccessFrameworkAnalyzer", "\tIn order to avoid unpaid searches and applications\r\n\tI want to be sure that the " +
                    "user can only search and apply upto their limit\r\n\tbased on their membership type" +
                    "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("user with Free membership, already maxed searches and applications")]
        [NUnit.Framework.CategoryAttribute("AccessFrameworkAnalyser")]
        public virtual void UserWithFreeMembershipAlreadyMaxedSearchesAndApplications()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("user with Free membership, already maxed searches and applications", new string[] {
                        "AccessFrameworkAnalyser"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "MembershipTypeName",
                        "MaxSearchesPerDay",
                        "MaxApplicationsPerDay"});
            table1.AddRow(new string[] {
                        "Free",
                        "5",
                        "1"});
            table1.AddRow(new string[] {
                        "Silver",
                        "10",
                        "10"});
            table1.AddRow(new string[] {
                        "Gold",
                        "15",
                        "15"});
            table1.AddRow(new string[] {
                        "Platinum",
                        "50",
                        "50"});
#line 8
 testRunner.Given("the membershiptypes", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ID",
                        "Username",
                        "FirstName",
                        "LastName",
                        "MembershipTypeName",
                        "CurrentSearchesCount",
                        "CurrentApplicationsCount"});
            table2.AddRow(new string[] {
                        "10",
                        "drakem",
                        "Drake",
                        "Moore",
                        "Free",
                        "5",
                        "1"});
#line 14
 testRunner.And("a user", ((string)(null)), table2, "And ");
#line 17
 testRunner.When("access result is required", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "CanSearch",
                        "CanApply"});
            table3.AddRow(new string[] {
                        "false",
                        "false"});
#line 18
 testRunner.Then("access result should be", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("user with Free membership, still has both searches and applications")]
        [NUnit.Framework.CategoryAttribute("AccessFrameworkAnalyser")]
        public virtual void UserWithFreeMembershipStillHasBothSearchesAndApplications()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("user with Free membership, still has both searches and applications", new string[] {
                        "AccessFrameworkAnalyser"});
#line 24
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "MembershipTypeName",
                        "MaxSearchesPerDay",
                        "MaxApplicationsPerDay"});
            table4.AddRow(new string[] {
                        "Free",
                        "5",
                        "1"});
            table4.AddRow(new string[] {
                        "Silver",
                        "10",
                        "10"});
            table4.AddRow(new string[] {
                        "Gold",
                        "15",
                        "15"});
            table4.AddRow(new string[] {
                        "Platinum",
                        "50",
                        "50"});
#line 25
 testRunner.Given("the membershiptypes", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ID",
                        "Username",
                        "FirstName",
                        "LastName",
                        "MembershipTypeName",
                        "CurrentSearchesCount",
                        "CurrentApplicationsCount"});
            table5.AddRow(new string[] {
                        "10",
                        "drakem",
                        "Drake",
                        "Moore",
                        "Free",
                        "4",
                        "0"});
#line 31
 testRunner.And("a user", ((string)(null)), table5, "And ");
#line 34
 testRunner.When("access result is required", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "CanSearch",
                        "CanApply"});
            table6.AddRow(new string[] {
                        "true",
                        "true"});
#line 35
 testRunner.Then("access result should be", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("user with Free membership, still has searches but no applications available")]
        [NUnit.Framework.CategoryAttribute("AccessFrameworkAnalyser")]
        public virtual void UserWithFreeMembershipStillHasSearchesButNoApplicationsAvailable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("user with Free membership, still has searches but no applications available", new string[] {
                        "AccessFrameworkAnalyser"});
#line 40
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "MembershipTypeName",
                        "MaxSearchesPerDay",
                        "MaxApplicationsPerDay"});
            table7.AddRow(new string[] {
                        "Free",
                        "5",
                        "1"});
            table7.AddRow(new string[] {
                        "Silver",
                        "10",
                        "10"});
            table7.AddRow(new string[] {
                        "Gold",
                        "15",
                        "15"});
            table7.AddRow(new string[] {
                        "Platinum",
                        "50",
                        "50"});
#line 41
 testRunner.Given("the membershiptypes", ((string)(null)), table7, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ID",
                        "Username",
                        "FirstName",
                        "LastName",
                        "MembershipTypeName",
                        "CurrentSearchesCount",
                        "CurrentApplicationsCount"});
            table8.AddRow(new string[] {
                        "10",
                        "drakem",
                        "Drake",
                        "Moore",
                        "Free",
                        "4",
                        "1"});
#line 47
 testRunner.And("a user", ((string)(null)), table8, "And ");
#line 50
 testRunner.When("access result is required", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "CanSearch",
                        "CanApply"});
            table9.AddRow(new string[] {
                        "true",
                        "false"});
#line 51
 testRunner.Then("access result should be", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
