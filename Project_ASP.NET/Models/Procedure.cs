using System;
using System.Collections.Generic;

namespace Project_ASP.NET.Models
{
    public class Procedure // описание самой услуги и к какой категории она относиться
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string shortDesc { get; set; } //короткое описание
        public string longDesc { get; set; }
        public string img { get; set; }
        public ushort price { get; set; } //юшорт потому что цена не может быть с минусом и это не миллион знаков
        public bool isFavourite { get; set; } //
        public bool available { get; set; } //если о товарах,то есть ли в наличии на складе и сколько,не знаю,буду ли использовать 

        public int categoryID { get; set; } //руки или ноги,это и будет категория,к которой будут относиться процедуры

        public virtual CategoryOfProcedure Category { get; set; }









    }
}
