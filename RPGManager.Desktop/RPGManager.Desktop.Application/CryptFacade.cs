using DevToolz.Library.Encryption.Interfaces;
using Microsoft.Extensions.Options;
using RPGManager.Desktop.Application.Options;
using RPGManager.Desktop.Domain.Interfaces;

namespace RPGManager.Desktop.Application;

public class CryptFacade : ICrypt
{
    private readonly ICryptAlgorithm _algorithm;
    private readonly Encryption encryptionOption;

    public CryptFacade(ICryptAlgorithm cryptAlgorithm, IOptions<Encryption> option)
    {
        _algorithm = cryptAlgorithm;
        encryptionOption = option.Value;
    }

    public string Decrypt( string plainText )
    {
        //var key = _configuration[ "Encryption:Key" ] 
        var key = encryptionOption.Key
            ?? throw new InvalidOperationException( "Encryption:Key não configurada" );

        return _algorithm.Decrypt( plainText, key );
    }

    public string Encrypt( string plainText )
    {
        //var key = _configuration[ "Encryption:Key" ] 
        var key = encryptionOption.Key
            ?? throw new InvalidOperationException( "Encryption:Key não configurada" );

        return _algorithm.Encrypt( plainText, key );
    }

    public string Hash( string plainText )
    {
        return BCrypt.Net.BCrypt.HashPassword( plainText );
    }
}