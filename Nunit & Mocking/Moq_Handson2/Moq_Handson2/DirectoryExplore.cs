using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
namespace Moq_Handson2
{
    public class DirectoryExplore
    {
        public interface IDirectoryExplorer

        {

            ICollection<string> GetFiles(string path);

        }
        public class DirectoryExplorer : IDirectoryExplorer

        {

            public ICollection<string> GetFiles(string path)

            {

                string[] files = Directory.GetFiles(path);

                return files;

            }

        }

    }
}
