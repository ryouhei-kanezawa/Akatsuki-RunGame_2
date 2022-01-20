using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaseUI : MonoBehaviour
{
    [SerializeField]
    private Button Pause;               //ポーズ画面を呼び出すボタン
    [SerializeField]
    private ScoreManager _score;
    [SerializeField]
    private PlayBGM sound;

    private bool check = true;

    void Awake()
    {
        Pause.onClick.AddListener(PauseSW);
    }

    void PauseSW()
    {
            if (check)
            {
                sound.PlayButton();
                sound.PoseSoundBGM(check);
                Time.timeScale = 0;
                check = false;
                _score.StopSwich(false);
            }
            else
            {
                sound.PlayButton();
                sound.PoseSoundBGM(check);

                Time.timeScale = 1.0f;
                check = true;
                _score.StopSwich(true);
            }
    }
}
