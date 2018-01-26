using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitShowingButton : MonoBehaviour {

    private void OnMouseUp()
    {
        StaticValue.currentChoosingPage = StaticValue.ChoosingState.scene_3_mainPage;
        StaticValue.hasShowing = false;
        Destroy(transform.parent.gameObject);    }
}
