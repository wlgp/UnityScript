using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NoraUI : MonoBehaviour
{
    public Nora nora;
    
    public Text nora_name;
    public Image nora_Image;
    public Slider HP_BAR;
    public Slider MP_BAR;

    public GameObject nora_UI;
    // Start is called before the first frame update
    void Start()
    {
        nora_Image.sprite = nora.image;
        nora_name.text = nora.name;
        HP_BAR.maxValue = nora.max_hp;
        HP_BAR.value = nora.hp;
        MP_BAR.maxValue = nora.max_mp;
        MP_BAR.value = nora.mp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Action01()
    {
        nora.Attack();
        setMPValue();
    }
    public void Action02()
    {
        nora.Heal();
        setHPValue();
    }
    public void setMPValue()
    {
        MP_BAR.value = nora.mp;
    }
    public void setHPValue()
    {
        HP_BAR.value = nora.hp;
    }
}
