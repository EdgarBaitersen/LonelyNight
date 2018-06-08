using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_for_upgrade : MonoBehaviour
{

	public Text text;
	public Text bois;
	public Text pierre;
	public string type;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LeTransport ()
	{
		if (true)
		{
			text.text = "Voulez vous vraiment effectuer l'amélioration \"Le transporter\" ? \n Cela vous coutera 1000 de bois et 1000 de pierre.";
			type = "Transport";
		}
		
	}

	public void Endurance()
	{
		if (true)
		{
			text.text = "Voulez vous vraiment effectuer l'amélioration \"Endurance du survivant\" ? \n Cela vous coutera 1000 de bois et 1000 de pierre.";
			type = "Endurance";
		}
		
		Debug.Log(33);
	}

	public void Chasseur()
	{
		if (true)
		{
			text.text = "Voulez vous vraiment effectuer l'amélioration \" Chasseur expérimenté\" ? \n Cela vous coutera 1000 de bois et 850 de pierre.";
			type = "Chasseur";
		}
		
	}
	public void Mineur()
	{
		if (true)
		{
			text.text = "Voulez vous vraiment effectuer l'amélioration \" Mineur\" ? \n Cela vous coutera 1000 de bois et 850 de pierre.";
			type = "Mineur";
		}
		
	}
	public void Bucheron()
	{
		if (true)
		{
			text.text = "Voulez vous vraiment effectuer l'amélioration \" Bucheron\" ? \n Cela vous coutera 1000 de bois et 850 de pierre.";
			type = "Bucheron";
		}
	}
	
}
