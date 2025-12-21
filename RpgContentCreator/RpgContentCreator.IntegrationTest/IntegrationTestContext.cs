namespace RpgContentCreator.IntegrationTest;

internal class IntegrationTestContext
{
    private readonly List<IntegrationTestBase> _tests;

    public IntegrationTestContext( List<IntegrationTestBase> tests )
    {
        _tests = tests;
    }



    public void Execute()
    {
        foreach ( var test in _tests )
            test.Execute();
    }
}