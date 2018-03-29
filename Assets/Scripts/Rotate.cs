using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour 
{
	public float rotateSpeed = 100;

	void Update () 
	{
		var rotateZ = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
		transform.Rotate(0, 0, rotateZ*-1);
	}

	void OnCollisionEnter(Collision other)
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}
