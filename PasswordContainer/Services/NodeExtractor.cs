using PasswordContainer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer.Services
{
    interface NodeExtractor
    {
        Node[] extract(String Path);
    }
}
