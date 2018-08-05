using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSeedBehavior : MonoBehaviour {
	public GameObject IceFlower;
	public float MinHeight = 0;
	bool isReady = false;

	void Start()
	{
		StartCoroutine(Descend());
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player" && isReady)
		{
			Debug.Log("player touches!");
			StartCoroutine(Dip());
		}
	}

	IEnumerator Descend()
	{
		while(transform.position.y > 0)
		{
			transform.Translate(new Vector3(0,-0.5f*Time.deltaTime,0));
			yield return null;
		}
		isReady = true;
	}

	IEnumerator Dip()
	{
		GetComponent<Animator>().SetBool("IsTouching",true);
		yield return new WaitForSeconds(2);
		Instantiate(IceFlower,new Vector3(transform.position.x, 0, transform.position.z), Quaternion.identity);
		Destroy(gameObject,0.5f);
	}

}
