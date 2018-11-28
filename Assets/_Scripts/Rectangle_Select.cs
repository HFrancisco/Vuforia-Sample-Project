using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rectangle_Select : MonoBehaviour {

	public GameObject SpawnPoint;
	public GameObject Rectangle;

	public Button button1;
	public Button button2;
	public Button button3;
	public Button buttonReset;

	public void BtnClick(){

		Debug.Log ("Rectangle");
		Instantiate (Rectangle, SpawnPoint.transform);

		Hide_Buttons();
	}

	void Hide_Buttons(){
		button1.interactable = false;

		button2.interactable = false;

		button3.interactable = false;

		buttonReset.interactable = true;
	}
}
