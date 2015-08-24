using UnityEngine;
using System.Collections;

public class Tweet : MonoBehaviour {
	private GameObject player;
	private GameObject scoretext;

	private int hightscore = 0;
	private int cushonscore = 0;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		scoretext = GameObject.FindGameObjectWithTag ("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		}
	public void OnClick() {
		cushonscore = player.GetComponent<PlayerStatus> ().getCushionNum ();
		hightscore = scoretext.GetComponent<Score> ().getHightScore ();
		// WebブラウザのTwitter投稿画面を開く
		Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL("ユニティちゃんが上空"+hightscore+"kmまでジャンプして、"+cushonscore+"個のクッションを吹き飛ばしました！\nhttp://goo.gl/vgRpvS #did"));
	}
}
