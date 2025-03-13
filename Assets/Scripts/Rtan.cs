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
        renderer = GetComponent<SpriteRenderer>();
        // GetComponent는 해당 스크립트가 있는 Inspector에 있는 것이어야만 불러올 수 있음
        Debug.Log("안녕");
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스를 클릭하면, 이동 방향을 바꾸고, 르탄이 이미지도 반전
        if (Input.GetMouseButtonDown(0))
        {
            direction *= -1;
            renderer.flipX = !renderer.flipX;
        }
    
        // 화면 밖으로 넘어가지 않도록 구역 설정정
        if(transform.position.x > 2.6f)
        {
            renderer.flipX = true;  // 르탄이 이미지의 방향 설정정
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
