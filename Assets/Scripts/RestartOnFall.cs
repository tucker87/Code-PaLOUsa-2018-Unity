using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartOnFall : MonoBehaviour 
{
	public float restartZone = 50;
	
	void Update () 
	{
		if(transform.position.y < restartZone * -1 || transform.position.y > restartZone )
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
