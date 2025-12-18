namespace RpgContentCreator.Library.Models;

internal class NLogConfiguration
{
    public bool Async { get; set; }
    public IEnumerable<TargetConfiguration> Targets { get; set; }
    public IEnumerable<RuleConfiguration> Rules { get; set; }
}