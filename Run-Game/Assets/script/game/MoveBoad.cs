using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoad : MonoBehaviour
{
    [SerializeField]
    private bool moveBoad = true;
    [SerializeField]
    private float speed = 0.1f;
    [SerializeField]
    private GameObject boadbody;

    private Vector3 pos = new Vector3();
    private RectTransform boadPosition;

    private void Awake()
    {
        boadPosition = boadbody.GetComponent<RectTransform>();
        pos = boadPosition.transform.position;
    }

    private void FixedUpdate()
    {
        if (moveBoad)
        {
            pos.x -= speed;

            boadPosition.transform.position = pos;
        }
    }

    private void stopBoad()
    {
        moveBoad = false;
    }
}
