using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	void Update () 
	{
		GetInput();
	}

	void GetInput()
	{
		Vector3 pos = transform.position;
		if(Input.GetKeyDown(KeyCode.W))
		{
			pos.z += 1;
			transform.position = pos;
			return;
		}else if(Input.GetKeyDown(KeyCode.S))
		{
			pos.z -= 1;
			transform.position = pos;
			return;
		}else if(Input.GetKeyDown(KeyCode.D))
		{
			pos.x += 1;
			transform.position = pos;
			return;
		}else if(Input.GetKeyDown(KeyCode.A))
		{
			pos.x -= 1;
			transform.position = pos;
			return;
		}
	}
}
