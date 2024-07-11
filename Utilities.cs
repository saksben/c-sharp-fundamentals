namespace BethanysPieShopHRM;

internal class Utilities
{
    public static void ManipulatingStrings() {
        string firstName = "Bethany";
        string lastName = "Smith";
        string fullName = firstName + " " + lastName;
        string employeeIdentification = String.Concat(firstName, lastName);
        string empId = firstName.ToLower() + "-" + lastName.ToLower();
    }

    public static void UsingSimpleStrings() {
        string firstName = "Bethany";
        string lastName = "Smith";
        string s;
        s = firstName;
        var userName = "BethanyS";
        userName = userName.ToLower();

        userName = string.Empty;
        userName = "";
    }

    public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked) {
        // Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
        if (numberOfMonthsWorked == 12) {
            return monthlyWage * (numberOfMonthsWorked + 1);
        }

        return monthlyWage * numberOfMonthsWorked;
    }

    public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus) => monthlyWage * numberOfMonthsWorked + bonus;

    // public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus = 0) {
    //     Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
    //     return monthlyWage * numberOfMonthsWorked + bonus;
    // }
    public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus) {
        Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
        return monthlyWage * numberOfMonthsWorked + bonus;
    }
}
