using UnityEngine;
using System.Collections;

public class DeleteDeathZone : MonoBehaviour
{
	/** 何かに触れたときをタグで判定 */
	void OnTriggerStay(Collider other)
	{
		// 掃除機に吸い込まれたら *
		if (other.gameObject.tag.Equals("DeathZone"))
		{
			Debug.Log("I touch death zone.");
			Destroy(this.gameObject);
		}
	}
}