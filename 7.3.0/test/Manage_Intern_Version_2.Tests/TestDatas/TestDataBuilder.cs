using Manage_Intern_Version_2.EntityFrameworkCore;
using Manage_Intern_Version_2.Users;

namespace Manage_Intern_Version_2.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly Manage_Intern_Version_2DbContext _context;

        public TestDataBuilder(Manage_Intern_Version_2DbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.Users.AddRange(
           new User("XuanPhuoc", "123","cao Phuoc", "0345757092", "caophuoc6@gmail.com"),
           new User("XuanPhuoc2", "1233", "cao Phuoc", "0345757092", "caophuoc7@gmail.com")
           );
        }
    }
}