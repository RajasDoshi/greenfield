using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
           public interface Ishoppingcart
    {
        List<Item> GetItems();
        bool Insert(Item item);
        bool Update(Item item);
        bool Delete(Item item);

    }
}
