using System.Collections.Generic;
using System.Collections.ObjectModel;




namespace FruitCommerce.Domain.Core.Models
{
    public class CategoryItem : ModelBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<SubCategoryItem> SubCategoryItems { get; set;}

        public CategoryItem()
        {
            SubCategoryItems = new Collection<SubCategoryItem>();
        }
    }
}