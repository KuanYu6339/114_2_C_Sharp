using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Facts
{
    internal class FoodItem
    {
        // 食物名稱私有欄位
        private string name;
        // 熱量私有欄位（單位：卡路里）
        private double calories;
        // 脂肪私有欄位（單位：公克）
        private double fat;
        // 碳水化合物私有欄位（單位：公克）
        private double carb;

        /// <summary>
        /// 帶有參數的 FoodItem 建構函式，用於初始化物件
        /// </summary>
        /// <param name="name">食物名稱</param>
        /// <param name="calories">熱量</param>
        /// <param name="fat">脂肪含量</param>
        /// <param name="carb">碳水化合物含量</param>
        

        /// <summary>
        /// 食物名稱屬性
        /// </summary>
        public string Name
        {
            // 取得食物名稱
            get { return name; }
            // 設定食物名稱
            set { name = value; }
        }

        /// <summary>
        /// 熱量屬性（單位：卡路里）
        /// </summary>
        public double Calories
        {
            // 取得熱量
            get { return calories; }
            // 設定熱量
            set { calories = value; }
        }

        /// <summary>
        /// 脂肪屬性（單位：公克）
        /// </summary>
        public double Fat
        {
            // 取得脂肪含量
            get { return fat; }
            // 設定脂肪含量
            set { fat = value; }
        }

        /// <summary>
        /// 碳水化合物屬性（單位：公克）
        /// </summary>
        public double Carb
        {
            // 取得碳水化合物含量
            get { return carb; }
            // 設定碳水化合物含量
            set { carb = value; }
        }

        public FoodItem(string name, double calories, double fat, double carb)
        {
            this.name = name;
            this.calories = calories;
            this.fat = fat;
            this.carb = carb;
        }
    }
}
