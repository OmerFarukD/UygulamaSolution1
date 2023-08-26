using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GIRIS.Models;
public class Category
{
    // Field
    public string _categoryName;
    public string _categoryDescription;

    public Category()
    {
        
    }

    public Category(string category, string description)
    {
        _categoryName = category;
        _categoryDescription = description;
    }
    public override string ToString()
    {
        return $" adı : {_categoryName}, açıklama : {_categoryDescription}";
    }



}
