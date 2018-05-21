using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Scale_script2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		GameObject[] models = GameObject.FindGameObjectsWithTag ("clumb2");
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
	void Update () {
		
	}
	
	public void ScaleDownButton_1() {
		GameObject[] models = GameObject.FindGameObjectsWithTag ("clumb2");
		foreach (GameObject go in models) {
			Transform model = go.transform;
			Vector3 newpos = new Vector3();
			newpos.x = model.localPosition.x;
			newpos.y = model.localPosition.y*1/2;
			newpos.z = model.localPosition.z;
			model.localPosition = newpos;
		}
		
		GameObject.Find("Button7").gameObject.SetActive(false);
		GameObject button8= GameObject.Find("Button8");
		Vector3 but8pos =new  Vector3();
		but8pos.x = button8.transform.localPosition.x;
		but8pos.y = 0;
		but8pos.z = button8.transform.localPosition.z;
		button8.transform.localPosition = but8pos;
		
	}
	
	public void ScaleDownButton_2()
     	{
     		
     		GameObject sensor2= GameObject.Find("sensor2");
     		Vector3 sensor2pos =new  Vector3();
     		sensor2pos.x = sensor2.transform.localPosition.x;
     		sensor2pos.y = 0.6f;
     		sensor2pos.z = sensor2.transform.localPosition.z;
     		sensor2.transform.localPosition = sensor2pos; 
     		    
     		    
     		GameObject.Find("Button8").gameObject.SetActive(false);
     		
     		GameObject button9= GameObject.Find("Button9");
     		Vector3 but9pos =new  Vector3();
     		but9pos.x = button9.transform.localPosition.x;
     		but9pos.y = 0;
     		but9pos.z = button9.transform.localPosition.z;
     		button9.transform.localPosition = but9pos;
     		    	    
     	}
	public void ScaleDownButton_3()
	{
		
		GameObject sensor2= GameObject.Find("sensor2");
		Vector3 sensor2pos =new  Vector3();
		sensor2pos.x = sensor2.transform.localPosition.x;
		sensor2pos.y = -2;
		sensor2pos.z = sensor2.transform.localPosition.z;
		sensor2.transform.localPosition = sensor2pos; 
		    
		    
		GameObject.Find("Button9").gameObject.SetActive(false);
		
		GameObject button10= GameObject.Find("Button10");
		Vector3 but10pos =new  Vector3();
		but10pos.x = button10.transform.localPosition.x;
		but10pos.y = 0;
		but10pos.z = button10.transform.localPosition.z;
		button10.transform.localPosition = but10pos;

		GameObject[] models = GameObject.FindGameObjectsWithTag ("clumb2");
		foreach (GameObject go in models) {
			Transform model = go.transform;
			Vector3 newScale = new Vector3 ();
			newScale.x = model.localScale.x*4;
			newScale.y = model.localScale.y*4;
			newScale.z = model.localScale.z*4;
			model.localScale = newScale;
			
		}
		
	}
}
