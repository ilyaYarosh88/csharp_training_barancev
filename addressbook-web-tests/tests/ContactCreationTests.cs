using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {     
        [Test]
        public void AddNewContactTest()
        {            
            app.Navigator.GoToAddContactPage();
            ContactData contact = new ContactData();
            contact.FirstName = "TestFirstName";
            contact.LastName = "TestLastName";
            app.Contacts
                .FillContactForm(contact)
                .SubmitContactCreation();
        }    
    }
}
