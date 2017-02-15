using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public abstract class SubjectBase
    {
        //way1
        IList<Shop> shopList = new List<Shop>();

        //way2
        public delegate void StatusUpdate(float price);
        public event StatusUpdate OnStatusUpdate;

        public void Attach(Shop product)
        {
            shopList.Add(product);
        }

        public void Remove(Shop product)
        {
            shopList.Remove(product);
        }
        //way2
        public void Attach2(Shop product)
        {
            OnStatusUpdate += new StatusUpdate(product.Update);
        }
        //way2
        public void Remove2(Shop product)
        {
            OnStatusUpdate -= new StatusUpdate(product.Update);
        }

        public void Notify(float price)
        {
            foreach(Shop s in shopList)
            {
                s.Update(price);
            }

            //way2
            if(OnStatusUpdate !=null)
            {
                OnStatusUpdate(price);
            }
        }
    }
}
