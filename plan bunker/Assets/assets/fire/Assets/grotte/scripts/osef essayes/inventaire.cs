using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventaire : MonoBehaviour {

	GameObject P;
	public int[] slot;

	void Start()
	{
		P = transform.GetChild(0).gameObject;
		slot = new int[P.transform.childCount];
	}

	public void fireInc()
	{
		print("ez fire");
	}
    
	public void unknownInc()
	{
		print("ez unknown");
	}
	public void UpdateTXT (int nrslot,string txt)
	{
		P.transform.GetChild(nrslot).GetChild(1).GetComponent<Text>().text = txt;
	}
}
