using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public GameObject dropImage; 
	public Sprite[] atteluMasivs;

	public void drop(int sk){
		dropImage.GetComponent<Image>().sprite = atteluMasivs [sk];
	}
}
