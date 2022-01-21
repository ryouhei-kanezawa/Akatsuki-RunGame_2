using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStart : MonoBehaviour
{
    [SerializeField]
    private PlayBGM sound;

    private bool active;

	private void Start()
	{
        active = false;
        Time.timeScale = 1;
	}

	public bool StopMoment()
	{
        return active;
	}

    public void StopLine()
    {
        if(!active)
        {
            active = true;
            sound.PlaySoundBGM();
        }
    }
}
