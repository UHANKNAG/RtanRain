using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnCollisionEnter2D
    // On 어떤 현상이 일어났을 때, OnCollision 충돌 현상이 일어났을 때
    // Enter 충돌이 딱 시작되는 그 순간, 2D 환경경에서
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌하게 되면 충돌한 gameObject의 정보가 collision 안에 들어가게 됨
        if(collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
