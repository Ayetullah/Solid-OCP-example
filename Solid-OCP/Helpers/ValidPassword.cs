using Solid_OCP.Models;

namespace Solid_OCP.Helpers
{
    public static class ValidPassword
    {
        public static bool IsValidPassword(this string str, ValidationModel validationModel)
        {
            switch (validationModel.ValidationType)
            {
                case ValidationType.Digit:
                    CheckIsDigit checkIsDigit = new CheckIsDigit();
                    return checkIsDigit.isValid(str);
                case ValidationType.UpperCase:
                    CheckIsUpperCase checkIsUpper = new CheckIsUpperCase();
                    return checkIsUpper.isValid(str);
                default:
                    return true;
            }
        }
    }
}
