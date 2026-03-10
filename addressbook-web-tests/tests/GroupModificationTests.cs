using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("GroupNameModified");
            newData.Header = "HeaderModified";
            newData.Footer = "FooterModified";

            app.Groups.Modify(1, newData);
        }
    }
}
