using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgrade : MonoBehaviour
{
	public text_for_upgrade script;
	public Button amelioration;

	private int bucheron_rate;
	private int transport_int;
	private int chasseur_rate;
	private int endurance_rate;
	private int mineur_rate;
	// Use this for initialization
	void Start () {
		//upgrades.Upgarde l = new upgrades.Upgarde();
		load_Up();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (script.type == "Bucheron")
		{
			if (int.Parse(script.bois.text) < 1000 || int.Parse(script.pierre.text) < 850)
			{
				amelioration.interactable = false;
			}
			else
			{
				amelioration.interactable = true;
				amelioration.onClick.AddListener(click_bucheron);
			}
		}
		if (script.type == "Transport")
		{
			if (int.Parse(script.bois.text) < 1000 || int.Parse(script.pierre.text) < 1000)
			{
				amelioration.interactable = false;
			}
			else
			{
				amelioration.interactable = true;
				amelioration.onClick.AddListener(click_Transport);
			}
		}
		if (script.type == "Mineur" )
		{
			if (int.Parse(script.bois.text) < 1000 || int.Parse(script.pierre.text) < 850)
			{
				amelioration.interactable = false;
			}
			else
			{
				amelioration.interactable = true;
				amelioration.onClick.AddListener(click_Mineur);
			}
		}
		if (script.type == "Endurance")
		{
			if (int.Parse(script.bois.text) < 1000 || int.Parse(script.pierre.text) < 1000)
			{
				amelioration.interactable = false;
			}
			else
			{
				amelioration.interactable = true;
				amelioration.onClick.AddListener(click_Endurance);
			}
		}
		if (script.type == "Chasseur")
		{
			if (int.Parse(script.bois.text) < 1000 || int.Parse(script.pierre.text) < 850)
			{
				amelioration.interactable = false;
			}
			else
			{
				amelioration.interactable = true;
				amelioration.onClick.AddListener(click_Chasseur);
			}
		}
		save_Up();
	}
	public void click_bucheron()
	{
		if (int.Parse(script.bois.text) >= 1000 || int.Parse(script.pierre.text) >= 850)
		{
			script.bois.text = (int.Parse(script.bois.text) - 1000) + "";
			script.pierre.text = int.Parse(script.pierre.text) - 850 + "";
			bucheron_rate += 10;

		}
	}
	public void click_Mineur()
	{
		if (int.Parse(script.bois.text) >= 1000 || int.Parse(script.pierre.text) >= 850)
		{
			script.bois.text = (int.Parse(script.bois.text) - 1000) + "";
			script.pierre.text = int.Parse(script.pierre.text) - 850 + "";
			mineur_rate += 10;

		}
		
	}
	public void click_Chasseur()
	{
		if (int.Parse(script.bois.text) >= 1000 || int.Parse(script.pierre.text) >= 850)
		{
			script.bois.text = (int.Parse(script.bois.text) - 1000) + "";
			script.pierre.text = int.Parse(script.pierre.text) - 850 + "";
			chasseur_rate += 10;
		}
	}
	public void click_Endurance()
	{
		if (int.Parse(script.bois.text) >= 1000 || int.Parse(script.pierre.text) >= 1000)
		{
			script.bois.text = (int.Parse(script.bois.text) - 1000) + "";
			script.pierre.text = int.Parse(script.pierre.text) - 1000 + "";
			endurance_rate += 10;
		}
	}
	public void click_Transport()
	{
		if (int.Parse(script.bois.text) >= 1000 || int.Parse(script.pierre.text) >= 1000)
		{
			script.bois.text = (int.Parse(script.bois.text) - 1000) + "";
			script.pierre.text = int.Parse(script.pierre.text) - 1000 + "";
			transport_int += 20;
		}
	}

	public void save_Up()
	{
		upgrades.Upgarde k = new upgrades.Upgarde();
		k.bucheron = bucheron_rate;
		k.endurance = endurance_rate;
		k.chasseur = chasseur_rate;
		k.mineur = chasseur_rate;
		k.transport = chasseur_rate;
		DataManagment_safe.save(k);
	}

	public void load_Up()
	{
		upgrades.Upgarde k = DataManagment_safe.load();
		bucheron_rate = k.bucheron;
		mineur_rate = k.mineur;
		endurance_rate = k.endurance;
		transport_int = k.transport;
		chasseur_rate = k.chasseur;
	}
}
