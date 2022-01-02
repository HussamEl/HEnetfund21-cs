using _01_HuExercice2.Models;

namespace _01_HuExercice2.Services
{
    internal class EventService
    {
        private static List<Guest> guestsList = new List<Guest>();

        public static void CreateGuest()
        {
            Guest _guest = new Guest();

            Console.Write("               +++++++++++++++++++++++++++\n");
            Console.Write("               Förnamn: ");
           _guest.FirstName = Console.ReadLine();    

            Console.Write("               Efteramn: ");
            _guest.LastName = Console.ReadLine();

            Console.Write("               E-post: ");
            _guest.Email = Console.ReadLine();

            Console.Write("               Speciella önskemål: ");
            _guest.SpecialRequests = Console.ReadLine();

            guestsList.Add(_guest);
        }

        public static void ShowGuests()
        {
            foreach (var _guest in guestsList)
            {
                Console.WriteLine("");
                Console.WriteLine($"Gästs namn: {_guest.FullName}");
                Console.WriteLine($"Gästs e-post: {_guest.Email}");                
            }           
        }

        public static void RemoveGuest()
        {
            Console.WriteLine("Skriv E-post: ");
            var email = Console.ReadLine();
            guestsList = guestsList.Where(_guest => _guest.Email != email).ToList();
        }

        public  static void GenerateCoupon()
        {
            var code = Guid.NewGuid();
            Console.WriteLine($"Rabattkod: {code}");
        }

        public static void SaveList()
        {
            string[] lines = new string[guestsList.Count]; //0302 01:19:00
            for (int i = 0; i < guestsList.Count; i++)
            {
                lines[i] = $"{guestsList[i].FirstName},{guestsList[i].LastName},{guestsList[i].Email},{guestsList[i].SpecialRequests}";
            }
            File.WriteAllLines(@"d:\guestsList.txt", lines);
        }

        public static void ShowMenu()
        {
            int choice = -1;

            do
            {
                Console.WriteLine("     ###  MENU  ###");
                Console.WriteLine("     1. Skappa en gäst ");
                Console.WriteLine("     2. Ta bort en gäst");
                Console.WriteLine("     3. Lista upp gäster");
                Console.WriteLine("     4. Skapa en rabattkod");
                Console.WriteLine("     5. Spara gästerlistan");
                Console.WriteLine("     0. Avsluta");
                Console.Write("\nVälj ett av alternativen ovan: ");

                choice = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        CreateGuest();
                        break;
                    case 2:
                        RemoveGuest();
                        break;
                    case 3:
                        ShowGuests();
                        Console.ReadKey();
                        break;
                    case 4:
                        GenerateCoupon();
                        Console.ReadKey();
                        break;
                    case 5: SaveList();
                        break;
                }
                Console.Clear();
            }
            while (choice != 0);        
        }
    }
}
