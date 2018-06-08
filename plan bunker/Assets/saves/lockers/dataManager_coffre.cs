using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class dataManager_coffre : MonoBehaviour {

	public static void save(object entity)
	{
		BinaryFormatter formatter = new BinaryFormatter();
		FileStream stream = File.Create(Application.persistentDataPath + "/" + "coffre_data");
		formatter.Serialize(stream,entity);
		stream.Close();
	}

	public static coffre.caufre load()
	{
		BinaryFormatter formatter = new BinaryFormatter();
		FileStream stream = File.Open(Application.persistentDataPath + "/" + "coffre_data", FileMode.Open);
		coffre.caufre entity= (coffre.caufre) formatter.Deserialize(stream);
		stream.Close();
		return entity;
	}
}
