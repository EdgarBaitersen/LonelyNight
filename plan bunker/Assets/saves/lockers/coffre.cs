using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coffre : MonoBehaviour {

	public enum Type
	{
		SPEAR,
		MAP,
		TORCH,
		BOW,
		ARROW,
	}
	public class caufre
	{
		public int quantity;
		public int slot;
		public Type type;
	}
}
