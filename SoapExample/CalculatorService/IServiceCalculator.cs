using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceCalculator" in both code and config file together.
    [ServiceContract]
    public interface IServiceCalculator
    {
        /// <summary>
        /// Sums the specified first number.
        /// </summary>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        /// <returns></returns>
        [OperationContract]
        double Sum(double firstNumber, double secondNumber);

        /// <summary>
        /// Subtracts the specified first number.
        /// </summary>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        /// <returns></returns>
        [OperationContract]
        double Subtract(double firstNumber, double secondNumber);
    }
}
