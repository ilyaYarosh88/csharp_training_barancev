using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {     
        [Test]
        public void AddNewContactTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToAddContactPage();
            ContactData contact = new ContactData();
            contact.FirstName = "TestFirstName";
            contact.LastName = "TestLastName";
            app.ContactHelper.FillContactForm(contact);
            app.ContactHelper.SubmitContactCreation();
        }    
    }
}
