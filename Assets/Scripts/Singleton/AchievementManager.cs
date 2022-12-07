using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementManager : MonoBehaviour
{
	public static AchievementManager achievement;

	//Fruit Achievement
	public int fruitCollected;
	[SerializeField] private bool fruitAchievement;
	public Text fruitPrompt;

	//Enemy Achievement
	public int enemiesKilled;
	[SerializeField] private bool enemyAchievement;
	public Text enemyPrompt;

	//Jump Achievement
	public int jumpTimes;
	[SerializeField] private bool jumpAchievement;
	public Text jumpPrompt;

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
		fruitPrompt.text = "Collect 5 Fruit (" + fruitCollected + "/5)";
		if (fruitCollected >= 5)
		{
			fruitAchievement = true;
			fruitPrompt.enabled = false;
		}

		enemyPrompt.text = "Kill an Enemy (" + enemiesKilled + "/1)";
		if (enemiesKilled >= 1)
		{
			enemyAchievement = true;
			enemyPrompt.enabled = false;
		}

		jumpPrompt.text = "Jump 10 Times (" + jumpTimes + "/10)";
		if (jumpTimes >= 10)
		{
			jumpAchievement = true;
			jumpPrompt.enabled = false;
		}
	}
}
