using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispScreenSize : MonoBehaviour {
	private string label = "saijo";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	/****************************************
	****************************************/
	void OnGUI()
	{
		 GUI.color = Color.white;
		// GUI.color = Color.red;
		
		/********************
		********************/
		label = string.Format("{0:000.0}, {1:000.0}", Screen.width, Screen.height);
		GUI.Label(new Rect(50, 20, 500, 30), label);
	}
}
