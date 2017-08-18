using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMailingSystem;
using Xunit;

namespace EventMailingSystemFixture
{
    public class DirectoryFixture
    {
        [Fact]
        public void Check_if_path_have_correct_directory_path()
        {
            Directory directory = new Directory();
            Assert.Equal("D:/Git Repo/Satish/hrms-event-mailer/EmpRecord",directory.Path);
        }
    }
}
