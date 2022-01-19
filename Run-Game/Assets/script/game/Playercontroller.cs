using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    [SerializeField]
    private GameObject player_body;
    [SerializeField]
    private float junmp = 5.0f;
    [SerializeField]
    private ScoreManager _score;
    [SerializeField]
    private GameOver _orver;
    [SerializeField]
    private PlaySound sound;
    [SerializeField]
    private TimeStart Stop;

    private CollectionGallery _gallery = new CollectionGallery();
    private CollectionIllust _illust;
    private Rigidbody2D player_jump;
    private int jumpCount;

    void Start()
    {
        player_jump = player_body.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		if (Stop.StopMoment())
		{
			if (jumpCount>=2)
			{
                return;
			}

            if (Input.GetKeyDown("space"))
            {
                Jump_getkey();
                jumpCount++;
            }
        }
		
    }

    private void Jump_getkey()
	{
        player_jump.velocity = Vector2.up * junmp;
        sound.PlayJumpEffect();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.CompareTag("coin"))
        {
            _score.CoinUpdate();
            sound.PlayCoinEffect();
            Destroy(collision.gameObject);
        }

		if (collision.gameObject.GetComponent<CollectionIllust>())
		{
            _illust = collision.gameObject.GetComponent<CollectionIllust>();
            Debug.Log(_illust.SendEnum());
            _gallery.OpenIllust(_illust.SendEnum());
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
            sound.PlayHitEffect();
            _orver.Overset();
		}
    }
}
