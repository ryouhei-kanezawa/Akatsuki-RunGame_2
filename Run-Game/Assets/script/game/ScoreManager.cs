using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Murosta.Utility;
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

    private GameUpdate swich = new GameUpdate();

	public int CoinScore { get; private set; }

	public int KyoriScore { get; private set; }

	void Start()
    {
        CoinScore = 0;
        KyoriScore = 0;

        coin.text = CoinScore.ToString();
        kyori.text = KyoriScore.ToString();
        plusCoin.text = "+" + addCoin;
        plusCoin.color = new Color(plusCoin.color.r, plusCoin.color.g, plusCoin.color.b,0f);
    }

	private void Update()
	{
        if (swich.GetGameSwich())
        {
            KyoriScore += score;
        }

        kyori.text = KyoriScore.ToString();
    }

    public void CoinUpdate()
    {
        CoinScore++;

        coin.text = CoinScore.ToString();
        KyoriScore += addCoin;
        StartCoroutine(FadeText());
    }

    private IEnumerator FadeText()
	{
        CanvasGrouopExtensions.FadeIn(plusCoin, 1.0f);

        var i = 0;
        while (i < 60)
        {
            i++;
            yield return null;
        }

        CanvasGrouopExtensions.FadeOut(plusCoin, 1.0f);
        i = 0;
        while (i < 60)
        {
            i++;
            yield return null;
        }
        yield break;
    }
}
