using PlaySoftBeta.Models;

namespace PlaySoftBeta.Services;

public static class UserService
{
    static List<User>? Users { get; set; }
    static int nextId = 1;

    //   private static readonly RepositoryContext _context;

    static UserService()
    {
        Users = new List<User> { };
    }

    //public static List<User> GetAll() => Users;

    public static User? Get(string email, string password)
    {
        //comprobar que el email y la contraseña coinciden con alguno de la db
        User u = new User();
        u.get

        return u;
    }

    public static void Add(User user)
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
