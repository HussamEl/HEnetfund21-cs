using _01_HuExercice3.Handlers;
using _01_HuExercice3.Models.Forms;

IAuthHandler authManager = new AuthHandler();

var signUpForm = new SignUpForm();

Console.WriteLine("Registrering");
Console.WriteLine("--------------------------------------------------");

Console.Write("Förnamn: ");
signUpForm.FirstName = Console.ReadLine();
Console.Write("Efternamn: ");
signUpForm.LastName = Console.ReadLine();
Console.Write("Email: ");
signUpForm.Email = Console.ReadLine();
Console.Write("Lösenord: ");
signUpForm.Password = Console.ReadLine();
Console.Write("Adress: ");
signUpForm.AddressLine = Console.ReadLine();
Console.Write("Postnummer: ");
signUpForm.ZipCode = Console.ReadLine();
Console.Write("Stad: ");
signUpForm.City = Console.ReadLine();

Console.Clear();
authManager.SignUp(signUpForm);





Console.ReadKey();