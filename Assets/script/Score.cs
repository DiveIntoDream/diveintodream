using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public int hightscore = 0;
	private GameObject player;
	public Text text;
	public Text cushontext;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");

	}
	PlayerStatus ps = new PlayerStatus();
	// Update is called once per frame
	void Update () {
		if (hightscore < (int)player.transform.localPosition.y) {
			hightscore = (int)player.transform.localPosition.y;
		}

		text.text = "Hight : "+hightscore + "km";

	}
	public void showCushonNum(){
		cushontext.text = "クッションを\n"+player.GetComponent<PlayerStatus> ().getCushionNum ()+"個吹き飛ばした！";
	}
	void OnGUI()
	{
		GUI.backgroundColor = new Color (255.0f,255.0f,255.0f,80.0f);
	}
}
