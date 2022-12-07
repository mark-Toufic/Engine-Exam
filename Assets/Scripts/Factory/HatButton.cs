using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HatButton : MonoBehaviour
{
    private HatFactory factory;

    TextMeshProUGUI btnText;

    Transform head;
    // Start is called before the first frame update
    void Start()
    {
        head = GameObject.Find("HeadTarget").transform;

        factory = GameObject.Find("GameManager").GetComponent<HatFactory>();

        btnText = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void OnClickSpawn()
	{
        switch (btnText.text)
		{
            case "Green Hat":
                factory.GetHat("Green Hat").Create(factory.prefab1, head);
                break;
            case "Pink Hat":
                factory.GetHat("Pink Hat").Create(factory.prefab2, head);
                break; 
            case "Blue Hat":
                factory.GetHat("Blue Hat").Create(factory.prefab3, head);
                break;
            default:
                break;
		}
	}
}
