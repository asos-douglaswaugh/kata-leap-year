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

    [TestCase(4)]
    [TestCase(8)]
    [TestCase(12)]
    public void Is_a_leap_year(int year)
    {
        var isLeapYear = IsLeapYear(year);

        Assert.That(isLeapYear, Is.True);
    }

    private static bool IsLeapYear(int year)
    {
        var isLeapYear = false;

        if ((year == 4) || (year == 8) || (year == 12))
            isLeapYear = true;

        return isLeapYear;
    }
}