using UnityEngine;
using System.Collections;

public class Colourswitch : MonoBehaviour {

	public Transform ball; 
	private MeshRenderer ballRenderer; 

	// Use this for initialization
	void Start () {
		ballRenderer = ball.GetComponent<MeshRenderer> (); 
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.Q) ) 
	
		{
			ballRenderer.material.color = Color.cyan; 
	
		}
		else  
		{
			ballRenderer.material.color = Color.green; 
		}
	
	}
}
