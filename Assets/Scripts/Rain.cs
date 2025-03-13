using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    float size = 1.0f;
    int score = 1;

    SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();

        float x = Random.Range(-2.4f, 2.4f);
        float y = Random.Range(3.0f, 5.0f);

        transform.position = new Vector3(x, y, 0);

        int type = Random.Range(1, 4); // 뒷 자리는 최대값이라 +1 해서 적을 것

        if (type == 1) {
            size = 0.8f;
            score = 1;
            renderer.color = new Color(100 / 255f, 100 / 255f, 1f, 1f);
        }
        else if (type == 2) {
            size = 1.0f;
            score = 2;
            renderer.color = new Color(130 / 255f, 130 / 255f, 1f, 1f);
        }
        else if (type == 3) {
            size = 1.2f;
            score = 3;
            renderer.color = new Color(150 / 255f, 150 / 255f, 1f, 1f);
        }

        transform.localScale = new Vector3(size, size, 0);
        // type에 따라 나눈 대로 사이즈 설정
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnCollisionEnter2D
    // On 어떤 현상이 일어났을 때, OnCollision 충돌 현상이 일어났을 때
    // Enter 충돌이 딱 시작되는 그 순간, 2D 환경에서
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌하게 되면 충돌한 gameObject의 정보가 collision 안에 들어가게 됨
        if(collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
