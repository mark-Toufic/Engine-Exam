using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPlacer : MonoBehaviour
{
    static List<Transform> items;
   
    public static void PlaceItem(Transform item)
	{
		Transform newItem = item;
		if(items == null)
		{
			items = new List<Transform>();
		}

		items.Add(newItem);
	}

	public static void RemoveItem(Vector3 position)
	{
		for(int i = 0; i < items.Count; i++)
		{
			if(items[i].position == position)
			{
				GameObject.Destroy(items[i].gameObject);
				Debug.Log("Removed");
				items.RemoveAt(i);
				break;
			}
		}
	}
}
