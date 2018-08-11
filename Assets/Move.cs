using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour {

	GameObject[] tiles;
	bool right, left, down, up;
	void Update () 
	{
		tiles = GameObject.FindGameObjectsWithTag("Walkable");
		GetInput();
	}

	void OnTriggerStay(Collider col){
		if(col.gameObject.name == "Finish" && tiles.Length <= 1){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		if(col.gameObject.tag == "Walkable"){
			for(int i=0; i < tiles.Length; i++){
				if(tiles[i].transform.position == new Vector3(transform.position.x, 0, transform.position.z + 1))
					up = true;
				else if (tiles[i].transform.position == new Vector3(transform.position.x, 0, transform.position.z - 1))	
					down = true;
				else if (tiles[i].transform.position == new Vector3(transform.position.x + 1, 0, transform.position.z))
					left = true;
				else if(tiles[i].transform.position == new Vector3(transform.position.x - 1, 0, transform.position.z))
					right = true;
			}
		}
	}


	void GetInput()
	{
		if(Input.GetKeyDown(KeyCode.R))SceneManager.LoadScene(SceneManager.GetActiveScene().name);

		for(int i=0; i < tiles.Length; i++){
			if(Input.GetKeyDown(KeyCode.W))
			{
				if(up)
					DoMove(0);
				return;
			}else if(Input.GetKeyDown(KeyCode.S))
			{
				if(down)
					DoMove(1);
				return;
			}else if(Input.GetKeyDown(KeyCode.D))
			{
				if(left)
					DoMove(2);
				return;
			}else if(Input.GetKeyDown(KeyCode.A))
			{
				if(right)
					DoMove(3);
				return;
			}
		}
	}

	void DoMove(int dir)
	{	
		Vector3 pos = transform.position;
		switch(dir){
			case 0:
				pos.z += 1;
				break;
			case 1:
				pos.z -= 1;
				break;
			case 2:
				pos.x += 1;
				break;
			case 3:
				pos.x -= 1;
				break;
			default:
				break;

		}
		right = false;
		left = false;
		up = false;
		down = false;
		transform.position = pos;
	}
}
