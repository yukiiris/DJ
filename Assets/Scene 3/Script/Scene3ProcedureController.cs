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

    private Vector3 createPosition = new Vector3(0, 0, 0);
    private void FixedUpdate()
    {
        switch (StaticValue.currentChoosingPage)
        {
            case StaticValue.ChoosingState.terminal:
                Instantiate(targetTermimal, createPosition, Quaternion.Euler(0, 0, 0));
                break;
            case StaticValue.ChoosingState.workInstruction:
                Instantiate(targetWorkInstruction, createPosition, Quaternion.Euler(0, 0, 0));
                break;
            default:
                break;
        }

    }
}
