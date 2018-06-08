using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class craft_bow : MonoBehaviour {
	public Sprite item;
	public Text bois_count;
	public Text pierre_count;
	public Text bois;
	public Text pierre;
	public GameObject Inventory;
	public GameObject bow;
	private AudioSource source;

	// Use this for initialization
	void Start ()
	{
		source = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Craft_arc()
	{
		int pierre_tot = int.Parse(pierre.text);
		int bois_tot = int.Parse(bois.text);
		int bois_nbr = int.Parse(bois_count.text);
		int pierre_nbr = int.Parse(pierre_count.text);
		if (@select(Inventory) != null)
		{
			if (bois_tot >= bois_nbr && pierre_tot >= pierre_nbr)
			{

				GameObject MyBow = Instantiate(bow); //Create the GameObject
				MyBow.transform.position = @select(Inventory).transform.position;
				MyBow.GetComponent<RectTransform>()
					.SetParent(@select(Inventory)); //Assign the newly created Image GameObject as a Child of the Parent Panel.
				MyBow.transform.localScale = new Vector3(1, 1, 1);
				MyBow.SetActive(true); //Activate the GameObject
				MyBow.name = "bow";
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
