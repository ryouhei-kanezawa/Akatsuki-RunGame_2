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

    private bool check = true;
    private GameUpdate swich = new GameUpdate();

    void Awake()
    {
        Pause.onClick.AddListener(PauseSW);
    }

    void PauseSW()
    {
		if (!swich.GetBackSwich())
		{
            if (swich.GetGameSwich())
            {
                sound.PlayButton();
                sound.PoseSoundBGM(check);
                swich.SetGameSwich(false);
                swich.SetBackSwich(true);
                Time.timeScale = 0;

                check = false;
            }
            else
            {
                sound.PlayButton();
                sound.PoseSoundBGM(check);
                swich.SetGameSwich(true);
                swich.SetBackSwich(false);
                Time.timeScale = 1;

                check = true;
            }
        }
    }
}
