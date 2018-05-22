using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Public scope visible throughout whole solution
    public class Item
    {
        // These are the properties of the Item class
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }

        // This is the constructor for the Item class
        public Item(int id, string name, string namePlural)
		{
			ID = id;
			Name = name;
			NamePlural = namePlural;
		}
    }
}
