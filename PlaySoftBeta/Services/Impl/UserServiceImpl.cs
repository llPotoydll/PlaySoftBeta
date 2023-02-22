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
        Users = new List<User> { };
    }

    //public static List<User> GetAll() => Users;

    public void getUserByEmail(string email, string password)
    {
        //comprobar que el email y la contraseña coinciden con alguno de la db
        User user  = userRepositoy.GetUserByEmail(email);
        if(user.password.Equals(password)){
            //iniciar sesion si
        }else{
            //error
        }
        User u = new User();

    }

    public void createNewUser(String user)
    {
        //añadir nuevo usuario
    }

    /*public static void Delete(int id)
    {
        if (_context.Users == null)
        {
            return NotFound();
        }
        var user = await _context.Users.FindAsync(id);
        if(user == null){
            return NotFound();
        }

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();

        return NoContent();
    }*/

    /*public static void Update(User user)
    {
        if (id != user.userID)
        {
            return BadRequest();
        }

        _context.Entry(user).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!UserExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }
        return NoContent();
    }*/
}
