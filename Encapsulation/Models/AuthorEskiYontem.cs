using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Encapsulation.Models
{
    public class AuthorEskiYontem
    {
        private string author;

        public string GetAuthor()
        {
            return this.author;
        }

        public void SetAuthor(string author)
        {
            this.author ="Yazar adı :" + author+".";
        }
    }
}
