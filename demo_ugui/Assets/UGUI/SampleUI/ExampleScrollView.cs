using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExampleScrollView : MonoBehaviour {
    public Button MinusBtn;
    private Button _plusBtn;

    public GameObject Prefab;

    public RectTransform GridRoot;
   
	// Use this for initialization
	void Start () {
	    _plusBtn = GridRoot.parent.Find("Button_Plus").GetComponent<Button>();
        _plusBtn.onClick.AddListener(OnClickPlusBtn);
	}

    private void OnClickPlusBtn() {
        var grid = GameObject.Instantiate(Prefab) as GameObject;
        grid.transform.SetParent(GridRoot);
        grid.GetComponentInChildren<Text>().text = string.Format("Grid_{0}", GridRoot.childCount);
    }


    public void OnClickMinusBtn() {
        var lastGrid = GridRoot.GetChild(GridRoot.childCount - 1).gameObject;
        if (lastGrid) {
            Destroy(lastGrid);
        }
    }

}
