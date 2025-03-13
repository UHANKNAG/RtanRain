using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rtan : MonoBehaviour
{
    // 한 Script 안에 여러 개의 Class가 존재할 수 있지만,
    // 현재 진행하는 수업에서는 한 Script 안에 한 개의 Class만 존재하도록 할 것

    // 변수
    float direction = 0.05f;

    SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        renderer = GetComponent<SpriteRendere>();
        Debug.Log("안녕");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 2.6f)
        {
            renderer.flipX = true;
            direction = -0.05f;
        }

        if(transform.position.x < -2.6f)
        {
            renderer.flipX = false;
            direction = 0.05f;
        }

        transform.position += Vector3.right * direction;
                            // == new Vector3(1f, 0, 0);

    }
}
