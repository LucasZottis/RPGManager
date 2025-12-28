namespace RPGManager.Desktop.Test.Integration.Tests;

[DependsOn( typeof( GameSystemIntegrationTest ) )]
public class DamageTypeIntegrationTest : IntegrationTestBase<DamageTypeModel>
{
    public DamageTypeIntegrationTest( Dictionaries rules, HttpClient client ) : base( rules, client )
    {
    }

    //protected override async Task Create()
    //{
    //    var url = "damage-type/create";
    //    Rules.DamageTypes.Add( DamageTypeKeys.ACID, await Post<DamageTypeModel>( url, new Acid() ) );
    //    Rules.DamageTypes.Add( DamageTypeKeys.BLUDGEONING, await Post<DamageTypeModel>( url, new Bludgeoning() ) );
    //    Rules.DamageTypes.Add( DamageTypeKeys.COLD, await Post<DamageTypeModel>( url, new Cold() ) );
    //    Rules.DamageTypes.Add( DamageTypeKeys.FIRE, await Post<DamageTypeModel>( url, new Fire() ) );
    //    Rules.DamageTypes.Add( DamageTypeKeys.FORCE, await Post<DamageTypeModel>( url, new Force() ) );
    //    Rules.DamageTypes.Add( DamageTypeKeys.LIGHTNING, await Post<DamageTypeModel>( url, new Lightning() ) );
    //    Rules.DamageTypes.Add( DamageTypeKeys.NECROTIC, await Post<DamageTypeModel>( url, new Necrotic() ) );
    //    Rules.DamageTypes.Add( DamageTypeKeys.PIERCING, await Post<DamageTypeModel>( url, new Piercing() ) );
    //    Rules.DamageTypes.Add( DamageTypeKeys.POISON, await Post<DamageTypeModel>( url, new Poison() ) );
    //    Rules.DamageTypes.Add( DamageTypeKeys.PSYCHIC, await Post<DamageTypeModel>( url, new Psychic() ) );
    //    Rules.DamageTypes.Add( DamageTypeKeys.RADIANT, await Post<DamageTypeModel>( url, new Radiant() ) );
    //    Rules.DamageTypes.Add( DamageTypeKeys.SLASHING, await Post<DamageTypeModel>( url, new Slashing() ) );
    //    Rules.DamageTypes.Add( DamageTypeKeys.THUNDER, await Post<DamageTypeModel>( url, new Thunder() ) );
    //}

    //protected override async Task Recover()
    //{
    //    var url = "damage-type/recover";
    //    var list = await Get<IEnumerable<DamageTypeModel>>( url );

    //    foreach ( var damageType in list )
    //        Console.WriteLine( damageType.Name );
    //}
}