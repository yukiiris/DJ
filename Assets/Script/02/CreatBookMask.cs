using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[AddComponentMenu("book/creatBookMask")]
public class CreatBookMask : MonoBehaviour {

    [SerializeField] public GameObject bookMask_g;
    private void OnMouseUp()
    {
		transform.GetChild (0).gameObject.SetActive (true);
		bookMask_g.SetActive (true);
        //GetComponent<Text>().text = toChange;
    }
}
