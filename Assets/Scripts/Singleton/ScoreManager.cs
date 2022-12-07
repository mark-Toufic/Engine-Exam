using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	public static ScoreManager instance;

	public int score;
	private void Awake()
	{
		if(!instance)
		{
			instance = this;
		}
	}

	public void ChangeScore(int coinValue)
	{
		score += coinValue;
		Debug.Log(score);
	}
}
