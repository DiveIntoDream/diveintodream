using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public int hightscore = 0;
	public GameObject player;
	public Text text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (hightscore < (int)player.transform.localPosition.y) {
			hightscore = (int)player.transform.localPosition.y;
		}

		text.text = "Hight : "+hightscore + "km";
	}

	void OnGUI()
	{
		GUI.backgroundColor = new Color (255.0f,255.0f,255.0f,80.0f);
	}
}
