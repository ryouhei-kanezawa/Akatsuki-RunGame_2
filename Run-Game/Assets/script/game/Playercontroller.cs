using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Playercontroller : MonoBehaviour
{
    [SerializeField]
    private GameObject player_body;
    [SerializeField]
    private GameObject effect1;
    [SerializeField]
    private GameObject coinEffect1;
    [SerializeField]
    private float junmp = 5.0f;
    [SerializeField]
    private ScoreManager _score;
    [SerializeField]
    private GameOver _orver;
    [SerializeField]
    private PlaySound sound;

    private GameUpdate swich = new GameUpdate();
    private CollectionGallery _gallery = new CollectionGallery();
    private CollectionIllust _illust;
    private RectTransform playerTransform;
    private Rigidbody2D player_jump;
    private int jumpCount;

    void Start()
    {
        player_jump = player_body.GetComponent<Rigidbody2D>();
        playerTransform = player_body.GetComponent<RectTransform>();
    }

    void Update()
    {
        if (swich.GetGameSwich())
		{
			if (jumpCount>=2)
			{
                return;
			}

            if (Input.GetKeyDown("space"))
            {
                Getkey();
            }
		}
    }

    private void Getkey()
	{
        player_jump.velocity = Vector2.up * junmp;
        var effectTransform = new Vector3(playerTransform.transform.position.x
            , playerTransform.transform.position.y - playerTransform.sizeDelta.y / 2
            , playerTransform.transform.position.z);
        StartCoroutine(PlayEffect(effect1, effectTransform));
        sound.PlayJumpEffect();
        jumpCount++;
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.CompareTag("coin"))
        {
            _score.CoinUpdate();

            var effectTransform = collision.gameObject.transform;
            StartCoroutine(PlayEffect(coinEffect1, effectTransform.localPosition));

            sound.PlayCoinEffect();
            Destroy(collision.gameObject);
        }

		if (collision.gameObject.GetComponent<CollectionIllust>())
		{
            _illust = collision.gameObject.GetComponent<CollectionIllust>();
            _gallery.OpenIllust(_illust.SendEnum());

            sound.PlayVoiceEffect();
            Destroy(collision.gameObject);
        }
	}

	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "field")
        {
            jumpCount = 0;
        }

		if (collision.gameObject.CompareTag("gameorver"))
        {
			if (swich.GetGameSwich())
            {
                sound.PlayHitEffect();
                playerTransform.transform.DORotate(new Vector3(0, 0, 90), 1f);
                swich.SetGameSwich(false);
                swich.SetBackSwich(true);

                _orver.Overset();
            }
        }
    }

    private IEnumerator PlayEffect( GameObject effect,Vector3 position)
    {
        Quaternion q = effect.transform.rotation;
        var tmp = Instantiate(effect, position, q);

        var i = 0;
        while (i < 60)
        {
            i++;
            yield return null;
        }

        Destroy(tmp);
    }
}
