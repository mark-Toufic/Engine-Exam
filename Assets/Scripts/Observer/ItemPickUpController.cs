using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemPickUpController : MonoBehaviour
{
    [SerializeField] List<ItemPickUps> item;

    int count = 0;



    void Health(ItemPickUps health)
    {
        count += 1;
        PlayerHealthManager.instance.health += 1;
        Debug.Log("Health Picked Up:" + count);
        Debug.Log("Current Health:" + PlayerHealthManager.instance.health);
    }

}