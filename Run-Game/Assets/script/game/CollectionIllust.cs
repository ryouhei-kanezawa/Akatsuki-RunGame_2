using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionIllust : MonoBehaviour
{
    [SerializeField]
    private distinction dis_Illust;
    [SerializeField]
    private float speed = 0.05f;

    private Vector3 pos = new Vector3();
    private RectTransform illustPosition;

    private void Start()
	{
        illustPosition = this.GetComponent<RectTransform>();
        pos = illustPosition.transform.position;
	}

	private void Update()
    {
		if (Time.timeScale!=0)
		{
            pos.x -= speed;
            illustPosition.transform.position = pos;
		}
    }

    public distinction SendEnum()
	{
        return dis_Illust;
	}
}
