using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) //왼쪽 화살표가 눌렸을 때
        {
            transform.Translate(-1.5f, 0, 0); //왼쪽으로 3 움직인다.
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) //오른쪽 화살표가 눌렸을 때
        {
            transform.Translate(1.5f, 0, 0); //오른쪽으로 3 움직인다.
        }
    }
}
