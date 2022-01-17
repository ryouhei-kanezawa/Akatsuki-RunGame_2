using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionIllust : MonoBehaviour
{
    [SerializeField]
    private distinction dis_Illust;

    private Vector3 pos = new Vector3();
    private RectTransform illustPosition;
    private FieldManager _field = new FieldManager();

    private void Start()
	{
        illustPosition = GetComponent<RectTransform>();
        pos = illustPosition.transform.position;
	}

	private void Update()
    {
		if (Time.timeScale!=0)
		{
            pos.x -= _field.Speed;
            illustPosition.transform.position = pos;
		}
    }

    public distinction SendEnum()
	{
        return dis_Illust;
	}
}
