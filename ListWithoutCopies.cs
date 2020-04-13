using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CopyListWithoutDuplicates
{
    class ListWithoutCopies
    {
        List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

        public List<string> RemoveDuplicates()
        {
            var namesWithoutDuplicates = names.Distinct().ToList();
            return namesWithoutDuplicates;
        }
    }
}
