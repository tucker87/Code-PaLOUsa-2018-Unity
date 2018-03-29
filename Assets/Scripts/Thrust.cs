using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour 
{
	Rigidbody rb;
	public float height = 100;
	public AudioClip[] jumpSound;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update () 
	{
		if(Input.GetButton("Jump"))
		{
			//SoundManager.Instance.Play(jumpSound);
			rb.velocity += transform.right * height * Time.deltaTime;
		}
	}
}
