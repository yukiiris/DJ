using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 控制第三个界面的流程的脚本
/// </summary>
public class Scene3ProcedureController : MonoBehaviour
{

    [SerializeField] private GameObject targetTermimal;
    [SerializeField] private GameObject targetWorkInstruction;
    [SerializeField] private GameObject targetMagazineSubscribe;
    public UnityEngine.UI.Text targetTotalMoneySum;
    public UnityEngine.UI.Text targetChangingMoney;

    private string totalMoneyBefore = "总幸运点:";
    private string earningNumber = "今日挣了:";
    private string losingNumber = "今日亏了:";


    private Vector3 createPosition = new Vector3(0, 0, 0);
    private void FixedUpdate()
    {
        //该产生的展示板并没有展开
        if (!StaticValue.hasShowing && !StaticValue.isShowing)
        {
            switch (StaticValue.currentChoosingPage)
            {
                case StaticValue.ChoosingState.terminal:
                    Instantiate(targetTermimal, createPosition, Quaternion.Euler(0, 0, 0));
                    StaticValue.hasShowing = true;
                    StaticValue.isShowing = true;
                    break;
                case StaticValue.ChoosingState.workInstruction:
                    Instantiate(targetWorkInstruction, createPosition, Quaternion.Euler(0, 0, 0));
                    StaticValue.hasShowing = true;
                    StaticValue.isShowing = true;
                    break;
                case StaticValue.ChoosingState.MagazineSubscribe:
                    Instantiate(targetMagazineSubscribe, createPosition, Quaternion.Euler(0, 0, 0));
                    StaticValue.hasShowing = true;
                    StaticValue.isShowing = true;
                    break;
                default:
                    break;
            }
        }

    }

    public void ChangingUIMoney(int changingMoney)
    {
        
    }

}
