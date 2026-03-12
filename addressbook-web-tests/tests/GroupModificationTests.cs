using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [SetUp]
        public void SetupGroupPrecondition()
        {
            if (!app.Groups.IsGroupPresent())
            {
                GroupData group = new GroupData("TestName");
                group.Name = "TestHeader";
                group.Footer = "TestFooter";

                app.Groups.Create(group);
            }
        }

        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("GroupNameModified");
            newData.Header = null;
            newData.Footer = null;

            app.Groups.Modify(1, newData);
        }
    }
}
