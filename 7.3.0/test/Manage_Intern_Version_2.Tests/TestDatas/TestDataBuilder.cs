using Manage_Intern_Version_2.EntityFrameworkCore;

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
            //create test data here...
        }
    }
}