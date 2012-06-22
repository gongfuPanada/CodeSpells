using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ObjectManager {
	
	static Dictionary<string, GameObject> objects = new Dictionary<string, GameObject>();
	
	public static void Register(GameObject obj)
	{
		Debug.Log("Enchantable: " + obj.name + " " + obj.GetInstanceID().ToString());
		
		objects.Add(obj.GetInstanceID().ToString(), obj);
		
	}
	
	public static void Register(GameObject obj, string id)
	{
		Debug.Log("Enchantable: " + obj.name + " " + id);
		
		objects.Add(id, obj);
		
	}
	
	public static void Reregister(GameObject ob, string id, string new_id)
	{
		if(objects.ContainsKey(new_id))
		{
			throw new System.ArgumentException();
		}
		
		GameObject obj = objects[id];
		objects.Remove(id);
		objects.Add(new_id,obj);
	}

	public static GameObject FindById(string id)
	{
		
		return objects[id];	
	}
	
	public static Dictionary<string, GameObject> GetObjects()
	{
		return objects;	
	}
}