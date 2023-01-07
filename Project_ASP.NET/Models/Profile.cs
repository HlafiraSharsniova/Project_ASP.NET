using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Project_ASP.NET.Models
{
    public class Profile
    {
        [HiddenInput]
        public int Id { get; set; }
        [Display(Name = "Введите имя ")]
        [Required(ErrorMessage = "Вам нужнно ввести имя")]

        public string Name { get; set; }
        [Display(Name = "Введите фамилию ")]
        [Required(ErrorMessage = "Вам нужнно ввести фамилию")]
        public string Surname { get; set; }
        [Display(Name = "Введите ваш номер телефона")]
        [Required(ErrorMessage = "Вам нужнно ввести номер телефона")]
        [StringLength(12, ErrorMessage = "Не менее 12 символов")]
        public int PhoneNumber { get; set; }
       
    }

}
