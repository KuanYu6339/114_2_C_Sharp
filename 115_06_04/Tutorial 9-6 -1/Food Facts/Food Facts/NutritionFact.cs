using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Facts
{
    /// <summary>
    /// 營養事實類別，用於儲存食物的營養資訊
    /// </summary>
    public class NutritionFact
    {
        // 食物名稱私有欄位
        private string foodName;
        // 熱量私有欄位（單位：卡路里）
        private int calories;
        // 脂肪私有欄位（單位：公克）
        private double fat;
        // 碳水化合物私有欄位（單位：公克）
        private int carb;

        /// <summary>
        /// NutritionFact 類別的無參數建構函式
        /// </summary>
        public NutritionFact()
        {
            // 初始化食物名稱為空字串
            foodName = string.Empty;
            // 初始化熱量為 0
            calories = 0;
            // 初始化脂肪為 0.0
            fat = 0.0;
            // 初始化碳水化合物為 0
            carb = 0;
        }

        /// <summary>
        /// 食物名稱屬性
        /// </summary>
        public string FoodName
        {
            // 取得食物名稱
            get { return foodName; }
            // 設定食物名稱
            set { foodName = value; }
        }

        /// <summary>
        /// 熱量屬性（單位：卡路里）
        /// </summary>
        public int Calories
        {
            // 取得熱量
            set { calories = value; }
            // 設定熱量
            get { return calories; }
        }

        /// <summary>
        /// 脂肪屬性（單位：公克）
        /// </summary>
        public double Fat
        {
            // 設定脂肪含量
            set { fat = value; }
            // 取得脂肪含量
            get { return fat; }
        }

        /// <summary>
        /// 碳水化合物屬性（單位：公克）
        /// </summary>
        public int Carb
        {
            // 設定碳水化合物含量
            set { carb = value; }
            // 取得碳水化合物含量
            get { return carb; }
        }

        /// <summary>
        /// 取得營養資訊的字串表示
        /// </summary>
        /// <returns>營養資訊的格式化字串</returns>
        public override string ToString()
        {
            // 返回食物名稱和營養資訊的格式化字串
            return $"食物：{foodName}\n熱量：{calories}\n脂肪：{fat}g\n碳水：{carb}g";
        }
    }
}