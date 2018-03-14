using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {
    public int count = 10;

    Text counter;
    Image health;

    public RectTransform healthBarLeft;
    public RectTransform healthBarRight;

    //public float maxHealth = -0.1737253f;

    void Start () {
        counter = GetComponent<Text>();
        health = GetComponent<Image>();
        StartCoroutine(StartCounter());
	}

    private IEnumerator StartCounter()
    {
        while(count >= 0)
        {
            counter.text = count.ToString();
            count--;

            healthBarLeft.localScale += new Vector3(-0.1f, 0, 0);
            healthBarRight.localScale += new Vector3(-0.1f, 0, 0);

            if (count == 0)
            {
                healthBarLeft.localScale = new Vector3(0, 0, 0);
                healthBarRight.localScale = new Vector3(0, 0, 0);
            }

            //maxHealth -= 10;            
            //healthBar.sizeDelta = new Vector2(maxHealth, healthBar.sizeDelta.y);

            yield return new WaitForSeconds(1f);
        }
    }

   
}
