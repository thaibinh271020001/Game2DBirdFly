using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBlink : MonoBehaviour
{
    public float minTime = 1f;
    public float maxTime = 1.2f;

    public float timer;
    private Text textFlicker;

    void Start()
    {
        textFlicker = GetComponent<Text>();
        timer += Random.Range(minTime, maxTime);
        Debug.Log(timer);
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            textFlicker.enabled = !textFlicker.enabled;
            timer = Random.Range(minTime, maxTime);
        }
        
    }
}
