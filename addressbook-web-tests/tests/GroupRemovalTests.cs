using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
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
        public void GroupRemovalTest()
        {    
            app.Groups.Remove(1);
        } 
    }
}
