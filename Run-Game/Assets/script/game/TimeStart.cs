using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using DG.Tweening;

public class TimeStart : MonoBehaviour
{
    [SerializeField]
    private PlayBGM sound;
    [SerializeField]
    private PlayableDirector line;
    [SerializeField]
    private Image spaceKey;

    private GameUpdate swich = new GameUpdate();

	private void Start()
	{
        line.Stop();
        swich.SetGameSwich(false);
        swich.SetBackSwich(true);
        FaidSpaceKey();
	}

	private void Update()
	{
		if (swich.GetBackSwich())
		{
            if (Input.GetKeyDown("space"))
            {
                spaceKey.gameObject.SetActive(false);
                swich.SetBackSwich(false);
                line.Play();
            }
        }
    }

    public void FaidSpaceKey()
    {
        spaceKey.gameObject.SetActive(true);

        spaceKey.DOFade(0.0f, 1f).SetLoops(-1, LoopType.Yoyo);
    }

    public void StopLine()
    {
        if (!swich.GetGameSwich())
        {
            swich.SetGameSwich(true);
            sound.PlaySoundBGM();
        }
    }
}
