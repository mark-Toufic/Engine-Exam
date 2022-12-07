using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementManager : MonoBehaviour
{
	public static AchievementManager achievement;



	//Enemy Achievement
	public int enemiesKilled;
	[SerializeField] private bool enemyAchievement;



	private void Awake()
	{
		if (!achievement)
		{
			achievement = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}
	// Update is called once per frame
	void Update()
	{

		if (enemiesKilled >= 1)
		{
			enemyAchievement = true;
		}
	}
}
