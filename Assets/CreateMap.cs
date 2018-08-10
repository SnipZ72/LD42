using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMap : MonoBehaviour {

	public GameObject cube;

	void Start () 
	{

		for(int i=0; i < 10; i++){
			for(int j=0; j < 10; j++){
				Instantiate(cube, new Vector3(i,0,-j), Quaternion.identity);
			}
		}
		
	}
	
}
