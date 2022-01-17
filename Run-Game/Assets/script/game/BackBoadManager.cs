using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBoadManager : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;

    private int maxPosition = -18;
    private Vector3 posGround = new Vector3();
    private RectTransform rectGround;

	private void Start()
	{
        rectGround = this.gameObject.GetComponent<RectTransform>();
        posGround = rectGround.transform.position;
	}

	void Update()
    {
		if (Time.timeScale==0)
		{
            posGround.x -= 0;
            rectGround.transform.position = posGround;
        }
		else
		{
            posGround.x -= speed;
            rectGround.transform.position = posGround;
		}

		if (rectGround.position.x<=maxPosition)
		{
            posGround.x = 18;
            rectGround.transform.position = posGround;
        }
    }
}
