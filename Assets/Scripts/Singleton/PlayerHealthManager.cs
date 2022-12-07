using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public static PlayerHealthManager instance;
    public int health = 3;
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    private void Update()
    {
        if (health <= 0)
        {
            Destroy(PlayerController.instance.gameObject);
        }
    }
}