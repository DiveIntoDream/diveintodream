using UnityEngine;
using System.Collections;

public class CharacterStoper : MonoBehaviour {
	private PlayerController player = null;
	private bool trigger = false;
	// Use this for initialization
	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(trigger)
		{
			GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Score>().showCushonNum();
			return;
		}
	}

	/** 何かに触れたときをタグで判定 */
	void OnTriggerStay(Collider other)
	{
		if(trigger || !player.isControllable())
		{
			return;
		}
		if (other.gameObject.tag.Equals("Player"))
		{
			trigger = true;
			player.bedin();
		}
	}
}
