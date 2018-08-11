using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class CreateMap : MonoBehaviour {

	public GameObject cube;
	public static int levelInt = 1;
	
	void Start () 
	{
		/*
		string text = System.IO.File.ReadAllText("Assets/Level" + levelInt + ".txt");

		char c;
		for(int i=0; i < 10; i++){
			for(int j=0; j < 10; j++){
				c = text[i+j];
				if(c == '#'){
					GameObject g = Instantiate(cube, new Vector3(i,0,j), Quaternion.identity);
					g.GetComponent<Renderer>().materials[0].color = new Color(0,0,0,255);
					g.name = i + " " + j + c;
				}else if(c == '@'){
					GameObject g = Instantiate(cube, new Vector3(i,0,j), Quaternion.identity);
					g.GetComponent<Renderer>().materials[0].color = new Color(1,1,1,255);
					g.name = i + " " + j + c;
				}else{

				}
			}
		}


		/*foreach(char c in text){
			if(c == '#'){
				GameObject g = Instantiate(cube, new Vector3(i,0,-i/10), Quaternion.identity);
				g.GetComponent<Renderer>().materials[0].color = new Color(0,0,0,255);
			}
			if(c == '@'){
				GameObject g = Instantiate(cube, new Vector3(i,0,-i/10), Quaternion.identity);
				g.GetComponent<Renderer>().materials[0].color = new Color(1,1,1,255);
			}
		}*/
		
	}
	
}
