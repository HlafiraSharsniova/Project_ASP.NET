using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Project_ASP.NET.Models
{
    public class Profile
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Proszę podać imię!")]
        public string Name { get; set; }
       
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        [Required(ErrorMessage = "Proszę podać poprawny eamil!")]
        public string Email { get; set; }
        //public string Subject { get; set; }
       // [MinLength(length: 5, ErrorMessage = 
           /// <summary>
           /// /"Twoja wiadomość musi mieć co najmniej 5 znaków")]
           /// </summary>
       //[Required(ErrorMessage = "Proszę wpisz wiadomość!")]
    }

}
