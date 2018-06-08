using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class craft_spear : MonoBehaviour
{
	public Sprite item;
	public Text bois_count;
	public Text pierre_count;
	public Text bois;
	public Text pierre;
	public int quantity;
	public GameObject Inventory;
	public GameObject spear;

	private AudioSource source;
	// Use this for initialization
	void Start()
	{
		source = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void Craft_spear()
	{
		int bois_nbr = int.Parse(bois_count.text);
		int pierre_nbr = int.Parse(pierre_count.text);
		int pierre_tot = int.Parse(pierre.text);
		int bois_tot = int.Parse(bois.text);
		if (@select(Inventory)!= null)
		{
			if (bois_tot >= bois_nbr && pierre_tot >= pierre_nbr)
			{
				GameObject Myspear = Instantiate(spear) ; //Create the GameObject
				Myspear.transform.position = @select(Inventory).transform.position;
				Myspear.GetComponent<RectTransform>().SetParent(@select(Inventory)); //Assign the newly created Image GameObject as a Child of the Parent Panel.
				Myspear.transform.localScale = new Vector3(1, 1, 1);
				Myspear.SetActive(true); //Activate the GameObject
				Myspear.name = "spear";
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
			if (inventory.transform.GetChild(i).childCount== 0)
			{
				return inventory.transform.GetChild(i);
			}
			i += 1;
		}
		return null;
	}
}
