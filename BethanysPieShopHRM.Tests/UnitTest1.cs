namespace BethanysPieShopHRM.Tests;

public class UnitTest1
{
    [Fact]
    public void PerformWork_Adds_NumberOfHours()
    {
        // Arrange
        Employee employee = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
        int numberOfHours = 3;

        // Act
        employee.PerformWork(numberOfHours);

        // Assert (that numberOfHours will equal the employee's numberOfHoursWorked)
        Assert.Equal(numberOfHours, employee.numberOfHoursWorked);
    }
    
    [Fact]
    public void PerformWork_Adds_DefaultNumberOfHours_IfNoValueSpecified() {
        // Arrange
        Employee employee = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
        
        // Act
        employee.PerformWork();

        // Assert (that the employee's numberOfHoursWorked will equal 1)
        Assert.Equal(1, employee.numberOfHoursWorked);
    }
}