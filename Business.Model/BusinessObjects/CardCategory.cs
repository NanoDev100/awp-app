using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.LernkartenApp060.Business.Model.BusinessObjects
{
    class CardCategory
    {
        public CardCategory(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public int id;

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string description;
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }
    }
}
