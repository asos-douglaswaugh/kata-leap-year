namespace Tests;

public class Tests
{
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    [TestCase(100)]
    [TestCase(1997)]
    [TestCase(1800)]
    public void Is_not_a_leap_year(int year)
    {
        var isLeapYear = IsLeapYear(year);

        Assert.That(isLeapYear, Is.False);
    }

    [TestCase(4)]
    [TestCase(8)]
    [TestCase(12)]
    [TestCase(400)]
    [TestCase(1996)]
    [TestCase(1600)]
    public void Is_a_leap_year(int year)
    {
        var isLeapYear = IsLeapYear(year);

        Assert.That(isLeapYear, Is.True);
    }

    private static bool IsLeapYear(int year)
    {
        if (year % 400 == 0)
            return true;

        if (year % 100 == 0)
            return false;

        if (year % 4 == 0)
            return true;

        return false;
    }
}