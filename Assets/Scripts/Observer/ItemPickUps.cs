using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemPickUps : MonoBehaviour
{
    public event Action<ItemPickUps> OnItemPickUp;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Health();
        }
    }
    void Health()
    {
        AchievementManager.achievement.fruitCollected += 1;
        OnItemPickUp?.Invoke(this);
        Destroy(this.gameObject);
    }
}


