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

	private static int bestScore = 0;
	private int lastScore;
	private HomeScore score = new HomeScore();

	private void Start()
	{
		int scoreTemp = score.GetScore();

		if (scoreTemp>0)
		{
			if (scoreTemp > bestScore)
			{
				bestScore = scoreTemp;
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
			bestScoreText.text = "„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ";
			lastScoreText.text = lastScore.ToString();
		}
	}
}
