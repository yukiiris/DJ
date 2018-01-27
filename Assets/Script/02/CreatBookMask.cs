using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[AddComponentMenu("book/creatBookMask")]
public class CreatBookMask : MonoBehaviour {

    [SerializeField] private GameObject bookMask_g;
    [SerializeField] private string toChange;
    private void OnMouseUp()
    {
        Debug.Log("tffff");
        Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject g=Instantiate(bookMask_g,gameObject.transform.position,Quaternion.identity);
        g.transform.parent = gameObject.transform;
        //GetComponent<Text>().text = toChange;
    }
}
