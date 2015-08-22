using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarCtrl : MonoBehaviour {
	public float power = 0;

	Slider _slider;
	// Use this for initialization
	void Start () {
		_slider = GameObject.Find ("Slider").GetComponent<Slider> ();
	}

	// Update is called once per frame
	void Update () {
		_slider.value = power;
	}
}
