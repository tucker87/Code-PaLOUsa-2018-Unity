using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour 
{	
	Rigidbody rb;
	public float height = 10;
	public AudioClip[] jumpSound;
	public bool grounded;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update () 
	{
		if(Input.GetButton("Jump") && grounded)
		{
			grounded = false;
			SoundManager.Instance.Play(jumpSound);
			rb.velocity = Vector3.up * height;
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Ground")
			grounded = true;
	}
}
