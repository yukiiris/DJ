using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkInstructionController : MonoBehaviour {

    private void OnMouseUp()
    {
        StaticValue.currentChoosingPage = StaticValue.ChoosingState.workInstruction;
        StaticValue.hasShowing = false;
    }
}
