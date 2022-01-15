using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoad : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.01f;

    private Vector3 pos = new Vector3();
    private RectTransform boadPosition;

    private void Awake()
    {
        boadPosition = this.GetComponent<RectTransform>();
        pos = boadPosition.transform.position;
    }

    private void Update()
    {
        if (Time.timeScale!=0)
        {
            pos.x -= speed;

            boadPosition.transform.position = pos;
        }
    }
}
