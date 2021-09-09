using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
   public Transform transform;

    private void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = pos;
        Vector3 vector = new Vector3(pos.x, pos.y, pos.z * -1 * Time.deltaTime);
        transform.position = vector;
        
    }

    private void OnEnable()
    {
        Cursor.visible = false;
    }
}
