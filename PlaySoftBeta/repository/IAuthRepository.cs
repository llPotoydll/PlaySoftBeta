using PlaySoftBeta.Models;

namespace PlaySoftBeta.Repository;

public interface IAuthRepositoy : IDisposable
{
    User GetUserByEmail(String userEmail);
    void Save();
}
