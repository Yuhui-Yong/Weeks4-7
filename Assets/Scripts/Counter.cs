using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Counter : MonoBehaviour
{
    public ClockToyTask HowMuchTime;
    public TextMeshProUGUI counter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = HowMuchTime.timerValue.ToString();
    }
}
