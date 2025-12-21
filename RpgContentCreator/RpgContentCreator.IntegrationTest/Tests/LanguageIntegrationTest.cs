using RpgContentCreator.Domain.Models;
using RpgContentCreator.IntegrationTest.Models.Languages;

namespace RpgContentCreator.IntegrationTest.Tests;

public class LanguageIntegrationTest : IntegrationTestBase
{
    public LanguageIntegrationTest( GameSystemRules rules, HttpClient client ) : base( rules, client )
    {
    }

    private async Task AddLanguage( string key, LanguageModel language )
    {
        var model = await Post<LanguageModel>( "language/add", language );

        if ( model == null )
            return;

        Rules.AddLanguage( key, model );
    }

    public override async Task Execute()
    {
        await AddLanguage( LanguageKey.ABYSSAL, new AbyssalLanguage( Rules ) );
        await AddLanguage( LanguageKey.CELESTIAL, new CelestialLanguage( Rules ) );
        await AddLanguage( LanguageKey.COMMON, new CommonLanguage( Rules ) );
        await AddLanguage( LanguageKey.DEEP_SPEECH, new DeepSpeechLanguage( Rules ) );
        await AddLanguage( LanguageKey.DRACONIC, new DraconicLanguage( Rules ) );
        await AddLanguage( LanguageKey.DWARF, new DwarfLanguage( Rules ) );
        await AddLanguage( LanguageKey.GIANT, new GiantLanguage( Rules ) );
        await AddLanguage( LanguageKey.GNOMISH, new GnomishLanguage( Rules ) );
        await AddLanguage( LanguageKey.GOBLIN, new GoblinLanguage( Rules ) );
        await AddLanguage( LanguageKey.HALFLING, new HalflingLanguage( Rules ) );
        await AddLanguage( LanguageKey.INFERNAL, new InfernalLanguage( Rules ) );
        await AddLanguage( LanguageKey.ORC, new OrcLanguage( Rules ) );
        await AddLanguage( LanguageKey.PRIMORDIAL, new PrimordialLanguage( Rules ) );
        await AddLanguage( LanguageKey.SYLVAN, new SylvanLanguage( Rules ) );
        await AddLanguage( LanguageKey.UNDER_COMMON, new UndercommonLanguage( Rules ) );
    }
}