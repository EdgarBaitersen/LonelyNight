using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToOpen : MonoBehaviour
{

	public GameObject inv;
	// Use this for initialization
	private void OnMouseDown()
	{
		inv.SetActive(true);
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
