using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class table : MonoBehaviour
{
	public GameObject inv;
	public GameObject buttons;
	public GameObject buttons1;
	public GameObject buttons2;
	public GameObject cancel;
	public GameObject cancel1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnMouseDown()
	{
		inv.SetActive(true);
		buttons.SetActive(true);
		buttons1.SetActive(true);
		buttons2.SetActive(true);
		cancel.SetActive(true);
		cancel.SetActive(true);
	}
}
