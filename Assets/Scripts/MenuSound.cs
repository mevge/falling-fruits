using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSound : MonoBehaviour {

	AudioSource onClick;

	void Start() 
	{
		onClick = GetComponent<AudioSource>();
	}
	void Update() 
	{
		if(Input.GetMouseButtonDown(0)) {
			onClick.PlayOneShot(onClick.clip);
		}
	}
}
