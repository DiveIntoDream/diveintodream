using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

	private bool isControllable = false;
	void Start ()
	{
		enableControl ();
	}
	
	void Update ()
	{
		if(!isControllable)
		{
			return;
		}

		float movePower = this.gameObject.GetComponent<Rigidbody> ().mass;
		Debug.Log ("mass["+movePower+"]");

		if(Input.GetKey(KeyCode.A))
		{
			this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-1.0f*movePower, 0.0f, 0.0f));
			Debug.Log("move left");
		}else if(Input.GetKey(KeyCode.D))
		{
			this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(movePower, 0.0f, 0.0f));
			Debug.Log("move right");
		}
	}

	/** enable to player control */
	public void enableControl()
	{
		isControllable = true;
	}


}
