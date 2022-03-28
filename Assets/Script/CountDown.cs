using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDown : MonoBehaviour
{
    float timer = 10.0f;
    int timerInt;
    private TextMeshProUGUI textTime;
    // Start is called before the first frame update
    void Start()
    {
        textTime = gameObject.GetComponent<TextMeshProUGUI>();
    }

    

    void Update()
    {

        if (timer > 0)
        {
            timer -= Time.deltaTime;
            
            timerInt = Mathf.RoundToInt(timer);
            
            textTime.text = timerInt.ToString();

            if (timer <= 0)
            {
                timer = 0f;
            }
        }
    }

}
