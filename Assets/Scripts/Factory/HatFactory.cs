using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Reflection;
using System;
using TMPro;

public class HatFactory : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;

    public GameObject buttonPanel;
    public GameObject buttonPrefab;

    List<Hat> hats;

    // Start is called before the first frame update
    void Start()
    {
        var hatTypes = Assembly.GetAssembly(typeof(Hat)).GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Hat)));

        hats = new List<Hat>();

        foreach(var type in hatTypes)
		{
            var tempType = Activator.CreateInstance(type) as Hat;
            hats.Add(tempType);
		}

        ButtonPanel();
    }

    public Hat GetHat(string hatType)
	{
        foreach(Hat hat in hats)
		{
            if(hat.Name == hatType)
			{
                Debug.Log("Hat Found");
                var target = Activator.CreateInstance(hat.GetType()) as Hat;

                return target;
			}
		}
        return null;
	}

    void ButtonPanel()
	{
        foreach(Hat hat in hats)
		{
            var button = Instantiate(buttonPrefab);
            button.transform.SetParent(buttonPanel.transform);
            button.gameObject.name = hat.Name + " Button";
            button.GetComponentInChildren<TextMeshProUGUI>().text = hat.Name;
		}
	}

    public void RemoveHat()
	{
        Destroy(GameObject.FindGameObjectWithTag("Hat"));
    }
}
