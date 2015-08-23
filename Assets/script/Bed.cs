using UnityEngine;
using System.Collections;

public class Bed : MonoBehaviour
{
	private bool trigger = false;
	private PlayerController player = null;
	public GameObject effect = null;
	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ();
		effect.SetActive (false);
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
			effect.SetActive (true);
			trigger = true;
			player.bedin();
		}
	}
}
