using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI coin;
    [SerializeField]
    private TextMeshProUGUI kyori;
    [SerializeField]
    private Text plusCoin;
    [SerializeField]
    private int score = 10;
    [SerializeField]
    private int addCoin = 1000;
    [SerializeField]
    private TimeStart Stop;

    private bool swich = true;

	public int CoinScore { get; private set; }

	public int KyoriScore { get; private set; }

	void Start()
    {
        CoinScore = 0;
        KyoriScore = 0;

        coin.text = CoinScore.ToString();
        kyori.text = KyoriScore.ToString();
        plusCoin.text = "+" + addCoin;
    }

	private void Update()
	{
        if (Stop.StopMoment())
        {
			if (swich)
			{
                KyoriScore += score;
			}
        }

        kyori.text = KyoriScore.ToString();
	}

    public void CoinUpdate()
	{
        CoinScore++;

        coin.text = CoinScore.ToString();
        KyoriScore += addCoin;
    }

    public void StopSwich(bool set)
	{
        swich = set;
	}
}
