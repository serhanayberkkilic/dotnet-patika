using System;



namespace Namespace
{
    
    class Agenda
    {
        private string name;
        private string surname;
        private string phone;

        private static  List<Agenda> agendaList = new List<Agenda>();

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value;}
        public string Phone { get => phone; set => phone = value; }

        static Agenda()
        {
            agendaList.Add(new Agenda("Ali", "Veli", "1234567890"));
            agendaList.Add(new Agenda("Ayşe", "Fatma", "1234567890"));
            agendaList.Add(new Agenda("Mehmet", "Ahmet", "1234567890"));
            agendaList.Add(new Agenda("Zeynep", "Kübra", "1234567890"));
            agendaList.Add(new Agenda("Merve", "Selin", "1234567890"));
        }
        public Agenda(string name, string surname, string phone)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
        }

        public Agenda()
        {
        }

        public void Add(){
            agendaList.Add(new Agenda(this.name, this.surname, this.phone));
            Console.WriteLine("{0} Added to agenda", this.name+" "+this.surname);
        }

        public void Delete(string phone){
            for (int i = 0; i < agendaList.Count; i++)
            {
                if (agendaList[i].phone == phone)
                {
                    agendaList.RemoveAt(i);
                }
            }
            Console.WriteLine("{0} Deleted from agenda", this.name+" "+this.surname);
        }

        public void Update(string Phone,Agenda agenda){

            Console.WriteLine(agenda.name);
            if (agenda.name != null && agenda.surname != null && agenda.phone != null)
            {
                agenda = new Agenda(agenda.name, agenda.surname, agenda.phone);
                for (int i = 0; i < agendaList.Count; i++)
                {
                    if (agendaList[i].phone == Phone)
                    {
                        agendaList[i].name = agenda.name;
                        agendaList[i].surname = agenda.surname;
                        agendaList[i].phone = agenda.phone;
                    
                        Console.WriteLine("Name: {0} Surname: {1} Phone: {2}", agendaList[i].name, agendaList[i].surname, agendaList[i].phone);
                        Console.WriteLine("{0} Updated in agenda", this.name+" "+this.surname);
                    }
                    else
                    {
                        Console.WriteLine("There is no such phone number in the agenda.");
                    }

                }
            }
            else
            {
                Console.WriteLine("You must enter a name, surname and phone number to update.");
            }
        }

        public void Search(string phone){
            for (int i = 0; i < agendaList.Count; i++)
            {
                if (agendaList[i].phone == phone)
                {
                    Console.WriteLine("Name: {0} Surname: {1} Phone: {2}", agendaList[i].name, agendaList[i].surname, agendaList[i].phone);
                }
            }
        }

        public void Show(string sortDirection){


            static void writeList(List<Agenda> agendaList){
                foreach (var item in agendaList)
                {
                    Console.WriteLine("Name: {0} Surname: {1} Phone: {2}", item.name, item.surname, item.phone);
                }

            }
            
            switch (sortDirection.ToLower())
            {
                case "asc":
                    writeList(agendaList.OrderBy(x => x.name).ToList());
                    List<Agenda> sortedAgendaList = agendaList.OrderBy(x => x.name).ToList();
                    break;
                case "desc":
                    writeList(agendaList.OrderByDescending(x => x.name).ToList());
                    break;
                default:
                    Console.WriteLine("Invalid sort direction.");
                    break;
            }

        }
        
    }

}