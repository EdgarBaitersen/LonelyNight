using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class craft_map : MonoBehaviour {

		
	public Sprite item;
	public Text bois_count;
	public Text pierre_count;
	public GameObject Inventory;
	public Text pierre;
	public Text bois;
	public GameObject map;
	private AudioSource source;
		
	
	// Use this for initialization
	void Start ()
	{

		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
	}
	public void Map()
	{
		int bois_nbr = int.Parse(bois_count.text);
		int pierre_nbr = int.Parse(pierre_count.text);
		int pierre_tot = int.Parse(pierre.text);
		int bois_tot = int.Parse(bois.text);
		if (@select(Inventory )!= null) 
		{
			if (bois_tot >= bois_nbr && pierre_tot >= pierre_nbr)
			{
				GameObject Mytorche = Instantiate(map) ; //Create the GameObject
				Mytorche.transform.position = select(Inventory).transform.position;
				Mytorche.GetComponent<RectTransform>().SetParent(@select(Inventory)); //Assign the newly created Image GameObject as a Child of the Parent Panel.
				Mytorche.transform.localScale = new Vector3(1, 1, 1);
				Mytorche.SetActive(true); //Activate the GameObject
				Mytorche.name = "map";
				source.Play();
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
