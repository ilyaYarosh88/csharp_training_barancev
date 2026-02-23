using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {     
        [Test]
        public void AddNewContactTest()
        {
            navigator.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigator.GoToAddContactPage();
            ContactData contact = new ContactData();
            contact.FirstName = "TestFirstName";
            contact.LastName = "TestLastName";
            contactHelper.FillContactForm(contact);
            contactHelper.SubmitContactCreation();
        }    
    }
}
