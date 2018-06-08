using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class DataManager_Fire : MonoBehaviour {

	public static void save(object entity)
	{
		BinaryFormatter formatter = new BinaryFormatter();
		FileStream stream = File.Create(Application.persistentDataPath + "/" + "fire_data");
		formatter.Serialize(stream,entity);
		stream.Close();
	}

	public static unique.Fire_Data load()
	{
		BinaryFormatter formatter = new BinaryFormatter();
		FileStream stream = File.Open(Application.persistentDataPath + "/" + "fire_data", FileMode.Open);
		unique.Fire_Data entity = (unique.Fire_Data) formatter.Deserialize(stream);
		stream.Close();
		return entity;
	}
}
