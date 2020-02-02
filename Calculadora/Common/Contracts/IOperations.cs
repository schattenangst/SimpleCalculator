
namespace Calculadora.Common.Contracts
{
    using Common.Entities;

    public interface IOperations
    {
        /// <summary>
        /// Realiza una operación basica 
        /// de dos números y el tipo de operación
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        MessageResponse<decimal> GetResultOperation(decimal a, decimal b, string operation);
    }
}
