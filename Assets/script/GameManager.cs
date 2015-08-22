using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public GameObject cushions;
	private GameObject player;
	// Use this for initialization
	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		cushions.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(player.GetComponent<PlayerController>().isControllable())
		{
			cushions.SetActive (true);
		}
	}
}
