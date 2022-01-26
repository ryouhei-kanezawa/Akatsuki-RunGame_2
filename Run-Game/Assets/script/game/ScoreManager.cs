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
    private int addscore = 10;
    [SerializeField]
    private int addCoin = 1000;

    private GameUpdate swich = new GameUpdate();
    private HomeScore score = new HomeScore();

	public int Tmp { get; private set; }

	void Start()
    {
        score.GetCoin = 0;
        score.GetKyori = 0;
        Tmp = 0;

        coin.text = score.GetCoin.ToString();
        kyori.text = score.GetCoin.ToString();
        plusCoin.text = "+" + addCoin;
        plusCoin.color = new Color(plusCoin.color.r, plusCoin.color.g, plusCoin.color.b,0f);
    }

	private void Update()
	{
        if (swich.GetGameSwich())
        {
            score.GetKyori += addscore;
            Tmp += addscore;
        }

        kyori.text = score.GetKyori.ToString();
    }

    public void CoinUpdate()
    {
        score.GetCoin++;

        coin.text = score.GetCoin.ToString();
        Tmp += addCoin;

        StartCoroutine(FadeText());
    }

    private IEnumerator FadeText()
	{
        plusCoin.gameObject.SetActive(true);
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
        plusCoin.gameObject.SetActive(false);
        yield break;
    }
}
