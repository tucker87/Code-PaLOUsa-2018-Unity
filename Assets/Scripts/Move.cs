using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{	
	public float moveSpeed = 10;

	void Update () 
	{
		var moveX = moveSpeed * Time.deltaTime;
		transform.Translate(moveX, 0, 0);
	}
}
