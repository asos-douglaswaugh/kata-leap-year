namespace Tests;

public class Tests
{
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    public void Is_not_a_leap_year(int year)
    {
        var isLeapYear = IsLeapYear(year);

        Assert.That(isLeapYear, Is.False);
    }

    private static bool IsLeapYear(int year)
    {
        var isLeapYear = false;
        return isLeapYear;
    }
}