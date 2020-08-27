using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    /// <summary>
    /// Exception class for Employee
    /// </summary>
    public class EmployeeException : ApplicationException
    {
        /// <summary>
        /// Constructor initializes nothing
        /// </summary>
        public EmployeeException(): base()
        {
        }

        /// <summary>
        /// Constructor initializes only Message
        /// </summary>
        /// <param name="message"></param>
        public EmployeeException(string message): base(message)
        {
        }

        /// <summary>
        /// Constructor initializes Message and InnerException
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception which causes the current exception</param>
        public EmployeeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}


