using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class second : MonoBehaviour
{
    public Text id_text;
    public Text level_text;
    public Text exp_text;

    public string ID;
    [Range(1,99)] public int level;
    //유니티 인스펙터에서 1에서 99 사이의 범위를 선택할 수 있습니다 (휠 바)

    [Range(0.0f, 100.0f)] public float exp;

    private void Start()
    {
        id_text.text = ID;
        level_text.text = level.ToString();
        exp_text.text = exp.ToString();

    }

}