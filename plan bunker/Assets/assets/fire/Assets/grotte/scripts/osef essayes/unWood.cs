using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unWood : MonoBehaviour {

	wood inventory_script;
	float time = 5.0f;
	private void Start()
	{
		inventory_script = GameObject.Find("Fire.I").GetComponent<wood>();
		
	}
	private void Update()
	{
		
		int nbrSlot = transform.parent.GetSiblingIndex();
		time -= Time.deltaTime;
		if (inventory_script.slot[nbrSlot] <= 0)
		{
			print("Le feu est etteint vous allez perdre de la vie");
		}
		else
		{
			if (time <= 0 )
			{
				inventory_script.slot[nbrSlot] -= 1;
				inventory_script.UpdateTXT(nbrSlot, inventory_script.slot[nbrSlot].ToString());
				time = 5.0f;
			}
		}
		
	}
}
