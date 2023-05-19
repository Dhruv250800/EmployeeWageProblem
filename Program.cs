// See https://aka.ms/new-console-template for more information

//UC1 - Check Employee Presence

/*
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
*/

//UC2 - Calculating Employee Wage

/*int FullTime = 1;
int hour = 20;
int empHrs = 0;
int empWage = 0;

Random random = new Random();
int empCheck = random.Next(0, 2);
if(empCheck == FullTime)
{
    empHrs = 8;
}
else
{
    empHrs = 0;
}
empWage = empHrs * hour;
Console.WriteLine("Employee Wage : "+empWage);
*/

//UC3 - Add Part Time Employee & Wage

int partTime = 1, fullTime = 2, EmpRatePerHour = 20;
int empHrs = 0;
int empWage = 0;
Random random = new Random();
int empCheck = random.Next(0, 3);
if(empCheck == partTime)
{
    empHrs = 4;
}
else if(empCheck == fullTime)
{
    empHrs = 8;
}
else
{
    empHrs = 0;
}

empWage = empHrs * EmpRatePerHour;
Console.WriteLine("Emp Wage : "+empWage);