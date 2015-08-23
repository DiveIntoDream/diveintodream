using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	private bool controllable = false;

	private const float MAX_SPEED = -30.0f;
	private float maxSpeed = MAX_SPEED;

	private bool inbed = false;
	public void bedin()
	{
		inbed = true;
	}

	void Update ()
	{
		if(controllable && !inbed)
		{
			float movePower = this.gameObject.GetComponent<Rigidbody> ().mass;

			Rigidbody playerRigid = this.gameObject.GetComponent<Rigidbody>();
			if(Input.GetKey(KeyCode.A))
			{
				playerRigid.velocity = new Vector3(-2.0f, playerRigid.velocity.y, playerRigid.velocity.z);
//				this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-4.0f*movePower, 0.0f, 0.0f));
//				Debug.Log("move left");
			}else if(Input.GetKey(KeyCode.D))
			{
				playerRigid.velocity = new Vector3(2.0f, playerRigid.velocity.y, playerRigid.velocity.z);
//				this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(4.0f*movePower, 0.0f, 0.0f));
//				Debug.Log("move right");
			}
			
			if(this.transform.position.x >= 8.0f)
			{
				this.transform.position = new Vector3(8.0f, transform.position.y, transform.position.z);
			}
			if(this.transform.position.x <= -8.0f)
			{
				this.transform.position = new Vector3(-8.0f, transform.position.y, transform.position.z);
			}
			float speed = this.gameObject.GetComponent<Rigidbody>().velocity.y;
//			Debug.Log(movePower);
			if(speed < maxSpeed)
			{
				float spdx = this.gameObject.GetComponent<Rigidbody>().velocity.x;
				this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(spdx, maxSpeed, 0.0f);
			}
		}
	}

	void OnMouseDrag()
	{
		if (controllable && !inbed) {
			Vector3 objectPointInScreen
			= Camera.main.WorldToScreenPoint (this.transform.position);
		
			Vector3 mousePointInScreen
			= new Vector3 (Input.mousePosition.x,
				               objectPointInScreen.y,
			              objectPointInScreen.z);
		
			Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint (mousePointInScreen);
			mousePointInWorld.z = this.transform.position.z;
			this.transform.position = mousePointInWorld;
	
		}
	}

	/** enable to player control */
	public void enableControl()
	{
		controllable = true;
	}

	public bool isControllable()
	{
		return controllable;
	}

	
	public void maxSpeedUp()
	{
		maxSpeed -= 5;
	}
	public void maxSpeedDown()
	{
		maxSpeed = MAX_SPEED + 10;
	}
	public float getNowMaxSpeed()
	{
		return maxSpeed;
	}
}
