using UnityEngine;

public class alert_light : MonoBehaviour
{

	public bool is_emergency;
	public AudioClip alarm;

	AudioSource sound;
	
	public Light light;

	private float dlt = 0.01F;
	// Use this for initialization
	void Start ()
	{
		sound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (is_emergency)
			{
				light.color = Color.red;
				sound.PlayOneShot(alarm,0.2F);
				if (light.intensity > 1)
				{
					dlt = -dlt;
					
				}
				if (light.intensity <= 0)
				{
					dlt = -dlt;
				}
				light.intensity += dlt;
			}
		else
			{
				sound.Stop();
				light.color = Color.white;
			}
		
	}
}
