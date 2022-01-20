using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStart : MonoBehaviour
{
    [SerializeField]
    private PlayBGM sound;

    private bool active = true;

	private void Start()
	{
        Time.timeScale = 1;
	}

	public bool StopMoment()
	{
        return active;
	}

    public void StopLine()
    {
        if (active)
        {
            active = false;
        }
        else
        {
            active = true;
            sound.PlaySoundBGM();
        }
    }
}
