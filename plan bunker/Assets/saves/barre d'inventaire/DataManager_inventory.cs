using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DataManager_inventory : MonoBehaviour {

	public static void save(object entity)
	{
		BinaryFormatter formatter = new BinaryFormatter();
		FileStream stream = File.Create(Application.persistentDataPath + "/" + "inventory_data");
		formatter.Serialize(stream,entity);
		stream.Close();
	}

	public static inventory.invent load()
	{
		BinaryFormatter formatter = new BinaryFormatter();
		FileStream stream = File.Open(Application.persistentDataPath + "/" + "inventory_data", FileMode.Open);
		inventory.invent entity= (inventory.invent) formatter.Deserialize(stream);
		stream.Close();
		return entity;
	}
}
