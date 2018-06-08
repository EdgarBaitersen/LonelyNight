using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gestionTempe : MonoBehaviour
{

	public Text feu;
	public Text tempe;
	float deltaT = 20.0F;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (deltaT <= 0F)
		{
			Gestion();
			deltaT = 10.0F;
		}
		deltaT -= Time.deltaTime;
		
	}

	public void Gestion()
	{
		int nbr_feu = int.Parse(feu.text);
		int nbr_tempe = int.Parse(tempe.text);
		if (nbr_feu <= 0 )
		{
			nbr_tempe -= 1;
			tempe.text = nbr_tempe.ToString();
		}
		else
		{
			if (nbr_feu > 0 && nbr_tempe < 25)
			{
				nbr_tempe += 1;
				tempe.text = nbr_tempe.ToString();
			}
			
		}
	}
}
