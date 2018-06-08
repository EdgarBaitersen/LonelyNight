using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wood : MonoBehaviour {

	// Use this for initialization
	 GameObject P;
	public int[] slot;
	void Start ()
	{
		P = transform.GetChild(0).gameObject;
		slot = new int[P.transform.childCount];
	}
	public void UpdateTXT (int nrslot,string txt)
	{
		P.transform.GetChild(nrslot).GetChild(1).GetComponent<Text>().text = txt;
	}
	
	
}
