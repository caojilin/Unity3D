using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public Transform sphere;

	// Update is called once per frame	
	void Update () 
	{
	
	sphere.position += new Vector3 (Input.GetAxis("Horizontal"), 0, 0);

	}
}