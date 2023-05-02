using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public GameObject charImage;
	public GameObject h1, h2, h3, h4, h5;
	public GameObject e1, e2, e3;
	public GameObject t1, t2, t3, t4, t5;
	public GameObject b1, b2, b3;
	public GameObject slider, slider2;
	public float garums, platums;
	public Sprite[] atteluMasivs, hc1, hc2, hc3, hc4, hc5, ec1, ec2, ec3, tc1, tc2, tc3, tc4, tc5, bc1, bc2, bc3;

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

	public void topsShow(bool value){
		t1.SetActive (value);
		t2.SetActive (value);
		t3.SetActive (value);
		t4.SetActive (value);
		t5.SetActive (value);

	}

	public void dropdownTopColor(int sk){
		t1.GetComponent<Image>().sprite = tc1 [sk];
		t2.GetComponent<Image>().sprite = tc2 [sk];
		t3.GetComponent<Image>().sprite = tc3 [sk];
		t4.GetComponent<Image>().sprite = tc4 [sk];
		t5.GetComponent<Image>().sprite = tc5 [sk];
	}

	public void bottomsShow(bool value){
		b1.SetActive (value);
		b2.SetActive (value);
		b3.SetActive (value);

	}

	public void dropdownBottomColor(int sk){
		b1.GetComponent<Image>().sprite = bc1 [sk];
		b2.GetComponent<Image>().sprite = bc2 [sk];
		b3.GetComponent<Image>().sprite = bc3 [sk];
	}

	public void mainitGarumu(){
		garums = slider.GetComponent<Slider> ().value;
		charImage.transform.localScale = new Vector2 (platums, garums);
		h1.transform.localScale = new Vector2 (platums, garums);
		h2.transform.localScale = new Vector2 (platums, garums);
		h3.transform.localScale = new Vector2 (platums, garums);
		h4.transform.localScale = new Vector2 (platums, garums);
		h5.transform.localScale = new Vector2 (platums, garums);
		t1.transform.localScale = new Vector2 (platums, garums);
		t2.transform.localScale = new Vector2 (platums, garums);
		t3.transform.localScale = new Vector2 (platums, garums);
		t4.transform.localScale = new Vector2 (platums, garums);
		t5.transform.localScale = new Vector2 (platums, garums);
		e1.transform.localScale = new Vector2 (platums, garums);
		e2.transform.localScale = new Vector2 (platums, garums);
		e3.transform.localScale = new Vector2 (platums, garums);
		b1.transform.localScale = new Vector2 (platums, garums);
		b2.transform.localScale = new Vector2 (platums, garums);
		b3.transform.localScale = new Vector2 (platums, garums);
	}

	public void mainitPlatumu(){
		platums = slider2.GetComponent<Slider> ().value;
		charImage.transform.localScale = new Vector2 (platums, garums);
		h1.transform.localScale = new Vector2 (platums, garums);
		h2.transform.localScale = new Vector2 (platums, garums);
		h3.transform.localScale = new Vector2 (platums, garums);
		h4.transform.localScale = new Vector2 (platums, garums);
		h5.transform.localScale = new Vector2 (platums, garums);
		t1.transform.localScale = new Vector2 (platums, garums);
		t2.transform.localScale = new Vector2 (platums, garums);
		t3.transform.localScale = new Vector2 (platums, garums);
		t4.transform.localScale = new Vector2 (platums, garums);
		t5.transform.localScale = new Vector2 (platums, garums);
		e1.transform.localScale = new Vector2 (platums, garums);
		e2.transform.localScale = new Vector2 (platums, garums);
		e3.transform.localScale = new Vector2 (platums, garums);
		b1.transform.localScale = new Vector2 (platums, garums);
		b2.transform.localScale = new Vector2 (platums, garums);
		b3.transform.localScale = new Vector2 (platums, garums);
	}
}
