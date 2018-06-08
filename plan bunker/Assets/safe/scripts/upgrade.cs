using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgrade : MonoBehaviour
{
	public text_for_upgrade script;

	public Button amelioration;
	// Use this for initialization
	void Start () {
		
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
	}
	public void click_bucheron()
	{
		if (int.Parse(script.bois.text) >= 1000 || int.Parse(script.pierre.text) >= 850)
		{
			script.bois.text = (int.Parse(script.bois.text) - 1000) + "";
			script.pierre.text = int.Parse(script.pierre.text) - 850 + "";
			Debug.Log(21);
		}
	}
	public void click_Mineur()
	{
		if (int.Parse(script.bois.text) >= 1000 || int.Parse(script.pierre.text) >= 850)
		{
			script.bois.text = (int.Parse(script.bois.text) - 1000) + "";
			script.pierre.text = int.Parse(script.pierre.text) - 850 + "";
			
		}
		
	}
	public void click_Chasseur()
	{
		if (int.Parse(script.bois.text) >= 1000 || int.Parse(script.pierre.text) >= 850)
		{
			script.bois.text = (int.Parse(script.bois.text) - 1000) + "";
			script.pierre.text = int.Parse(script.pierre.text) - 850 + "";
		}
	}
	public void click_Endurance()
	{
		if (int.Parse(script.bois.text) >= 1000 || int.Parse(script.pierre.text) >= 1000)
		{
			script.bois.text = (int.Parse(script.bois.text) - 1000) + "";
			script.pierre.text = int.Parse(script.pierre.text) - 1000 + "";
		}
	}
	public void click_Transport()
	{
		if (int.Parse(script.bois.text) >= 1000 || int.Parse(script.pierre.text) >= 1000)
		{
			script.bois.text = (int.Parse(script.bois.text) - 1000) + "";
			script.pierre.text = int.Parse(script.pierre.text) - 1000 + "";
		}
	}
}
