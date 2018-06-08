using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class DataManagar_backpack : MonoBehaviour {

	public static void save(object entity)
	{
		BinaryFormatter formatter = new BinaryFormatter();
		FileStream stream = File.Create(Application.persistentDataPath + "/" + "has_backpack");
		formatter.Serialize(stream,entity);
		stream.Close();
		
	}

	public static class_backpack.Backpack load()
	{
		BinaryFormatter formatter = new BinaryFormatter();
		FileStream stream = File.Open(Application.persistentDataPath + "/" + "has_backpack", FileMode.Open);
		class_backpack.Backpack entity= (class_backpack.Backpack) formatter.Deserialize(stream);
		stream.Close();
		return entity;
	}
}
