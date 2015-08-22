using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour
{

	private GameObject player = null;
	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}


	void Update ()
	{
		this.transform.position = new Vector3 (0.0f, player.transform.position.y, transform.position.z);	
	}
}
