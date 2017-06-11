using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

[CustomEditor(typeof(GUIDemo))]
public class GUIDemoEditor : Editor  {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public override void OnInspectorGUI (){
		base.OnInspectorGUI ();

		GUILayout.Label("这是一个检视面板中的label");

		if(GUILayout.Button("保存配置")){
			
		}

	}
}
