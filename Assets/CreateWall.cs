using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour {


	void OnTriggerExit (Collider col) {
		if(col.gameObject.tag == "Player"){
			Destroy(gameObject);
		}
	}
}
