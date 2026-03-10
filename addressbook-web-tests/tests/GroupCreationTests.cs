using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {                       
            GroupData group = new GroupData("TestName");
            group.Name = "TestHeader";
            group.Footer = "TestFooter";

            app.Groups.Create(group);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Name = "";
            group.Footer = "";

            app.Groups.Create(group);
        }
    }
}
