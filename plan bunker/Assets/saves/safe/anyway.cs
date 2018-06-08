using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class anyway : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
		
	}
	
	float deltaT = 20.0F;
	unique.Fire_Data k = DataManager_Fire.load();
	
	// Update is called once per frame
	void Update () {
		
		if (deltaT <= 0F)
		{
			Timelapse();
			anyways();
			deltaT = 10.0F;
		}
		deltaT -= Time.deltaTime;
		DataManager_Fire.save(k);
		
	}

	public void anyways()
	{
		int nbr_feu = k.wood_fire;
		int nbr_tempe = k.tempe;
		if (nbr_feu <= 0)
		{
			nbr_tempe -= 1;

		}
		else
		{
			if (nbr_feu > 0 && nbr_tempe < 25)
			{
				nbr_tempe += 1;
			}
		}
		k.tempe = nbr_tempe;
		k.wood_fire = nbr_feu;
	}

	public void Timelapse()
		{
			int nouveauFeu = k.wood_fire - 1;
			k.wood_fire = nouveauFeu;

		}
	
}
