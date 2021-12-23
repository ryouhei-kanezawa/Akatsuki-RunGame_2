using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject over;            //Instantiate‚·‚éobject
    [SerializeField]
    private ScoreManager _score;
    [SerializeField]
    private GameObject canvas;          //Instantiate‚·‚éCanvas

    private TextMeshProUGUI score;
    private TextMeshProUGUI coin;
    private Transform canvasTran;

    public void Overset()
	{
        _score.StopSwich(false);
        GameObject game = Instantiate(over, canvasTran, false);
        game.transform.SetParent(canvas.transform, false);

        coin = over.transform.Find("coinText").GetComponent<TextMeshProUGUI>();
        score=over.transform.Find("scoreText").GetComponent<TextMeshProUGUI>();

        _score.TextUpdate(coin, score);

        Time.timeScale = 0;
    }
}
