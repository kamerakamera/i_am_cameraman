﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score_key : MonoBehaviour {

	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z)) {
            Texture_hey.Save();
            SceneManager.LoadScene("GameSelect");
        }	
	}
}
