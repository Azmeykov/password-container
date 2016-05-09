using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordContainer.Model
{
    class Node
    {
        private Node ParentNode { get; set; }
        private string Type { get; set; }
        private string Name { get; set; }
        private Password Password { get; set; }
    }
}
