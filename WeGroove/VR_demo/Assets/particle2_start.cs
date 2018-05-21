using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle2_start : MonoBehaviour
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
	void Start()
	{
		system.Stop(includeChildren);
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void ScaleDownButton3()
	{
		system.Play(includeChildren);
		Invoke("StopEmitter", 5); //start function off particle
		GameObject.Find("Button3").gameObject.SetActive(false); //disavle button2

	}

	public void StopEmitter()
	{
		GameObject.Find("particle2").gameObject.SetActive(false); // Kill particle

		GameObject button4 = GameObject.Find("Button4"); //enable new button
		Vector3 but4pos = new Vector3();
		but4pos.x = button4.transform.localPosition.x;
		but4pos.y = 0;
		but4pos.z = button4.transform.localPosition.z;
		button4.transform.localPosition = but4pos;

		GameObject[] models = GameObject.FindGameObjectsWithTag("clumb1"); //Scale objects
		foreach (GameObject go in models)
		{
			Transform model = go.transform;
			Vector3 newScale = new Vector3();
			newScale.x = model.localScale.x * 2;
			newScale.y = model.localScale.y * 2;
			newScale.z = model.localScale.z * 2;
			model.localScale = newScale;

		}
		
		
		GameObject.Find("sensor").gameObject.SetActive(false);  //Disable sensor
		
	}

	public void ScaleDownButton4()
	{
		GameObject button5 = GameObject.Find("Button5"); //enable new button
		Vector3 but5pos = new Vector3();
		but5pos.x = button5.transform.localPosition.x;
		but5pos.y = 2;
		but5pos.z = button5.transform.localPosition.z;
		button5.transform.localPosition = but5pos;
		
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
