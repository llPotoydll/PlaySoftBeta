using PlaySoftBeta.Models;

namespace PlaySoftBeta.Services;

public static class UserService
{
    static List<User>? Users { get; set; }
    static int nextId = 1;

    static UserService()
    {
        Users = new List<User>
        {
            new User { userID = 0, name = "pepe", allPlayLists = null, password = "123" },
            new User { userID = 1, name = "pablo", allPlayLists = null, password = "321" }
        };
    }
    public static List<User> GetAll() => Users;

    public static User? Get(int id) => Users.FirstOrDefault(p => p.userID == id);

    public static void Add(User user)
    {
        try
        {

            user.userID = nextId++;
            Users.Add(user);

        }
        catch (Exception e)
        {

        }
    }

    public static void Delete(int id)
    {
        var user = Get(id);
        if (user is null)
            return;

        Users.Remove(user);
    }

    public static void Update(User user)
    {
        var index = Users.FindIndex(p => p.userID == user.userID);
        if (index == -1)
            return;

        Users[index] = user;
    }
}