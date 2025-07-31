using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace MethShop.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }


        [Display(Name = "Введите имя")]
        [Required(ErrorMessage = "Имя обязательно для заполнения")]
        [StringLength(30, ErrorMessage = "Имя не может быть длиннее 30 символов")]
        public string Name { get; set; }


        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Фамилия обязательно для заполнения")]
        [StringLength(30, ErrorMessage = "Имя не может быть длиннее 30 символов")]
        public string Surname { get; set; }


        [Display(Name = "Введите адресс")]
        [Required(ErrorMessage = "Адресс обязательно для заполнения")]
        [StringLength(50, ErrorMessage = "Адресс не может быть длиннее 50 символов")]
        public string Address { get; set; }


        [Display(Name = "Введите номер телефона")]
        [Required(ErrorMessage = "Телефон обязательно для заполнения")]
        [StringLength(20, ErrorMessage = "Имя не может быть длиннее 20 символов")]
        [Phone(ErrorMessage = "Некорректный номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


        [Display(Name = "Введите email")]
        [Required(ErrorMessage = "Email обязательно для заполнения")]
        [StringLength(30, ErrorMessage = "Email не может быть длиннее 30 символов")]
        [EmailAddress(ErrorMessage = "Некорректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Корзина пуста")]
        public string Cart { get; set; }

    }
}
