
namespace Calculadora.Common.Entities
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
