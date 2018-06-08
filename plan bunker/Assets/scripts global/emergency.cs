using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emergency : MonoBehaviour
{

	public alert_light alert;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		unique.Fire_Data k = DataManager_Fire.load();
		
		if ( k.tempe < 0)
		{
			alert.is_emergency = true;
			
		}
	}
}
