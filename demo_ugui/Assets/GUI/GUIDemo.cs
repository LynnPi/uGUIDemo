using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIDemo : MonoBehaviour {
	public float hSliderValue = 0.3F;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Unity引擎实现的渲染函数，可以把整个引擎当做1个状态机来理解
	void OnGUI(){
		GUI.Box(new Rect(20,20,Screen.width-40,Screen.height-40), "hello friends, i am a box");

		GUI.Label(new Rect(20, 50, Screen.width, 30), "I am a Label, just like the label in NGUI, the text in UGUI");

		GUI.Button(new Rect(20, 80, Screen.width/2f, 25), "I am a Button, click me for some actions");

		hSliderValue = GUI.HorizontalSlider(new Rect(20, 125, Screen.width/2f , 30), hSliderValue, 0.0F, 10.0F);

	}
}
