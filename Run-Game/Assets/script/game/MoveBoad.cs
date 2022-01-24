using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoad : MonoBehaviour
{
    private Vector3 pos = new Vector3();
    private GameUpdate swich = new GameUpdate();
    private RectTransform boadPosition;
    private FieldManager field;

    private void Awake()
    {
        field = GameObject.Find("break_area").GetComponent<FieldManager>();
        boadPosition = GetComponent<RectTransform>();
        pos = boadPosition.transform.position;
    }

    private void Update()
    {
        if (!swich.GetBackSwich())
        {
            pos.x -= field.Speed * Time.deltaTime;

            boadPosition.transform.position = pos;
        }
    }
}
