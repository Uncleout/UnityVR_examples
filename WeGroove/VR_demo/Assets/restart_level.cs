using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart_level : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void restart()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}
