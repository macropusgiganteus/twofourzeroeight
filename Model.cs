using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace twozerofoureight
{
    
    public class Model
    {
        public int score2 =0;
        public bool checkGameOver;
        public bool GameOver()
        {
            return checkGameOver;
        }
        protected ArrayList oList;

        public Model()
        {
            oList = new ArrayList();
        }
        public void NotifyAll()
        {
            foreach (View m in oList)
            {
                m.Notify(this);
            }
        }

        public void AttachObserver(View m)
        {
            oList.Add(m);
        }
        public int Getscore()
        {
            return score2;
        }


    }
}
