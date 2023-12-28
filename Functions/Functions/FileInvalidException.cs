using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class FileInvalidException : Exception
    {
        public string Reason { get; set; }
        public FileInvalidException() : base()
        {

        }

        public FileInvalidException(string message) : base(message)
        {

        }

        public FileInvalidException(string message, string reason) : base(message)
        {
            this.Reason = reason;
        }
    }

}
