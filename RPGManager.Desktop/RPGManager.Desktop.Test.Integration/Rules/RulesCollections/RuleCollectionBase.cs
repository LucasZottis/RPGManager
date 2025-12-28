namespace RPGManager.Desktop.Test.Integration.Rules.RulesCollections;

public class RuleCollectionBase<TModel>
{
    protected IDictionary<string, TModel> Dictionary { get; private set; }

    public RuleCollectionBase()
    {
        Dictionary = new Dictionary<string, TModel>();
    }

    public void Add( string key, TModel model )
    {
        if ( Dictionary.ContainsKey( key ) )
            return;

        Dictionary.Add( key, model );
    }

    public TModel Get( string key )
        => Dictionary[ key ];
}