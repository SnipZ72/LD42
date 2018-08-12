﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

	public void RestartGame(){
		SceneManager.LoadScene("SampleScene");
	}
	public void QuitGame(){
		Application.Quit();
	}
}