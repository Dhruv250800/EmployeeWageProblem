// See https://aka.ms/new-console-template for more information

//UC1 - Check Employee Presence

int presence = -0;
Random random = new Random();

int check = random.Next(0,2);

if(check == presence)
{
    Console.WriteLine("Employee is Present");
}
else
{
    Console.WriteLine("Employee is Absent");
}
