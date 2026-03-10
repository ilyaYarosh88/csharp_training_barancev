using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {     
        [Test]
        public void AddNewContactTest()
        {   
            ContactData contact = new ContactData();
            contact.FirstName = "TestFirstName";
            contact.LastName = "TestLastName";

            app.Contacts.Create(contact);
        }

        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData contact = new ContactData();
            contact.FirstName = "";
            contact.LastName = "";

            app.Contacts.Create(contact);
        }
    }
}
