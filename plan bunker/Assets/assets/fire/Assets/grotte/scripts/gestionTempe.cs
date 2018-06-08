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
		//unique.Fire_Data k = new unique.Fire_Data();
		loadData();
	}
	
	// Update is called once per frame
	void Update () {
		if (deltaT <= 0F)
		{
			Gestion();
			deltaT = 10.0F;
		}
		deltaT -= Time.deltaTime;
		saveData();
		
		
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

	public void saveData()
	{
		unique.Fire_Data uni = new unique.Fire_Data();
		uni.tempe = int.Parse(tempe.text);
		uni.wood_fire = int.Parse(feu.text);
		DataManager_Fire.save(uni);
		
	}

	public void loadData()
	{
		unique.Fire_Data data = DataManager_Fire.load();
		tempe.text = data.tempe + "";
		feu.text = data.wood_fire + "";

	}
}
