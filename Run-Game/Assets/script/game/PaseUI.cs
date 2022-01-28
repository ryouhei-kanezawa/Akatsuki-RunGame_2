using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaseUI : MonoBehaviour
{
    [SerializeField]
    private Button Pause;
    [SerializeField]
    private PlayBGM sound;

    private bool check;
    private GameUpdate swich = new GameUpdate();

    void Start()
    {
        Pause.onClick.AddListener(PauseSW);
        check = false;
    }

    void PauseSW()
    {
		if (!swich.GetBackSwich()||check)
		{
            if (swich.GetGameSwich())
            {
                sound.PlayButton();
                sound.PoseSoundBGM(swich.GetGameSwich());
                swich.SetGameSwich(false);
                swich.SetBackSwich(true);
                Time.timeScale = 0;
            }
            else
            {
                sound.PlayButton();
                sound.PoseSoundBGM(swich.GetGameSwich());
                swich.SetGameSwich(true);
                swich.SetBackSwich(false);
                Time.timeScale = 1;
            }
            check = true;
        }
    }
}
