using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class  input : MonoBehaviour
{
	 InputField inpout;
	 InputField.SubmitEvent se;
	public Text bois;
	public Text output;

	// Use this for initialization
	void Start ()
	{
		inpout = gameObject.GetComponent<InputField>();
		se = new InputField.SubmitEvent();
		se.AddListener(SubmitInput);
		inpout.onEndEdit = se;
	}

	private void SubmitInput(string arg0)
	{
		string currentText = output.text;
		if (int.Parse(bois.text) > int.Parse(arg0))
		{
			bois.text = int.Parse(bois.text) - int.Parse(arg0) + "";
		}
		else
		{
			arg0 = "0";
		}
		int truth = int.Parse(arg0) + int.Parse(currentText);
		string newText = "" + truth;
		output.text = newText;
		inpout.text = "";
		inpout.ActivateInputField();
	}

	private string delete(string str)
	{
		int i = 1;
		string str2 = "";
		while (i<str.Length)
		{
			str2 = str2 + str[i];
			i += 1;
		}
		return str2;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
