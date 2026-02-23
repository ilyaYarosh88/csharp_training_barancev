using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {     
        [Test]
        public void AddNewContactTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToAddContactPage();
            ContactData contact = new ContactData();
            contact.FirstName = "TestFirstName";
            contact.LastName = "TestLastName";
            FillContactForm(contact);
            SubmitContactCreation();
        }    
    }
}
