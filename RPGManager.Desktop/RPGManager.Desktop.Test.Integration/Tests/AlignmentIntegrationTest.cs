namespace RPGManager.Desktop.Test.Integration.Tests;

[DependsOn( typeof( GameSystemIntegrationTest ) )]
public class AlignmentIntegrationTest : IntegrationTestBase<AlignmentModel>
{
    public AlignmentIntegrationTest( Dictionaries rules, HttpClient client ) : base( rules, client )
    {
    }

    //protected override async Task Create()
    //{
    //    var url = "alignment/create";
    //    Rules.Alignments.Add( AlignmentKey.CHAOTIC_AND_EVIL, await Post<AlignmentModel>( url, new ChaoticEvilAlignment( Rules ) ) );
    //    Rules.Alignments.Add( AlignmentKey.CHAOTIC_AND_GOOD, await Post<AlignmentModel>( url, new ChaoticGoodAlignment( Rules ) ) );
    //    Rules.Alignments.Add( AlignmentKey.CHAOTIC_AND_NEUTRAL, await Post<AlignmentModel>( url, new ChaoticNeutralAlignment( Rules ) ) );
    //    Rules.Alignments.Add( AlignmentKey.LAWFUL_AND_EVIL, await Post<AlignmentModel>( url, new LawfulEvilAlignment( Rules ) ) );
    //    Rules.Alignments.Add( AlignmentKey.LAWFUL_AND_GOOD, await Post<AlignmentModel>( url, new LawfulGoodAlignment( Rules ) ) );
    //    Rules.Alignments.Add( AlignmentKey.LAWFUL_AND_NEUTRAL, await Post<AlignmentModel>( url, new LawfulNeutralAlignment( Rules ) ) );
    //    Rules.Alignments.Add( AlignmentKey.NEUTRAL_AND_EVIL, await Post<AlignmentModel>( url, new NeutralEvilAlignment( Rules ) ) );
    //    Rules.Alignments.Add( AlignmentKey.NEUTRAL_AND_GOOD, await Post<AlignmentModel>( url, new NeutralGoodAlignment( Rules ) ) );
    //    Rules.Alignments.Add( AlignmentKey.TRUE_NEUTRAL, await Post<AlignmentModel>( url, new TrueNeutralAlignment( Rules ) ) );
    //}

    //protected override async Task Recover()
    //{
    //    var url = "alignment/recover";
    //    var alignments = await Get<IEnumerable<AlignmentModel>>( url );

    //    foreach ( var alignment in alignments )
    //        Console.WriteLine( alignment.Name );
    //}
}