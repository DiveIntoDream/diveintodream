using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour
{
	void Start ()
	{
	}
	
	void Update ()
	{
	
	}

	private int score = 0;

	private void pickItem(int itemType)
	{
		switch(itemType)
		{
		case 0:// SPEED UP
			GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().maxSpeedUp();
			this.GetComponent<Rigidbody>().mass += 40.0f;
			break;
		case 1:// SPEED DOWN
//			GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().maxSpeedDown();
			break;
		case 2:// MASS UP
//			this.GetComponent<Rigidbody>().mass += 40.0f;
			break;
		case 3:// MASS DOWN
//			if(this.GetComponent<Rigidbody>().mass > 50.0f)
//			{
//				this.GetComponent<Rigidbody>().mass -= 4.0f;
//			}
			break;
		case 4:// SCORE UP
			score++;
			break;
		default:
			break;
		}
		Debug.Log ("spd["+this.GetComponent<Rigidbody>().velocity.y+"], mass["+this.GetComponent<Rigidbody>().mass+"], score["+score+"]");
	}
	
	/** 何かに触れたときをタグで判定 */
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag.Equals("Item"))
		{
			pickItem(other.gameObject.GetComponent<Item>().itemType);
			Destroy(other.gameObject);
		}
	}
}
