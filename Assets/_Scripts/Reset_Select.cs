using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset_Select : MonoBehaviour {

	public Button Button_Reset;
	public Button button1;
	public Button button2;
	public Button button3;

	// Use this for initialization
	void Start () {
		Button_Reset.interactable = false;
	}
	
	public void BtnClick(){
		GameObject[] IT3 = GameObject.FindGameObjectsWithTag ("IT3");

		for (int i = 0; i < IT3.Length; i++) {
			Destroy (IT3 [i]);
		}

		Button_Reset.interactable = false;

		button1.interactable = true;

		button2.interactable = true;

		button3.interactable = true;
	}
}
