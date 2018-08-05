using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceFlowerBehavior : MonoBehaviour {
	void Start () {
		int size = Random.Range(8, 12);
		StartCoroutine(Shatter());
	}
	
	IEnumerator Shatter()
	{
		yield return new WaitForSeconds(30);
		GetComponent<Animator>().SetBool("IsShatter",true);
		Destroy(gameObject, 4);
	}
}
