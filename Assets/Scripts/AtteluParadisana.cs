using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public GameObject charImage;
	public GameObject h1, h2, h3, h4, h5;
	public GameObject e1, e2, e3;
	public Sprite[] atteluMasivs, hc1, hc2, hc3, hc4, hc5, ec1, ec2, ec3;

	public void dropdownChar(int sk){
		charImage.GetComponent<Image>().sprite = atteluMasivs [sk];
	}

	public void dropdownHairColor(int sk){
		h1.GetComponent<Image>().sprite = hc1 [sk];
		h2.GetComponent<Image>().sprite = hc2 [sk];
		h3.GetComponent<Image>().sprite = hc3 [sk];
		h4.GetComponent<Image>().sprite = hc4 [sk];
		h5.GetComponent<Image>().sprite = hc5 [sk];
	}

	public void hairstyleShow(bool value){
		h1.SetActive (value);
		h2.SetActive (value);
		h3.SetActive (value);
		h4.SetActive (value);
		h5.SetActive (value);
	}
	public void eyesShow(bool value){
		e1.SetActive (value);
		e2.SetActive (value);
		e3.SetActive (value);

	}

	public void dropdownEyeColor(int sk){
		e1.GetComponent<Image>().sprite = ec1 [sk];
		e2.GetComponent<Image>().sprite = ec2 [sk];
		e3.GetComponent<Image>().sprite = ec3 [sk];
	}
}
