using NUnit.Framework;

namespace WebAddressbookTests.tests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("qwerty");
            newData.Name = "rtyu";
            newData.Footer = "yuio";

            app.Groups.Modify(1, newData);
        }
    }
}
