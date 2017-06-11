using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ExampleEventSystem : MonoBehaviour, IDragHandler,
								IPointerEnterHandler, IPointerExitHandler, 
								IPointerDownHandler, IPointerUpHandler {
	public Image Target;
	public float ScaleFactor = 2f;

	#region IPointerUpHandler implementation

	public void OnPointerUp (PointerEventData eventData){

		transform.localScale = Vector3.one;
	}

	#endregion

	#region IPointerDownHandler implementation

	public void OnPointerDown (PointerEventData eventData){
		transform.localScale = Vector3.one * ScaleFactor;
	}

	#endregion

	#region IPointerExitHandler implementation
	public void OnPointerExit (PointerEventData eventData){
		Target.color = Color.white;
	}
	#endregion


	#region IPointerEnterHandler implementation

	public void OnPointerEnter (PointerEventData eventData){
		Target.color = Color.green;
	}

	#endregion

	#region IDragHandler implementation
	public void OnDrag (PointerEventData eventData){

		Debug.LogFormat("eventData.position:{0}, input.mousPos:{1}",
			eventData.position, Input.mousePosition);

		transform.localPosition = eventData.position - new Vector2(1280f/2f, 720f/2f);

	}
	#endregion

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
