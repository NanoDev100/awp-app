using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.LernkartenApp060.Business.Model.BusinessObjects
{
	[Serializable]
    class Card
    {
        public Card(int id, string quest, string answer, int categoryId)
        {
            this.id = id;
            this.quest = quest;
            this.answer = answer;
            this.categoryId = categoryId;
            this.weight = 0.5;
            this.solved = 0;

        }
        public int id;
        public int Id {
            get 
            {
                return this.id;
            }
        }

        public string quest;

        public string Quest
        {
            get
            {
                return this.quest;
            }
            set
            {
                this.quest = value;
            }
        }
        public string answer;

        public string Answer
        {
            get
            {
                return this.answer;
            }
            set
            {
                this.answer = value;
            }
        }

        public int categoryId;

        public int CategoryId
        {
            get
            {
                return this.categoryId;
            }
            set
            {
                this.categoryId = value;
            }
        }

        public int solved;

        public int Solved
        {
            get
            {
                return this.solved;
            }
            set
            {
                this.solved = value;
            }
        }

        public double weight;

        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

    }
}
