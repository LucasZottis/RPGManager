namespace RPGManager.Desktop.Domain.Interfaces;

public interface ICrypt
{
    string Encrypt(string plainText);
    string Decrypt(string plainText);
    string Hash( string plainText );
}