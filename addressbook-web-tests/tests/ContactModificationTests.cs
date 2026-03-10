using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData();
            newData.FirstName = "FirstNameModified";
            newData.LastName = "LastNameModified";
            
            app.Contacts.Modify(1, newData);
        }
    }
}
