using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{

	public GameObject Canvas;

	// Use this for initialization
	void Start ()
	{
		//Canvas.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
			GoToPlan();

	}

	public void GoToCraft()
	{
		SceneManager.LoadScene("craft room");
	}

	public void GoToFire()
	{
		SceneManager.LoadScene("fire room");
	}

	public void GoToStorage()
	{
		SceneManager.LoadScene("rze");
	}

	public void GoToPlan()
	{
		Canvas.SetActive(!Canvas.active);
	}

	public void GoToSafe()
	{
		SceneManager.LoadScene("safe room");
	}
}
