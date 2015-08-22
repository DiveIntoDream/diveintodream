using UnityEngine;
using System.Collections;

public class Jamp : MonoBehaviour {
	public GameObject human;
	double power = 0;
	//double testpower = 0.0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		/*ジャンプするときのパワーをSin波で決める*/
		power = (Mathf.Sin (Time.frameCount) + 1) * 100;

		//Debug.Log (power);
		Debug.Log (human.transform.localPosition.y);
		/*クリックしたタイミングでジャンプする*/
		if(human.transform.localPosition.y <= 0)
		{
			if (Input.GetMouseButtonUp (0))
			{
				human.transform.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, (int)power * 10, 0));
			}
		}
	}
}
