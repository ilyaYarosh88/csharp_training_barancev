using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.GroupHelper.SelectGroup(1);
            app.GroupHelper.RemoveGroup();
            app.GroupHelper.ReturnToGroupsPage();
        } 
    }
}
