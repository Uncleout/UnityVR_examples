using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Google.ProtocolBuffers;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class move : MonoBehaviour
{

	
	
	void Start()
	{
		

		
	}

	void Update()
	{
		
		
		
	}

	public void position()
	{
		
		// GameObject.Find("Head").transform.position += new Vector3(0f,2f,0f);     works fine 
		
		Vector3 pos = GameObject.Find("Cube").transform.position;
		
	
		//Debug.Log("Pos" + pos);
		GameObject.Find("Head").transform.position = pos;
		
	}
	
	public void position1()
	{
		
		// GameObject.Find("Head").transform.position += new Vector3(0f,2f,0f);     works fine 
		
		Vector3 pos1 = GameObject.Find("Cube1").transform.position;
		
	
		//Debug.Log("Pos" + pos);
		GameObject.Find("Head").transform.position = pos1;
		
	}
	
	public void position2()
	{
		
		// GameObject.Find("Head").transform.position += new Vector3(0f,2f,0f);     works fine 
		
		Vector3 pos2 = GameObject.Find("Cube2").transform.position;
		
	
		//Debug.Log("Pos" + pos);
		GameObject.Find("Head").transform.position = pos2;
		
	}
	
	public void position3()
	{
		
		// GameObject.Find("Head").transform.position += new Vector3(0f,2f,0f);     works fine 
		
		Vector3 pos3 = GameObject.Find("Cube3").transform.position;
		
	
		//Debug.Log("Pos" + pos);
		GameObject.Find("Head").transform.position = pos3;
		
	}
	
	public void position4()
	{
		
		// GameObject.Find("Head").transform.position += new Vector3(0f,2f,0f);     works fine 
		
		Vector3 pos4 = GameObject.Find("Cube4").transform.position;
		
	
		//Debug.Log("Pos" + pos);
		GameObject.Find("Head").transform.position = pos4;
		
	}
	public void position5()
	{
		
		// GameObject.Find("Head").transform.position += new Vector3(0f,2f,0f);     works fine 
			
		Vector3 pos5 = GameObject.Find("Cube5").transform.position;
		
	
		//Debug.Log("Pos" + pos);
		GameObject.Find("Head").transform.position = pos5;
		
	}
	public void position6()
	{
		
		// GameObject.Find("Head").transform.position += new Vector3(0f,2f,0f);     works fine 
		
		Vector3 pos6 = GameObject.Find("Cube6").transform.position;
		
	
		//Debug.Log("Pos" + pos);
		GameObject.Find("Head").transform.position = pos6;
		
	}
	public void position7()
	{
		
		// GameObject.Find("Head").transform.position += new Vector3(0f,2f,0f);     works fine 
		
		Vector3 pos7 = GameObject.Find("Cube7").transform.position;
		
	
		//Debug.Log("Pos" + pos);
		GameObject.Find("Head").transform.position = pos7;
		
	}
}
   
