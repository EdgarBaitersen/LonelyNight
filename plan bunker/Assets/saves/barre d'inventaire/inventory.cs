using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class inventory : MonoBehaviour {

	public enum Type
	{
		SPEAR,
		MAP,
		TORCH,
		BOW,
		ARROW,
	}
	[Serializable]
	public class invent
	{
		public List<Tuple<inventory.Type, int , int>> l = new List<Tuple<Type, int, int>>();
		//(type,slot,quantity)
	}
}
