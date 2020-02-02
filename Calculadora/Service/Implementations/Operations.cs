
namespace Calculadora.Service.Implementations
{
    using Common.Contracts;
    using Common.Entities;

    public class Operations : IOperations
    {
        /// <summary>
        /// Realiza una operación basica 
        /// de dos números y el tipo de operación
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        public MessageResponse<decimal> GetResultOperation(decimal a, decimal b, string operation)
        {
            MessageResponse<decimal> result;

            switch (operation)
            {
                case "+":
                    result = Sum(a, b);
                    break;
                case "-":
                    result = Substraccion(a, b);
                    break;
                case "*":
                    result = Multiplication(a, b);
                    break;
                case "/":
                    result = Division(a, b);
                    break;
                default:
                    result = new MessageResponse<decimal>(0);
                    break;
            }

            return result;
        }

        /// <summary>
        /// Suma dos números
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private MessageResponse<decimal> Sum(decimal a, decimal b)
        {
            return new MessageResponse<decimal>(a + b);
        }

        /// <summary>
        /// Resta de dos números
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private MessageResponse<decimal> Substraccion(decimal a, decimal b)
        {

            return new MessageResponse<decimal>(a - b);
        }

        /// <summary>
        /// Divide dos números
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private MessageResponse<decimal> Division(decimal a, decimal b)
        {
            MessageResponse<decimal> result;

            if (b != 0)
            {
                result = new MessageResponse<decimal>(a / b);
            }
            else
            {
                result = new MessageResponse<decimal>("Sintaxis Error");
            }

            return result;
        }

        /// <summary>
        /// Multiplica dos números
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private MessageResponse<decimal> Multiplication(decimal a, decimal b)
        {
            return new MessageResponse<decimal>(a * b);
        }

    }
}
