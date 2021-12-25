using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI coin;
    [SerializeField]
    private TextMeshProUGUI kyori;
    [SerializeField]
    private int score = 10;
    [SerializeField]
    private TimeStart Stop;

    private bool swich = true;
    private int coinScore;
    private int kyoriScore;

    public int CoinScore
	{
		get
		{
            return coinScore;
		}
	}

    public int KyoriScore
	{
		get
		{
            return kyoriScore;
		}
	}

    void Start()
    {
        coinScore = 0;
        kyoriScore = 0;

        coin.text = coinScore.ToString();
        kyori.text = kyoriScore.ToString();
    }

	private void Update()
	{
        if (Stop.StopMoment())
        {
			if (swich)
			{
                kyoriScore += score;
			}
        }

        kyori.text = kyoriScore.ToString();
	}

    public void CoinUpdate()
	{
        coinScore++;

        coin.text = coinScore.ToString();
	}

    public void StopSwich(bool set)
	{
        swich = set;
	}
}
