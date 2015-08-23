using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Jamp : MonoBehaviour
{
	private bool jumped = false;
	private bool falling = false;


//	public GameObject human;
	float power = 0;
	//double testpower = 0.0;
	private GameObject slider;
	void Start ()
	{
		slider = GameObject.Find("Slider");
	}
	
	// Update is called once per frame
	void Update ()
	{

		if(!falling && jumped)
		{
			// kasokudo ga 0 ni nattara controllable ni
			float speed = this.GetComponent<Rigidbody> ().velocity.y;
//			Debug.Log ("takasa:"+speed);
			if(speed <= 0 && this.GetComponent<Rigidbody> ().position.y > 35.0f)
			{
				falling = true;
				this.GetComponent<PlayerController>().enableControl();
				this.GetComponent<Rigidbody>().mass = 100.0f;
			}

		}
		if(!jumped)
		{
			/*ジャンプするときのパワーをSin波で決める*/
			power = (Mathf.Sin (Time.frameCount/10f) + 1) * 50;
			
			//Debug.Log (power);
			//		Debug.Log (human.transform.localPosition.y);
			
			/*クリックしたタイミングでジャンプする*/
			if (Input.GetMouseButtonUp (0))
			{
//				this.transform.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, (int)power * 20+1300, 0));
				// 28 - 97
				this.GetComponent<Rigidbody>().velocity = new Vector3(0.0f, (int)(69.9f/100.0f*power+28.0f), 0.0f);
				jumped = true;
				
				// slider wo kesu
				slider.SetActive(false);
				
			}
			
			slider.GetComponent<Slider>().value = power;
		}

	}
}
