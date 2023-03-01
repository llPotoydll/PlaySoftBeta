using PlaySoftBeta.Models;
using PlaySoftBeta.Repository;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Services;

public class UserServiceImpl : IUserService
{
    static List<User>? Users { get; set; }
    static int nextId = 1;
    private IUserRepositoy userRepositoy;

    //   private static readonly RepositoryContext _context;

    static UserServiceImpl()
    {
        Users = new List<User>
        {
            new User { UKID = 0, username = "pepe", email = "carlosgonzalez@gmail.com", password = "123" },
            new User { UKID = 1, username = "pablo", email = "prueba@gmail.com", password = "321" }
        };
    }

    //public static List<User> GetAll() => Users;

}
