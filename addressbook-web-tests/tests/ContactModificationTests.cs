using NUnit.Framework;
using OpenQA.Selenium;
using System.ComponentModel.Design;
using System.Security.Principal;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase 
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
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData
            {
                FirstName = "FirstNameModified",
                LastName = "LastNameModified"
            };
            app.Contacts.Modify(1, newData);
        }
    }
}
