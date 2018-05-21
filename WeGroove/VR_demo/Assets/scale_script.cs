using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		
		GameObject[] models = GameObject.FindGameObjectsWithTag ("clumb1");
		foreach (GameObject go in models) {
			Transform model = go.transform;
			Vector3 newScale = new Vector3 ();
			newScale.x = model.localScale.x*1/4;
			newScale.y = model.localScale.y*1/4;
			newScale.z = model.localScale.z*1/4;
			model.localScale = newScale;
			Vector3 newpos = new Vector3();
			newpos.x = model.localPosition.x;
			newpos.y = model.localPosition.y*2;
			newpos.z = model.localPosition.z;
			model.localPosition = newpos;
		}                             
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		
	}

	


	
	public void ScaleDownButton() {
		GameObject[] models = GameObject.FindGameObjectsWithTag ("clumb1");
		foreach (GameObject go in models) {
			Transform model = go.transform;
			Vector3 newpos = new Vector3();
			newpos.x = model.localPosition.x;
			newpos.y = model.localPosition.y*1/2;
			newpos.z = model.localPosition.z;
			model.localPosition = newpos;
		}
		
		GameObject.Find("Button").gameObject.SetActive(false);
		GameObject button1= GameObject.Find("Button1");
		Vector3 but1pos =new  Vector3();
		but1pos.x = button1.transform.localPosition.x;
		but1pos.y = 0;
		but1pos.z = button1.transform.localPosition.z;
		button1.transform.localPosition = but1pos;
		
	}
		
	    public void ScaleDownButton1()
	    {
		
		    GameObject sensor= GameObject.Find("sensor");
		    Vector3 sensorpos =new  Vector3();
		    sensorpos.x = sensor.transform.localPosition.x;
		    sensorpos.y = -56;
		    sensorpos.z = sensor.transform.localPosition.z;
		    sensor.transform.localPosition = sensorpos; 
		    
		    
		    
		    GameObject button2= GameObject.Find("Button2");
		    Vector3 but2pos =new  Vector3();
		    but2pos.x = button2.transform.localPosition.x;
		    but2pos.y = 0;
		    but2pos.z = button2.transform.localPosition.z;
		    button2.transform.localPosition = but2pos;
		    
		    GameObject.Find("Button1").gameObject.SetActive(false);
		    
		    
		    
	    }

	}

	

