using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockers : MonoBehaviour {

	public GameObject inv;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseDown()
	{
		inv.SetActive(true);
		Debug.Log(34);
	}
}
