using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour 
{
	public Transform target;
	public float height = 5;
	
	void LateUpdate () 
	{
		transform.position = new Vector3(target.position.x, target.position.y + height, transform.position.z);
	}
}
