using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExampleInputField : MonoBehaviour {

    public Text ShowText;
    public InputField Field;

	// Use this for initialization
	void Start () {
        Field.onEndEdit.AddListener(OnEndEdit);
        Field.onValueChanged.AddListener(OnValueChanged);
	}

    private void OnValueChanged(string arg0) {
        ShowText.text = arg0;
    }

    private void OnEndEdit(string arg0) {
      Debug.Log("编辑完成！");
    }
}
