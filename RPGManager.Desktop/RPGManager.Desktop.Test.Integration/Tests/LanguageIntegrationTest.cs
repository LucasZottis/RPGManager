//namespace RPGManager.Desktop.Test.Integration.Tests;

//[DependsOn( typeof( GameSystemIntegrationTest ) )]
//public class LanguageIntegrationTest : IntegrationTestBase<LanguageModel>
//{
//    public LanguageIntegrationTest( Dictionaries rules, HttpClient client ) : base( rules, client )
//    {
//    }

//    //protected override async Task Create()
//    //{
//    //    var url = "language/create";
//    //    Rules.Languages.Add( LanguageKey.ABYSSAL, await Post<LanguageModel>( url, new AbyssalLanguage( Rules ) ) );
//    //    Rules.Languages.Add( LanguageKey.CELESTIAL, await Post<LanguageModel>( url, new CelestialLanguage( Rules ) ) );
//    //    Rules.Languages.Add( LanguageKey.COMMON, await Post<LanguageModel>( url, new CommonLanguage( Rules ) ) );
//    //    Rules.Languages.Add( LanguageKey.DEEP_SPEECH, await Post<LanguageModel>( url, new DeepSpeechLanguage( Rules ) ) );
//    //    Rules.Languages.Add( LanguageKey.DRACONIC, await Post<LanguageModel>( url, new DraconicLanguage( Rules ) ) );
//    //    Rules.Languages.Add( LanguageKey.DWARF, await Post<LanguageModel>( url, new DwarfLanguage( Rules ) ) );
//    //    Rules.Languages.Add( LanguageKey.GIANT, await Post<LanguageModel>( url, new GiantLanguage( Rules ) ) );
//    //    Rules.Languages.Add( LanguageKey.GNOMISH, await Post<LanguageModel>( url, new GnomishLanguage( Rules ) ) );
//    //    Rules.Languages.Add( LanguageKey.GOBLIN, await Post<LanguageModel>( url, new GoblinLanguage( Rules ) ) );
//    //    Rules.Languages.Add( LanguageKey.HALFLING, await Post<LanguageModel>( url, new HalflingLanguage( Rules ) ) );
//    //    Rules.Languages.Add( LanguageKey.INFERNAL, await Post<LanguageModel>( url, new InfernalLanguage( Rules ) ) );
//    //    Rules.Languages.Add( LanguageKey.ORC, await Post<LanguageModel>( url, new OrcLanguage( Rules ) ) );
//    //    Rules.Languages.Add( LanguageKey.PRIMORDIAL, await Post<LanguageModel>( url, new PrimordialLanguage( Rules ) ) );
//    //    Rules.Languages.Add( LanguageKey.SYLVAN, await Post<LanguageModel>( url, new SylvanLanguage( Rules ) ) );
//    //    Rules.Languages.Add( LanguageKey.UNDER_COMMON, await Post<LanguageModel>( url, new UndercommonLanguage( Rules ) ) );
//    //}

//    //protected override async Task Recover()
//    //{
//    //    var url = "language/recover";
//    //    var list = await Get<IEnumerable<LanguageModel>>( url );

//    //    foreach ( var item in list )
//    //        Console.WriteLine( item.Name );
//    //}
//}