using System.ComponentModel.DataAnnotations;

namespace _13_MVC_ViewModel_DTO.Validations
{
    public class CustomDateValidation : ValidationAttribute
    {
        private readonly DateTime _date;
        public CustomDateValidation(int startYear, int startMonth,int startDay)
        {
            _date = new DateTime(startYear, startMonth, startDay);
        }
        public override bool IsValid(object? value)
        {
            if (value is DateTime dateValue)
            {
                if (dateValue >= _date)
                    return true;
            }
            return false;
        }
    }
}
