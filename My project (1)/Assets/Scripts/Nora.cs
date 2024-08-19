using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Nora
{
    public int hp;  //ü��
    public int max_hp;  //�ִ� ü��
    public int mp;
    public int max_mp;
    public string name;
    public Sprite image;    //Sprite�� ����Ƽ���� 2D �̹��� ���Ͽ� ���� ����

    public void Attack()
    {
        if (mp >= max_mp)
        {
            Debug.Log("������ �̹� ���� ���ֽ��ϴ�");
            return;
        }
        mp += 10;
        Debug.Log($"������ 10 ȸ���մϴ�! ���縶�� {mp} / {max_mp}");
    }

    public void Heal()
    {
        if (hp >= max_hp)
        {
            Debug.Log("ü���� �̹� ���� ���ֽ��ϴ�");
            return;
        }
        hp += 10;
        Debug.Log($"ü���� 10 ȸ���մϴ�! ����ü�� {hp} / {max_hp}");
    }
}
