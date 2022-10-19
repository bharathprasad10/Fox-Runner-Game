using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBG : MonoBehaviour
{

    public Transform startPoint;
    public Transform endPoint;

    public float speed;
    private float Xlimit;
    float reEntryPos;
    

    private void Start()
    {
        Xlimit = Camera.main.orthographicSize * Camera.main.aspect;
        
        //Debug.Log(Xlimit);
        reEntryPos = Xlimit + Mathf.Abs((startPoint.position.x - endPoint.position.x) / 2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if(endPoint.position.x <= -Xlimit)
        {
            Vector2 pos = new Vector2(reEntryPos, transform.position.y);
            transform.position = pos;
        }
    }
}
