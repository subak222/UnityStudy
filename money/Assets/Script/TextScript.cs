using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Text text;
    Money money;
    // Start is called before the first frame update
    void Start()
    {
        money = GameObject.Find("Gold").GetComponent<Money>();
    }
    // Update is called once per frame
    void Update()
    {
        text.text = money.coin.ToString();
    }
}