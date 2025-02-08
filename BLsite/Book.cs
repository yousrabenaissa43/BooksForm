using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLsite
{
    public abstract class Book 
    {

        [Key]
        public int Serial {  get; private set; }
       public string? Title { get; private set; }
        public int? Value { get; protected set; }

        public Book(int serial, string title)
        {
            this.Serial = serial; 
            this.Title = title;
        }
        public Book()
        {
        }

        public string getInfos()
        {
            return $"Book with serial {Serial} , titled \" {Title}\"\r\n"; 
        }
        
        public void CalculatedValue()
        {
            int wordCount = Title.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            Value += wordCount * 5;
            Value += Title.Count(char.IsUpper) * 3;

            if (Title.ToLower().Contains("smurf"))
            {
                Value += 10;
            }

            if (Serial < 100)
            {
                Value *= 2;
            }

        }
        public abstract void CalculatedExtandedValue();
        public abstract string GetExtandedInfos();
    }
}
