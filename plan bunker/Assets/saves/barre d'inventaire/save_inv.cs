using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class save_inv : MonoBehaviour {

	public GameObject torche;
	public GameObject map;
	public GameObject arrow;
	public GameObject bow;
	public GameObject spear;
	public GameObject coffre_inventaire;
	// Use this for initialization
	void Start () {
		//inventory.invent l = new inventory.invent();
		loadOnExit();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		saveOnExit();
	}

	public void saveOnExit()
	{
		
		coffre.caufre k = new coffre.caufre();
		k.l = list();
		Debug.Log(k.l.Count);
		dataManager_coffre.save(k);
		
	}

	public void loadOnExit()
	{
		coffre.caufre k = dataManager_coffre.load();
		int i = 0;
		while (i < k.l.Count)
		{
			recreation(k.l[i]);
			i += 1;
		}
		

	}

	public GameObject recreation(Tuple<coffre.Type, int, int> l)
	{
		GameObject MyObject = Instantiate(Getprefab(l.Item1)) ; //Create the GameObject
		MyObject.transform.position = coffre_inventaire.transform.GetChild(l.Item2).transform.position;
		MyObject.GetComponent<RectTransform>().SetParent(coffre_inventaire.transform.GetChild(l.Item2)); //Assign the newly created Image GameObject as a Child of the Parent Panel.
		MyObject.transform.localScale = new Vector3(1, 1, 1);
		MyObject.SetActive(true); //Activate the GameObject
		MyObject.name = GetName(l.Item1);
		if (l.Item3 > 1)
		{
			MyObject.transform.GetChild(0).GetComponent<Text>().text = l.Item3 + "";
		}

		return MyObject;

	}

	public List<Tuple<coffre.Type, int, int>> list()
	{
		List<Tuple<coffre.Type, int , int>> l = new List<Tuple<coffre.Type, int, int>>();
		int i = 0;
		while (i < coffre_inventaire.transform.childCount)
		{
			if (coffre_inventaire.transform.GetChild(i).childCount > 0)
			{
				int quantity;
				if (coffre_inventaire.transform.GetChild(i).GetChild(0).GetChild(0).GetComponent<Text>().text == "")
				{
					quantity = 1;
				}
				else
				{
					quantity = int.Parse(coffre_inventaire.transform.GetChild(i).GetChild(0).GetChild(0).GetComponent<Text>().text);
				}
				coffre.Type type = Gettype(coffre_inventaire.transform.GetChild(i).GetChild(0).name);
				Tuple<coffre.Type, int, int> myTuple = new Tuple<coffre.Type, int, int>(type, i, quantity);
				l.Add(myTuple);
			}
			i += 1;

		}
		return l;
	}

	public GameObject Getprefab(coffre.Type type)
	{
		if (type == coffre.Type.SPEAR)
		{
			return spear;
		}
		if (type == coffre.Type.TORCH)
		{
			return torche;
		}
		if (type == coffre.Type.MAP)
		{
			return map;
		}
		if (type == coffre.Type.BOW)
		{
			return bow;
		}
		if (type == coffre.Type.ARROW)
		{
			return arrow;
		}
		throw new NullReferenceException();
	}
	public string GetName(coffre.Type type)
	{
		if (type == coffre.Type.SPEAR)
		{
			return "spear";
		}
		if (type == coffre.Type.TORCH)
		{
			return "torche";
		}
		if (type == coffre.Type.MAP)
		{
			return "map";
		}
		if (type == coffre.Type.BOW)
		{
			return "bow";
		}
		if (type == coffre.Type.ARROW)
		{
			return "arrow";
		}
		throw new NullReferenceException();
	}

	public coffre.Type Gettype(string str)
	{
		if (str == "spear")
		{
			return coffre.Type.SPEAR;
		}
		if (str == "torche")
		{
			return coffre.Type.TORCH;
		}
		if (str == "map")
		{
			return coffre.Type.MAP;
		}
		if (str == "bow")
		{
			return coffre.Type.BOW;
		}
		if (str == "arrow")
		{
			return coffre.Type.ARROW;
		}
		throw new NullReferenceException();
	}
}
