using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCrystals : MonoBehaviour {
	public int[] x = new int[2];
	public int[] z = new int[2];
	public int SeedCount = 16;
	public GameObject IceSeed;

	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnSeed());
	}
	

	IEnumerator SpawnSeed()
	{
		while(true)
		{
			if(transform.childCount < SeedCount)
			{
				Instantiate(IceSeed,new Vector3(
					Random.Range(x[0],x[1]), 
					transform.position.y,
					Random.Range(z[0],z[1])),
					Quaternion.identity,transform);
			}
			yield return new WaitForSeconds(1);
			yield return null;
		}
	}
}
