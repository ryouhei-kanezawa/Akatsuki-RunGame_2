using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStart : MonoBehaviour
{
    [SerializeField]
    private PlayBGM sound;

    private GameUpdate swich = new GameUpdate();

	private void Start()
	{
        swich.SetGameSwich(false);
        swich.SetBackSwich(false);
	}

    public void StopLine()
    {
        if(!swich.GetGameSwich())
        {
            swich.SetGameSwich(true);
            sound.PlaySoundBGM();
        }
    }
}
