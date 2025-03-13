using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject rain;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeRain", 0f, 1f);  
        // 함수 반복 실행 함수 ("함수명", 몇 초 이후?, 얼마나 자주?)
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MakeRain() {
        Instantiate(rain);      // 생성
    }
}
