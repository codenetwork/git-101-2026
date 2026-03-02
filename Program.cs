string[] attendees =
[
    "William Qu",
    "Angus Wong",
    "Ryan Chang",
    "Ethan Burnet",
    "Christopher Rudel",
    "Nikita Bukhtoiarov",
    "Spongebob Squarepants",
    "Inano",
    "Kevin",
    "Aidan Smith",
  	"Hamid",
    "Alan",
    "Manny",
    "Jeffrey Chan",
    // Add your name above this line! (Do not delete this)
];

Console.WriteLine("Hello World!");
Console.WriteLine("""
   ____                   _   _      _                      _
  / ___|___   ___   ___  | \ | | ___| |___      _____  _ __| | __
 | |   / _ \ / _ \ / _ \ |  \| |/ _ \ __\ \ /\ / / _ \| '__| |/ /
 | |__| (_) | (_) | (_) || |\  |  __/ |_ \ V  V / (_) | |  |   <
  \____\___/ \___/ \___/ |_| \_|\___|\__| \_/\_/ \___/|_|  |_|\_\

""");
Console.WriteLine("Welcome to the Git 101 Workshop for Code Network!");
Console.WriteLine("\nThese are the awesome coders that attended this workshop:");
Console.WriteLine("================================================================");

foreach (string attendee in attendees)
{
    Console.WriteLine($"- {attendee}");
}
