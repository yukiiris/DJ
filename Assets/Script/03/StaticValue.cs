using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticValue : MonoBehaviour {

    //当前选择的界面
    public enum ChoosingState
    {
        terminal,
        workInstruction,
        scene_3_mainPage
    }

    //工作存在的问题
    public enum WorkingProblem
    {

    }

    public static ChoosingState currentChoosingPage;
    public static WorkingProblem currentWorkingProblem;

    public static int MoneyEarningToday;
    public static int MoneySum;
    public static bool hasShowing=true;

}
