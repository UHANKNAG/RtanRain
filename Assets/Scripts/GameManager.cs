using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // 싱글톤이란? 어디서도 부를 수 있는 '하나'로 만들어주는 것!
    public static GameManager Instance;
    public GameObject rain;
    
    public Text totalScoreTxt;
    public Text timeTxt;

    int totalScore;
    float totalTime = 30.0f;

    private void Awake() {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeRain", 0f, 1f);  
        // 함수 반복 실행 함수 ("함수명", 몇 초 이후?, 얼마나 자주?)
    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        timeTxt.text = totalTime.ToString("N2");
        // N2 소숫점 둘째 자리까지만 보여 달라
    }

    void MakeRain() {
        Instantiate(rain);      // 생성
    }

    // public 외부 스크립트에서 접근할 수 있도록록
    public void AddScore(int score) {
        totalScore += score;
        totalScoreTxt.text = totalScore.ToString();
    }
}
