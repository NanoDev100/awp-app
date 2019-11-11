using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.LernkartenApp060.Business.Model.Common
{
    /* This class loads, saves and keeps track about the complete card collection. */
    class MainModel
    {
        public MainModel()
        {
           this.mainCollection = new BusinessObjects.CardCollection();
        }
        BusinessObjects.CardCollection mainCollection;

        public BusinessObjects.CardCollection MainCollection
        {
            get
            {
                return this.mainCollection;
            }
        }
    }
}
