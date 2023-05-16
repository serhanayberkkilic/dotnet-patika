using Card;




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
            Console.WriteLine("6-Count");
            Console.WriteLine("7-Exit");
        }

        public void ChoiceProcess(int choice)
        {
            CardClass card = new CardClass(); 
            switch (choice)
            {
                case 1:
                    Console.WriteLine("*******Add*******");
                    Console.Write("content: ");
                    string content = Console.ReadLine();
                    Console.Write("description: ");
                    string description = Console.ReadLine();
                    Console.Write("userId: ");
                    int userId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("size: ");
                    string size = Console.ReadLine();
                    card.AddCard(new CardClass(content, description, userId,size));
                    break;
                case 2:
                    Console.WriteLine("*******Delete*******");
                    Console.Write("content: ");
                    string contentDelete = Console.ReadLine();
                    card.RemoveCard(contentDelete);
                    break;
                case 3:
                    Console.WriteLine("*******Update*******");
                    Console.Write("content: ");
                    string contentUpdate = Console.ReadLine();
                    Console.Write("description: ");
                    string descriptionUpdate = Console.ReadLine();
                    Console.Write("userId: ");
                    int userIdUpdate = Convert.ToInt32(Console.ReadLine());
                    Console.Write("size: ");
                    string sizeUpdate = Console.ReadLine();
                    card.UpdateCard(contentUpdate, descriptionUpdate, userIdUpdate, sizeUpdate);
                    break;
                case 4:
                    Console.WriteLine("*******Search*******");
                    Console.Write("content: ");
                    string contentSearch = Console.ReadLine();
                    card.SearchCard(contentSearch);
                    break;
                case 5:
                    Console.WriteLine("*******Show*******");
                    card.PrintCards();
                    break;
                case 6:
                    Console.WriteLine("*******Count*******");
                    card.CountCards();
                    break;
                case 7:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }



    }
}