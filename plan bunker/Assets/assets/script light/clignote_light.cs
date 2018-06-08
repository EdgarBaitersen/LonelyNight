using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;
using Random = System.Random;


public class clignote_light : MonoBehaviour
{
	public GameObject lampe;
	public AudioClip clip;
	private Random dlt = new Random();
	private AudioSource source;
	float tps;
	
	// Use this for initialization
	void Start () {
		var l = lampe.GetType().GetProperties();
		source = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		int rand = dlt.Next(0,100);
		tps += Time.deltaTime;
		if (rand == 3)
		{
			tps = 0;
			lampe.GetComponent<Light>().enabled = false;
			lampe.GetComponent<Renderer>().material.SetColor("_EmissionColor",Color.black);	
			source.Play();
		}
		if (tps > 0.5)
		{
			source.Pause();
			lampe.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.white);
			lampe.GetComponent<Light>().enabled = true;
			source.Pause();
			tps = 0;
		}
	}
}
