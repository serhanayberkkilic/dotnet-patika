

namespace Namespace
{

    class Process
    {

        public void ChoiceProcess()
        {
            Console.WriteLine("Plese enter your choice: ");
            Console.WriteLine("1-Add");
            Console.WriteLine("2-Delete");
            Console.WriteLine("3-Update");
            Console.WriteLine("4-Search");
            Console.WriteLine("5-Show");
            Console.WriteLine("6-Exit");
        }

        public void ChoiceProcess(int choice)
        {
            Agenda agenda = new Agenda();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("*******Add*******");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Surname: ");
                    string surname = Console.ReadLine();
                    Console.Write("Phone: ");
                    string phone = Console.ReadLine();
                    agenda.Name = name;
                    agenda.Surname = surname;
                    agenda.Phone = phone;
                    agenda.Add();
                    break;
                case 2:
                    Console.WriteLine("*******Delete*******");
                    Console.Write("Phone: ");
                    string phoneDelete = Console.ReadLine();
                    agenda.Delete(phoneDelete);
                    break;
                case 3:
                    Console.WriteLine("*******Update*******");
                    Console.Write("Phone: ");
                    string phoneOld = Console.ReadLine();
                    Console.Write("Name: ");
                    string nameUpdate = Console.ReadLine();
                    Console.Write("Surname: ");
                    string surnameUpdate = Console.ReadLine();
                    Console.Write("Phone: ");
                    string phoneUpdate = Console.ReadLine();
                    agenda.Update(phoneOld, new Agenda(nameUpdate, surnameUpdate, phoneUpdate));
                    break;
                case 4:
                    Console.WriteLine("*******Search*******");
                    Console.Write("Phone: ");
                    string phoneSearch = Console.ReadLine();
                    agenda.Search(phoneSearch);
                    break;
                case 5:
                    Console.WriteLine("*******Show*******");
                    Console.Write("Sort by (a)scending-(asc) or (d)escending(desc)? ");
                    string sortDirection = Console.ReadLine();

                    agenda.Show(sortDirection);
                    break;
                case 6:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }



    }
}