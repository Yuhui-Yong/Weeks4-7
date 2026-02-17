using UnityEngine;
using UnityEngine.UI;

public class ClockToyTask : MonoBehaviour
{
    public float timerValue = 0;
    public float timerMaxValue = 64.800f;

    public Slider timeVisuals;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeVisuals.maxValue = timerMaxValue;
    }

    // Update is called once per frame
    void Update()
    {
        timerValue += Time.deltaTime;

        if (timerValue > timerMaxValue)
        {
            timerValue = 0;
        }

        timeVisuals.value = timerValue;
    }
}
