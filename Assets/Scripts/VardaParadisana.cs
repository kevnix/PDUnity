using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	public string text;
	public GameObject nameField, ageField;
	public GameObject textOutput;

	public void storeText(){
		text = nameField.GetComponent<Text> ().text+" "+int.Parse (ageField.GetComponent<Text> ().text)+" gadi";
		textOutput.GetComponent<Text>().text = text;
	}
}
