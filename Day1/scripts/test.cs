using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	public Light myLight;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("space")) {
			myLight.enabled = true;
		}
		else
		{
			myLight.enabled = false;
		}
	}
}
