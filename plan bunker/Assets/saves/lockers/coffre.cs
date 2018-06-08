using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coffre : MonoBehaviour {

	public enum Type
	{
		SPEAR,
		MAP,
		TORCH,
		BOW,
		ARROW,
	}
	[Serializable]
	public class caufre
	{
		public List<Tuple<coffre.Type, int , int>> l = new List<Tuple<Type, int, int>>();
		//(type,slot,quantity)
	}
}
