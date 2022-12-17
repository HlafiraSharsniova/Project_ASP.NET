namespace Project_ASP.NET.Models
{  //класс самый обычный с полями(переменными)
    public class ErrorViewModel//обработка возможных ошибок
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}