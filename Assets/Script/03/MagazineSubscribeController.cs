using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineSubscribeController : MonoBehaviour {

    private void OnMouseUp()
    {
        StaticValue.currentChoosingPage = StaticValue.ChoosingState.MagazineSubscribe;
        StaticValue.hasShowing = false;
    }
}
