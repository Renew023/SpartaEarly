using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rtan : MonoBehaviour
{
    float direction = 0.05f;

    SpriteRenderer renderers;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        Debug.Log("¾È³ç");
        direction = 0.05f;

        renderers = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            direction *= -1;
            renderers.flipX = !renderers.flipX;
        }


        if(transform.position.x > 2.6f)
        {
            renderers.flipX = true;
            direction = -0.05f;
        }
        if(transform.position.x < -2.6f)
        {
            renderers.flipX = false;
            direction = 0.05f;
        }
        transform.position += Vector3.right* direction;
    }
}
