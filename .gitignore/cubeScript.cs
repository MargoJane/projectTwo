using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour {

	void OnMouseDown(){
		gameObject.GetComponent<Renderer> ().material.color = Color.red;

		if (gameController.selectedCube != null) {
			gameController.selectedCube.GetComponent<Renderer> ().material.color = Color.white;
		}
		gameController.selectedCube = gameObject;
	}

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		
	}

}

