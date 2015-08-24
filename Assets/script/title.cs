using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class title : MonoBehaviour 
{
	
	public Image titleImage;
	public GameObject bar;
	private float startTime = 0.0f;

	void Start () 
	{
		//bar =  GameObject.Find("Slider");
		startTime = Time.time;
		titleImage.gameObject.SetActive (true);
		//bar.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time - startTime > 2.0f){
			//Debug.Log("change scine");
			titleImage.gameObject.SetActive (false);
			bar.gameObject.SetActive(true);
			//Application.LoadLevel("DiveintoDream");
			GameObject.FindGameObjectWithTag("Player").GetComponent<Jamp>().changeTitleFlg();
		}
	}
}
