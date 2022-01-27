using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScore : MonoBehaviour
{
	[SerializeField]
	private Text bestScoreText;
	[SerializeField]
	private Text lastScoreText;

	private static int bestScore;
	private int lastScore;
	private HomeScore score = new HomeScore();

	private void Start()
	{
		int scoreTemp = score.GetScore();
		int maxScore = score.GetMaxScore();

		if (scoreTemp>0)
		{
			if (maxScore > bestScore)
			{
				bestScore = maxScore;
				bestScoreText.text = bestScore.ToString();
			}
			else
			{
				bestScoreText.text = bestScore.ToString();
			}

			lastScore = scoreTemp;
			lastScoreText.text = lastScore.ToString();
		}
		else
		{
			lastScore = 0;
			bestScore = 0;
			bestScoreText.text = bestScore.ToString();
			lastScoreText.text = lastScore.ToString();
		}
	}
}
