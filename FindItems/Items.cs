using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindItems
{
    class Items
    {
        private String title;
        private String url;
        private Decimal price;

        public String Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public String Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }

        public Decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
