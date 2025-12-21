using RpgContentCreator.Domain.Models;
using RpgContentCreator.IntegrationTest.Models.AbilitiesScores;

namespace RpgContentCreator.IntegrationTest.Tests;

public class AbilityScoreIntegrationTest : IntegrationTestBase
{
    public AbilityScoreIntegrationTest( GameSystemRules rules, HttpClient client ) : base( rules, client )
    {
    }

    private async Task AddAbilityScore( string key, AbilityScoreModel abilityScore )
    {
        var model = await Post<AbilityScoreModel>( "ability-score/add", abilityScore );

        if ( model == null )
            return;

        Rules.AddAbilityScore( key, model );
    }

    public override async Task Execute()
    {
        await AddAbilityScore( AbilityScoreKeys.CHARISMA, new Charisma( Rules ) );
        await AddAbilityScore( AbilityScoreKeys.CONSTITUTION, new Constitution( Rules ) );
        await AddAbilityScore( AbilityScoreKeys.DEXTERITY, new Dexterity( Rules ) );
        await AddAbilityScore( AbilityScoreKeys.INTELLIGENCE, new Intelligence( Rules ) );
        await AddAbilityScore( AbilityScoreKeys.STRENGTH, new Strength( Rules ) );
        await AddAbilityScore( AbilityScoreKeys.WISDOM, new Wisdom( Rules ) );
    }
}