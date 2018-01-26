using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySystem : MonoBehaviour {

    public static int moneySum=0;
    
    /// <summary>
    /// 设置总金钱
    /// </summary>
    /// <param name="changeMoneyValue">正数为增加的量，负数为减少的量</param>
    public static void SetMoney(int changeMoneyValue)
    {
        moneySum += changeMoneyValue;
        if (moneySum <= 0)
        {
            GameSystem.isGameOver = true;
        }
    }
}
