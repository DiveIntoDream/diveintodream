using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Jamp : MonoBehaviour {
	public GameObject human;
	float power = 0;
	//double testpower = 0.0;
	Slider _slider;
	// Use this for initialization
	void Start () {
		_slider = GameObject.Find("Slider").GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
		/*ジャンプするときのパワーをSin波で決める*/
		power = (Mathf.Sin (Time.frameCount/10f) + 1) * 50;

		//Debug.Log (power);
		Debug.Log (human.transform.localPosition.y);
		/*クリックしたタイミングでジャンプする*/
		if(human.transform.localPosition.y <= 0)
		{
			if (Input.GetMouseButtonUp (0))
			{
				human.transform.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, (int)power * 20, 0));
			}
		}
		_slider.value = power;
	}
}
