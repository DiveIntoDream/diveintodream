﻿using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if(Input.GetMouseButtonUp(0)){
			Debug.Log("change scine");
			Application.LoadLevel("DiveintoDream");
		//}
	}
}
