using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour                // 유니티 컴포넌트 사용 가능
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);              // 프레임마다 등속으로 낙하시킨다.

        if(transform.position.y < -5.0f)        // 화면 밖으로 나오면 오브젝트를 소멸시킨다.
        {
            Destroy(gameObject);
        }

        // 충돌 판정
        Vector2 p1 = transform.position;                           // 화살의 중심 좌표
        Vector2 p2 = player.transform.position;                 // 플레이어의 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;                                     // 화살의 반경
        float r1 = 0.5f;                                          // 플레이어의 반경
        float r2 = 1.0f;

        if ( d < r1 + r2 )
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHP();
            // 감독 스크립트에 플레이어와 화살이 충돌했다고 전달한다.

            Destroy(gameObject);                        // 충돌한 경우는 화살을 지운다.
        }
    }
}
