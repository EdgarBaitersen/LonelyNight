using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gestionFeu : MonoBehaviour
{

	public Text feu;
	float deltaT = 8.0F;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (deltaT <= 0F && int.Parse(feu.text) > 0)
		{
			Timelapse();
			deltaT = 5.0F;
		}
		deltaT -= Time.deltaTime;
		
		

	}

	public void Timelapse()
	{
		int nouveauFeu = int.Parse(feu.text) - 1;
		feu.text = nouveauFeu.ToString();
		
	}
	
	
}
