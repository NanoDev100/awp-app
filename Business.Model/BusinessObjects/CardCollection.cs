using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.LernkartenApp060.Business.Model.BusinessObjects
{
	[Serializable]
	class CardCollection : ObservableCollection<Card>
    {
        public CardCollection(int categoryId, CardCollection mainCollection)
        {
            foreach (Card card in mainCollection)
            {
                if (card.CategoryId == categoryId)
                {
                    this.Add(card);
                }
            }
        }
        public CardCollection() : base() { }
  
    }
}
