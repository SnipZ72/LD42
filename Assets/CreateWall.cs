using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour {

	private bool die = false;
	void Update(){
		if(die){
			transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, -2,transform.position.z), 0.3f * Time.deltaTime);
			gameObject.tag = "NotWalkable";
		}
	}

	void OnTriggerExit (Collider col) {
		if(col.gameObject.tag == "Player"){
			die = true;
		}
	}
}
