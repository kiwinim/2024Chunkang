using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BossMove : PoolAble
{
    float yScreenHalfSize;
    float xScreenHalfSize;          // 화면의 가로 반 사이즈

    public float Speed = 50f;
    public bool Startmove = true;
    public bool pattern1 = false;
    public int num;
    public int h = 1;
    void Start()
    {
        yScreenHalfSize = Camera.main.orthographicSize;
        xScreenHalfSize = yScreenHalfSize * Camera.main.aspect;
    }

    void Update()
    {
        if(Startmove == true)
        {
            StartMove();
        }
        if(pattern1 == true)
        {
            Pattern1();
        }

        if (this.gameObject == null)
        {
            // 오브젝트 풀에 반환
            ReleaseObject();
        }
    }
    void StartMove()
    {
        var dir = new Vector3(0, -1, 0);
        Vector2 Screenposition= new Vector2 (0f, yScreenHalfSize);
        if(this.transform.position.y > Screenposition.y * 0.8f)
        {
            this.transform.Translate(-dir * this.Speed * Time.deltaTime);
        }
        else if(this.transform.position.y >= Screenposition.y*0.6f)
        {
            this.transform.Translate(-dir * this.Speed * 0.2f * Time.deltaTime);
        }
        else
        {
            Startmove = false;
            pattern1 = true;        
        }
    }
    void Pattern1()
    {
        var dir = new Vector3(1, 0, 0);
        Vector2 Screenposition= new Vector2 (xScreenHalfSize - 0.6f, this.gameObject.transform.position.y);
        if(this.transform.position.x <= Screenposition.x && this.transform.position.x >= -Screenposition.x)
        {
            
        }
        switch(num)
        {
            case 0:
                h = h* -1;
                break;
            default:
                return;
        }
    }
    IEnumerator turnCool()
    {
        num = Random.Range(0,3);
        yield return new WaitForSeconds(2f);
    }

}
