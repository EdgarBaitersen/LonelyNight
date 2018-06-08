using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class Craft : MonoBehaviour
{
	public Sprite item;
	public Text cout_bois;
	public Text cout_pierre;
	public Text bois;
	public Text pierre;
	public GameObject Inventory;
	public GameObject Panel;
	public GameObject torche;
	AudioSource audio;
	
	
	// Use this for initialization
	void Start ()
	{
		audio = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
	}
	public void Torche()
	{
		int pierre_tot = int.Parse(pierre.text);
		int bois_tot = int.Parse(bois.text);
		int bois_nbr = int.Parse(cout_bois.text);
		int pierre_nbr = int.Parse(cout_pierre.text);
		if (@select(Inventory )!= null) 
		{
			if (bois_tot >= bois_nbr && pierre_tot >= pierre_nbr)
			{
				GameObject Mytorche = Instantiate(torche) ; //Create the GameObject
				Mytorche.transform.position = select(Inventory).transform.position;
				Mytorche.GetComponent<RectTransform>().SetParent(@select(Inventory)); //Assign the newly created Image GameObject as a Child of the Parent Panel.
				Mytorche.transform.localScale = new Vector3(1, 1, 1);
				Mytorche.SetActive(true); //Activate the GameObject
				Mytorche.name = "torche";
				audio.Play();
				pierre_tot -= pierre_nbr;
				bois_tot -= bois_nbr;
				bois.text = bois_tot + "";
				pierre.text = pierre_tot + "";
			}
			
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
