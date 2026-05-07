using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    class Coin
    {
        private string sideUp; // 儲存目前朝上的面

        public Coin()
        {
            // 建構子，預設朝上為 "Heads"
            sideUp = "Heads";
        }

        public void Toss()
        {
            // 使用隨機數產生器來決定朝上的面
            Random rand = new Random();
            int tossResult = rand.Next(2); // 產生 0 或 1
            if (tossResult == 0)
            {
                sideUp = "Heads"; // 朝上為正面
            }
            else
            {
                sideUp = "Tails"; // 朝上為反面
            }
        }

        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
