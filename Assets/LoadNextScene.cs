using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour {

	void Start () {
		Invoke("LoadScene", 20);
	}
	
	void Update () {
		
	}

	void LoadScene(){
		SceneManager.LoadScene("main");
	}
}
