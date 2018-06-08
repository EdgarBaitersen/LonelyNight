using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backpack : MonoBehaviour {
	public Sprite item;
	public Text bois;
	public Text pierre;
	public Text bois_cout;
	public Text pierre_cout;
	public GameObject message;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	
	public void Backpack()
	{
		int pierre_tot = int.Parse(pierre.text);
		int bois_tot = int.Parse(bois.text);
		int bois_nbr = int.Parse(bois_cout.text);
		int pierre_nbr = int.Parse(pierre_cout.text);
		if (bois_tot >= bois_nbr && pierre_tot >= pierre_nbr) 
		{
			pierre_tot -= pierre_nbr;
			bois_tot -= bois_nbr;
			bois.text = bois_tot + "";
			pierre.text = pierre_tot + "";
			audio.Play();
			message.SetActive(true);
		}
		else
		{
			print("vous n avez pas assez de ressource");
		}
		
    		
	}
	public Transform select(GameObject inventory)
	{
		int i = 0;
		
		while (i < 5)
		{
			

			if (inventory.transform.GetChild(i).childCount == 0)
			{
				return inventory.transform.GetChild(i);
			}
			i += 1;
		}
		return null;
	}
}
