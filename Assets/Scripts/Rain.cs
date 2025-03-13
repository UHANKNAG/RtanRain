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
        Debug.Log("충돌");
    }
}
