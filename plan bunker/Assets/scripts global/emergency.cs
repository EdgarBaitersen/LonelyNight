using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emergency : MonoBehaviour
{

	public alert_light alert;

	public gestionTempe tempe;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (int.Parse(tempe.tempe.text) < 0)
		{
			alert.is_emergency = true;
			Debug.Log(32);
		}
	}
}
