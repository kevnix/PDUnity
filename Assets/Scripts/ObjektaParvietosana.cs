using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjektaParvietosana : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler {
	private RectTransform transformacijuLogs;
	public Canvas kanva;

	private void Awake(){
		transformacijuLogs = GetComponent < RectTransform> ();
	}

	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Kreisais klikskis uz parvietojama objekta!");
	}

	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Objekts tiek parvietots!");
		transformacijuLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
		Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		mousePosition.x = Mathf.Clamp (mousePosition.x, 0 + transformacijuLogs.rect.width / 2, Screen.width - transformacijuLogs.rect.width / 2);
		mousePosition.y = Mathf.Clamp (mousePosition.y, 0 + transformacijuLogs.rect.height / 2, Screen.height - transformacijuLogs.rect.height / 2);
		//transform.position = mousePosition;
		Debug.Log ("\nx=" + mousePosition.x + " y=" + mousePosition.y);
			
	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsakta objekta parvietosana");
	}

	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Pabeigta objekta parvietosana");
	}
}
