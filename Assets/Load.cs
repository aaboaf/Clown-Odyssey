﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Load : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string sceneName = "ClassroomMap";
		Debug.Log ("Prepping load");

		UnityEngine.SceneManagement.SceneManager.LoadScene (sceneName);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
