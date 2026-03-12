using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [SetUp]
        public void SetupContactPrecondition()
        {
            if (!app.Contacts.IsContactPresent())
            {
                ContactData preContact = new ContactData
                {
                    FirstName = "Test",
                    LastName = "Test"
                };
                app.Contacts.Create(preContact);
            }
        }

        [Test]
        public void ContactRemovalTest()
        {
            app.Contacts.Remove(1);
        }
    }
}
