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
        var isLeapYear = false;

        Assert.That(isLeapYear, Is.False);
    }

    [Test]
    public void Year_2_is_not_a_leap_year()
    {
        var isLeapYear = false;

        Assert.That(isLeapYear, Is.False);
    }
}