using EducationCenter.Service.Interfaces.Security;

namespace EducationCenter.Service.Security;

public class PasswordHasher : IPasswordHasher
{
    private const string _key = "";
    public (string passwordHash, string salt) Hash(string password)
    {
        string salt = GenerateSalt();
        string strongpassword = _key + salt + password;
        string hash = BCrypt.Net.BCrypt.HashPassword(strongpassword);
        return (passwordHash: hash,
                salt: salt);
    }

    private string GenerateSalt()
    {
        string salt = Guid.NewGuid().ToString();
        return salt;
    }
}
