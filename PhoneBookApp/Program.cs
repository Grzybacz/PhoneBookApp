
using PhoneBookApp;

Console.WriteLine("Hello in phone book app");

Console.WriteLine("Press:");
Console.WriteLine("1 - if you have add new contact");
Console.WriteLine("2 - if you have show all contacts");
Console.WriteLine("3 - if you have show name by number");
Console.WriteLine("4 - if you have show contact by phrase");
Console.WriteLine("5 - if you have delete existing contact");
Console.WriteLine("x - if you have escape");


var phoneBook= new PhoneBook();



while(true)
{
    Console.WriteLine("Select operation");
    var selectOption = Console.ReadLine();
    switch (selectOption)
    {
        case "1":
            
            
            while (true)
            {
                Console.WriteLine("Insert name");
                var insertName = Console.ReadLine();
                var lenName = insertName.Length;
                Console.WriteLine("Insert phone number");
                var insertNumber = Console.ReadLine();
                var len = insertNumber.Length;
                if(len!=9 & lenName<3)
                {
                Console.WriteLine("Invalid number or name");
                Console.WriteLine("Insert correct number and name");
                }
                else if(len == 9 & lenName >= 3)
                {
                var contact = new Contact(insertName, insertNumber);
                phoneBook.AddContact(contact);
                    break;
                }
                
            }
           
           
            break;
           

        case "2":
            
            foreach (var con in phoneBook.Contacts)
            {
                Console.WriteLine($"Contact: {con.Name } {con.Number}");
                
            }
            break;
        
        case "3":
            Console.WriteLine("Insert serching name by number");
            var number = Console.ReadLine();
            phoneBook.DisplayContactByNumber(number);            
            break;
        
        case "4":
            Console.WriteLine("Insert serching name by phrase");
            var namebyphrase= Console.ReadLine();
            phoneBook.DisplayContactByPhrase(namebyphrase);
            break;

        case "5":
            Console.WriteLine("Insert name to delete contact");
            var deleteContact = Console.ReadLine();
            phoneBook.DeleteContactByName(deleteContact);
            break;       

        case "x":
            return;

        default:
            Console.WriteLine("Invalid number. Insert correct number");
            break;
    }
        
}




