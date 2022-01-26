using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private Result over;
    [SerializeField]
    private ScoreManager _score;
    [SerializeField]
    private GameObject canvas;
    [SerializeField]
    private PlayBGM sound;

    private Result game = null;
    private Transform canvasTran;
    private HomeScore home = new HomeScore();

	public void Overset()
    {
		if (game == null)
        {
            sound.StopSound();

            game = Instantiate(over, canvasTran, false);
            game.transform.SetParent(canvas.transform, false);

            game.SetText(home.GetKyori, home.GetCoin, _score.Tmp);
            home.SetScore(_score.Tmp);
        }
    }
}
