using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineSubscribeController : MonoBehaviour {

	public GameObject text;

    private void OnMouseUp()
    {
		text.SetActive(true);
        StaticValue.currentChoosingPage = StaticValue.ChoosingState.MagazineSubscribe;
        StaticValue.hasShowing = false;
    }
}
