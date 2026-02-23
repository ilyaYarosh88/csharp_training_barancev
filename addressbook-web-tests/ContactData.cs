namespace WebAddressbookTests
{
    public class ContactData
    {
        private string firstName;
        private string lastName;       

        public string FirstName
        { 
            get 
            { 
                return firstName; 
            }
            set 
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set 
            {
                lastName = value;
            }
        }
    }
}

