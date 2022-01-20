using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBGM : MonoBehaviour
{
	[SerializeField]
	private AudioClip button;

	private AudioSource audio;

	private void Start()
	{
		audio = GetComponent<AudioSource>();
	}

	public void PlaySoundBGM()
	{
		audio.Play();
	}

	public void StopSound()
	{
		audio.Stop();
	}

	public void PoseSoundBGM(bool swich)
	{
		if (swich)
		{
			audio.Pause();
		}
		else
		{
			audio.UnPause();
		}
	}

	public void PlayButton()
	{
		audio.PlayOneShot(button);
	}
}
