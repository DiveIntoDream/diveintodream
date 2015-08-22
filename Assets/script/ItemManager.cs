using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour
{
	public GameObject[] items;


	void Start ()
	{
		for(int i = 0;i < items.Length;i++)
		{
			if(items[i] == null)
			{
				Debug.LogError("Null Pointer Exception -> ITEMS["+i+"]");
			}
		}
	}

	private int countItems = 0;
	private int createInterval = 20;
	void Update ()
	{
		float playerPosY = GameObject.FindGameObjectWithTag ("Player").transform.position.y;
		if(playerPosY - 10 > countItems * createInterval + 80)
		{
			createItems(countItems*createInterval + 80);
			countItems++;
		}

	}

	private void createItems(float posy)
	{
		GameObject item = GameObject.Instantiate(items[Random.Range(0,items.Length)]) as GameObject;
		item.GetComponent<Item> ().itemType = Random.Range (0, 5);
		//		int randomId = Random.Range (0, items.Length);
		float y = Random.Range (posy-25, posy-15);
		float x = Random.Range (-7, 7);
		Vector3 v = new Vector3 (x, y, 0.0f);
		item.transform.localPosition = v;
	}
}
