namespace CoffeeMaker.Specs;

public class UnitTest1
{
    [Scenario]
    public void Scenario1()
    {
        "then true is true"
            .x(() => true.Should().BeTrue());
    }
}