using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickToOpen_fire : MonoBehaviour , IPointerClickHandler
{

	public GameObject inv;
	public void OnPointerClick(PointerEventData eventData)
	{
		inv.SetActive(true);
	}
}
