using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitGroupCreation();
            GroupData group = new GroupData("TestName");
            group.Name = "TestHeader";
            group.Footer = "TestFooter";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupPage();
        }
    }
}
