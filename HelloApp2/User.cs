using System;
using System.Collections.Generic;
using System.Text;

namespace HelloApp2
{
   public class User
    {
        public int Id { get; set; } //первичный ключ в таблице (данное свойство)
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
