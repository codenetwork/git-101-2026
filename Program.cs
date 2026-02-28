string[] attendees = 
[
    "William Qu",
    "Angus Wong",
    "Ryan Chang"
    // Add your name here!
];

Console.WriteLine("Hello World!");
Console.WriteLine("""
   ____          _        _   _      _                      _
  / ___|___   __| | ___  | \ | | ___| |___      _____  _ __| | __
 | |   / _ \ / _` |/ _ \ |  \| |/ _ \ __\ \ /\ / / _ \| '__| |/ /
 | |__| (_) | (_| |  __/ | |\  |  __/ |_ \ V  V / (_) | |  |   <
  \____\___/ \__,_|\___| |_| \_|\___|\__| \_/\_/ \___/|_|  |_|\_\

""");
Console.WriteLine("Welcome to the Git 101 Workshop for Code Network!");
Console.WriteLine("\nThese are the awesome coders that attended this workshop:");
Console.WriteLine("================================================================");

foreach (string attendee in attendees)
{
    Console.WriteLine($"- {attendee}");
}