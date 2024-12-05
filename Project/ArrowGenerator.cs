using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;                                  // 화살 설계도를 넣는 변수 선언
    float span = 1.0f;
    float delta = 0;
    
    void Update()
    {
       delta += Time.deltaTime;                                     // 화살을 1초마다 1개씩 생성
       if ( delta > span )
       {
        delta = 0;
        GameObject go = Instantiate(arrowPrefab);                   // as GameObject; 쓰나 안쓰나 똑같음
        int px = Random.Range(-6, 7);
        go.transform.position = new Vector3(px, 7, 0);
       } 
    }
}
