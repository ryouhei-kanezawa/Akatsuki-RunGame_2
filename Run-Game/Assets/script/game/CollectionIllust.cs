using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionIllust : MonoBehaviour
{
    [SerializeField]
    private distinction dis_Illust;
    [SerializeField]
    private float speed = 0.1f;
    [SerializeField]
    private GameObject boadbody;

    private Vector3 pos = new Vector3();

	private void Start()
	{
        pos = boadbody.transform.position;
	}

	private void FixedUpdate()
    {
        pos.x -= speed;
        boadbody.transform.position = pos;
    }

    public distinction SendEnum()
	{
        return dis_Illust;
	}
}
