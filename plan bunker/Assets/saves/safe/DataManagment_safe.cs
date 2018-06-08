using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class DataManagment_safe : MonoBehaviour {

	public static void save(object entity)
	{
		BinaryFormatter formatter = new BinaryFormatter();
		FileStream stream = File.Create(Application.persistentDataPath + "/" + "upgrade_data");
		formatter.Serialize(stream,entity);
		stream.Close();
	}

	public static upgrades.Upgarde load()
	{
		BinaryFormatter formatter = new BinaryFormatter();
		FileStream stream = File.Open(Application.persistentDataPath + "/" + "upgrade_data", FileMode.Open);
		upgrades.Upgarde entity= (upgrades.Upgarde) formatter.Deserialize(stream);
		stream.Close();
		return entity;
	}
}
