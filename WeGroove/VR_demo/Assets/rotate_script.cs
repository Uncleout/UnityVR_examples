using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility.Inspector;

public class rotate_script : MonoBehaviour
{

	public float speed;
	
	
	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		
		transform.Rotate(0,speed,0);
		
	}
}
