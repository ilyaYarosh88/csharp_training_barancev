using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.GroupHelper.InitGroupCreation();
            GroupData group = new GroupData("TestName");
            group.Name = "TestHeader";
            group.Footer = "TestFooter";
            app.GroupHelper.FillGroupForm(group);
            app.GroupHelper.SubmitGroupCreation();
            app.GroupHelper.ReturnToGroupsPage();
        }
    }
}
