using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneySystem : MonoBehaviour {

    public static int moneySum=0;
    /// <summary>
    /// 改变金额的个数
    /// </summary>
    /// <param name="changeMoneyValue">变化的数字,正负都直接传进来</param>
    /// <param name="targetChangingMoney">变化金额弹出的所在的text,两秒后会消失</param>
    /// <param name="targetMoneySum">总金额显示的text</param>
    public static void SetMoney(int changeMoneyValue,Text targetChangingMoney,Text targetMoneySum)
    {
        moneySum += changeMoneyValue;
        if (moneySum <= 0)
        {
            GameSystem.isGameOver = true;
        }

        if (changeMoneyValue >= 0)
        {
            targetChangingMoney.text = "今日挣了:" + changeMoneyValue;
        }
        else
        {
            targetChangingMoney.text = "今日亏了:" + Mathf.Abs(changeMoneyValue);
        }
        targetMoneySum.text = "总幸运点:" + moneySum;
    }

    IEnumerator DeleteChangingMoneyText(Text targetChangingMoney)
    {
        yield return new WaitForSeconds(2f);
        targetChangingMoney.text = "   ";
    }
}


