using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Nora
{
    public int hp;  //체력
    public int max_hp;  //최대 체력
    public int mp;
    public int max_mp;
    public string name;
    public Sprite image;    //Sprite는 유니티에서 2D 이미지 파일에 대한 도구

    public void Attack()
    {
        if (mp >= max_mp)
        {
            Debug.Log("마나가 이미 가득 차있습니다");
            return;
        }
        mp += 10;
        Debug.Log($"마나를 10 회복합니다! 현재마나 {mp} / {max_mp}");
    }

    public void Heal()
    {
        if (hp >= max_hp)
        {
            Debug.Log("체력이 이미 가득 차있습니다");
            return;
        }
        hp += 10;
        Debug.Log($"체력을 10 회복합니다! 현재체력 {hp} / {max_hp}");
    }
}
