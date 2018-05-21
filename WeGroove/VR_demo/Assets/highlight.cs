using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highlight : MonoBehaviour
{



	public Color ColourRed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    

	public void OnMouseEnter()
	{
		ColourRed = Color.blue;
		if (GvrPointerInputModule.Pointer.IsPointerIntersecting)
		{
			GameObject.Find("sensor").GetComponent<Renderer>().material.color = ColourRed;
		}

	}
}
