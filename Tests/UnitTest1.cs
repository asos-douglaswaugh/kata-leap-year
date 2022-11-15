namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Year_1_is_not_a_leap_year()
    {
        var isLeapYear = IsLeapYear(1);

        Assert.That(isLeapYear, Is.False);
    }

    [Test]
    public void Year_2_is_not_a_leap_year()
    {
        var isLeapYear = IsLeapYear(2);

        Assert.That(isLeapYear, Is.False);
    }

    [Test]
    public void Year_3_is_not_a_leap_year()
    {
        var isLeapYear = IsLeapYear(3);

        Assert.That(isLeapYear, Is.False);
    }

    private static bool IsLeapYear(int year)
    {
        var isLeapYear = false;
        return isLeapYear;
    }
}