namespace RPGManager.Desktop.Test.Integration.Tests;

[DependsOn( typeof( GameSystemIntegrationTest ) )]
public class AbilityScoreIntegrationTest : IntegrationTestBase<AbilityScoreModel>
{
    public AbilityScoreIntegrationTest( Dictionaries rules, HttpClient client ) : base( rules, client )
    {
    }

    //protected override async Task Create()
    //{
    //    var url = "ability-score/create";
    //    Rules.Abilities.Add( AbilityScoreKeys.CHARISMA, await Post<AbilityScoreModel>( url, new Charisma( Rules ) ) );
    //    Rules.Abilities.Add( AbilityScoreKeys.CONSTITUTION, await Post<AbilityScoreModel>( url, new Constitution( Rules ) ) );
    //    Rules.Abilities.Add( AbilityScoreKeys.DEXTERITY, await Post<AbilityScoreModel>( url, new Dexterity( Rules ) ) );
    //    Rules.Abilities.Add( AbilityScoreKeys.INTELLIGENCE, await Post<AbilityScoreModel>( url, new Intelligence( Rules ) ) );
    //    Rules.Abilities.Add( AbilityScoreKeys.STRENGTH, await Post<AbilityScoreModel>( url, new Strength( Rules ) ) );
    //    Rules.Abilities.Add( AbilityScoreKeys.WISDOM, await Post<AbilityScoreModel>( url, new Wisdom( Rules ) ) );
    //}

    //protected override async Task Recover()
    //{
    //    var url = "ability-score/recover";
    //    var abilities = await Get<IEnumerable<AbilityScoreModel>>( url );

    //    foreach ( var ability in abilities )
    //        Console.WriteLine( ability.Name );
    //}
}