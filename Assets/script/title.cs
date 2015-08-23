using UnityEngine;
using System.Collections;

public class title : MonoBehaviour 
{

	private float startTime = 0.0f;
	void Start () 
	{
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time - startTime > 2.0f){
			Debug.Log("change scine");
			Application.LoadLevel("DiveintoDream");
		}
	}
}
