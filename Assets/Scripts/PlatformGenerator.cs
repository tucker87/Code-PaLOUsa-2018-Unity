using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour 
{
	public GameObject platform;
	public Transform generationPoint;
	public float distanceMin = 4;
	public float distanceMax = 10;
	public float heightModifier = 4;
	
	private float platformWidth = 10;
	
	void Update () 
	{
		var distanceBetween = Random.Range(distanceMin, distanceMax);
		var height = Random.Range(transform.position.y - heightModifier, transform.position.y + heightModifier);

		if(transform.position.x < generationPoint.position.x)
		{
			transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, height);
			Instantiate(platform, transform.position, platform.transform.rotation);
			transform.ro
		}
	}
}
