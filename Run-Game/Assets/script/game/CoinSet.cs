using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinSet : MonoBehaviour
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
    private int Maxcoin = 0;
    private int MaxScore = 0;

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
                MaxScore = kyoriScore;
			}
        }

        kyori.text = kyoriScore.ToString();
	}

    public void CoinUpdate()
	{
        coinScore++;
        Maxcoin = coinScore;

        coin.text = coinScore.ToString();
	}

    public void TextUpdate(TextMeshProUGUI coinT,TextMeshProUGUI scoreT)
	{
        coinT.text = "coin:" + Maxcoin;
        scoreT.text = "score:" + MaxScore;
	}

    public void StopSwich(bool set)
	{
        swich = set;
	}
}
