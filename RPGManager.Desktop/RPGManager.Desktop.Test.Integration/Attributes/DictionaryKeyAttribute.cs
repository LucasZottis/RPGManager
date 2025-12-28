namespace RPGManager.Desktop.Test.Integration.Attributes;

[AttributeUsage( AttributeTargets.Class, Inherited = false )]
public class DictionaryKeyAttribute : Attribute
{
    public string Key { get; set; }

    public DictionaryKeyAttribute(string key)
    {
        Key = key;
    }
}