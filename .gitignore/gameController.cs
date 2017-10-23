using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {
	public static Vector3 cubePosition;
	public static float xPosition;
	public static int numCubes;

	public static GameObject myCube;
	public GameObject cubePrefab;

	public static GameObject selectedCube;

	// Use this for initialization
	void Start () {
		numCubes = 16;
		xPosition = -21f;

		for (int i = 0; i < numCubes; i++) {
			cubePosition = new Vector3 (xPosition, 0, 0);
			myCube = Instantiate(cubePrefab, cubePosition, Quaternion.identity);
			myCube.GetComponent<Renderer>().material.color = Color.white;
			xPosition += 3;
		}
	}


	// Update is called once per frame
	void Update (){
		}

}
