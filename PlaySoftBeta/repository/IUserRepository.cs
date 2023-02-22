using PlaySoftBeta.Models;

namespace PlaySoftBeta.Repository;

    public interface IUserRepositoy: IDisposable
    {
       // IEnumerable<Student> GetStudents();
        User GetUserByEmail(String userEmail);
       /* void InsertStudent(Student student);
        void DeleteStudent(int studentID);
        void UpdateStudent(Student student);*/
        void Save();
    }
