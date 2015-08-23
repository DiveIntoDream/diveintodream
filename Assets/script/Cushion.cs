using UnityEngine;
using System.Collections;

public class Cushion : MonoBehaviour
{
	
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag.Equals("Ground"))
		{
			GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatus>().flyCushion();
			Destroy(this);
		}
	}
}
