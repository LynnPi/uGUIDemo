using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExamplePanel : MonoBehaviour {
    public Image MyImage;
    public Dropdown MyDropdown;
    public Toggle MyToggle;

    public GameObject Cube;
	// Use this for initialization
	void Start () {
		
        MyToggle.onValueChanged.AddListener(OnToggleValueChanged);
        MyDropdown.onValueChanged.AddListener(OnDropdownValueChanged);
	}

    private void OnToggleValueChanged(bool arg0) {
        MyImage.gameObject.SetActive(arg0);
    }

    private void OnDropdownValueChanged(int arg0) {
        Debug.Log(arg0);
        if (arg0 == 0) {

            Cube.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (arg0 == 1) {

            Cube.GetComponent<Renderer>().material.color = new Color(255, 0, 255)/255f;
        }

        if (arg0 == 2) {
            Cube.GetComponent<Renderer>().material.color = new Color(255, 97, 0) / 255f;
        }
    }

    // Update is called once per frame
	void Update () {
		
	}
}
