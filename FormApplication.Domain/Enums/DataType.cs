using System.ComponentModel.DataAnnotations;

namespace FormApplication.Domain.Enums
{
    public enum DataType
    {
        [Display(Name ="Text")]
        String =1,
        [Display(Name = "Currency")]
        Number = 2
    }
}
