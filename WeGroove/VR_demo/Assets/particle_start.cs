using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.Utility;

public class particle_start : MonoBehaviour
{
	protected bool letplay = true;

	ParticleSystem system
	{
		get
		{
			if (_CachedSystem == null)
				_CachedSystem = GetComponent<ParticleSystem>();
			return _CachedSystem;
		}
	}
	private ParticleSystem _CachedSystem;

	

	public bool includeChildren = true;
	

	// Use this for initialization
	void Start ()
	{
        
		system.Stop(includeChildren);
		

	}
	
	// Update is called once per frame
	void Update ()
	{

		
		
	}

	public void ScaleDownButton2()
	{
		system.Play(includeChildren);    
		Invoke("StopEmitter", 5);    //start function off particle
		GameObject.Find("Button2").gameObject.SetActive(false);   //disavle button2
		
		
		
		
		
	}

	public void StopEmitter()
	{
		GameObject.Find("particle1").gameObject.SetActive(false);  // Kill particle
		
		GameObject button3= GameObject.Find("Button3");   //enable new button
		Vector3 but3pos =new  Vector3();
		but3pos.x = button3.transform.localPosition.x;
		but3pos.y = 0;
		but3pos.z = button3.transform.localPosition.z;
		button3.transform.localPosition = but3pos;
		
		GameObject[] models = GameObject.FindGameObjectsWithTag ("clumb1"); //Scale objects
		foreach (GameObject go in models) {
			Transform model = go.transform;
			Vector3 newScale = new Vector3 ();
			newScale.x = model.localScale.x*2;
			newScale.y = model.localScale.y*2;
			newScale.z = model.localScale.z*2;
			model.localScale = newScale;
			
		}       
	}
	
	

}
