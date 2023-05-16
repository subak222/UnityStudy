using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public int coin = 0;
    public int time = 0;

    void Start()
    {
        StartCoroutine(Mo());
    }

    IEnumerator Mo()
    {
        while(true) {
            int ran = Random.Range(11,16);
            yield return new WaitForSeconds(1);
            coin += 10*ran;
            Debug.Log("10원 "+ran+"개 "+coin+"원");
            ++time;
            if(time%60 == 0) {
                coin += 500;
                Debug.Log("500원 1개 "+coin+"원");
            }
        }
    }
}