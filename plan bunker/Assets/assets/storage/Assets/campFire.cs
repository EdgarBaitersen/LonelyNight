using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class campFire : MonoBehaviour
{

	public Text bois;
	public GameObject fire;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		int nbr_bois = int.Parse(bois.text);
		if (nbr_bois == 0)
		{
			fire.SetActive(false);
		}
		else
		{
			fire.SetActive(true);
		}
		
	}
}
