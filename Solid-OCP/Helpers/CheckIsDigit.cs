using Solid_OCP.Interface;
using System.Linq;

namespace Solid_OCP.Helpers
{
    public class CheckIsDigit : ICheckValidation
    {
        public bool isValid(string str)
        {
            return str.Any(x => char.IsDigit(x));
        }
    }
}
