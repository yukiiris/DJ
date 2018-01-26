using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[AddComponentMenu]
public class TerminalController : MonoBehaviour {

    private void OnMouseUp()
    {
        StaticValue.currentChoosingPage = StaticValue.ChoosingState.terminal;
    }
}
