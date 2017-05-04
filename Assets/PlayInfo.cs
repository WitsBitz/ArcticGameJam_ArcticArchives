using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayInfo : MonoBehaviour {

	private AudioSource audioSource;
	private GameObject player;
	bool hasPlayed = false;

	void Awake () {
		audioSource = GetComponent<AudioSource>();
		player = GameObject.FindGameObjectWithTag("Player");
		Debug.Log(Vector3.Distance(this.transform.position, player.transform.position));
	}

	void Update(){
		if(Vector3.Distance(this.transform.position, player.transform.position) < 10 && hasPlayed == false)
		{
			audioSource.Play();
			hasPlayed = true;
		}
	}
}
