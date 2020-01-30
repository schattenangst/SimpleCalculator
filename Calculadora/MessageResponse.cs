using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class MessageResponse<T>
    {
        public T Response { get; set; }

        public string Message { get; set; }

        public bool IsError { get; set; }

        public MessageResponse(T response)
        {
            Response = response;
            Message = string.Empty;
        }

        public MessageResponse(string message)
        {
            Message = message;
            IsError = true;
        }
    }
}
