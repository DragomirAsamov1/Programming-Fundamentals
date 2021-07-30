using System;
using System.Collections.Generic;
using System.Text;

namespace SU
{
    class Issue
    {

        private byte[] b = new byte[1000];

        public Issue(Issue i)
        {
            this.Count = i.Count;
            this.Price = i.Price;
            this.Title = i.Title;
        }


        ~Issue()
        {
            b = null;
        }

        /// <summary>
        /// клас Issue, предсталвяващ периодично издание
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// цена за брой
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// брой издания за година
        /// </summary>
        public int Count { get; set;  }
    }
}
