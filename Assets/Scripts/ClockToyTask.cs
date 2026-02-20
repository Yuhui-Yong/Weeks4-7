using UnityEngine;
using UnityEngine.UI;

public class ClockToyTask : MonoBehaviour
{
    public float timerValue = 1; // it can't be a zero because once it starts the time goes properly, but when you move the slider to be at the very left, which is zero, it will
    // not go since there is a zero value, which does nothing. So, want it to keep going forever without stopping or make player to not be able to stop because this is like
    // real time clock.

    public float timerMaxValue = 64800f; // This is the time when the sun sets at 6pm like in real time.

    public float speed = 1f; // This is for the slider that will adjust the speed of This code.

    public Slider timeVisuals;

    // Start is called once before the first execution of Update after the MonoBehaviour is created.
    void Start()
    {
        timeVisuals.maxValue = timerMaxValue;
    }

    // Update is called once per frame
    void Update()
    {
        timerValue += Time.deltaTime * speed; // It was originally "timerValue += Time.deltaTime" Then, I multiplied speed here to be modified the speed.

        if (timerValue > timerMaxValue)
        {
            timerValue = 0;
        }

        timeVisuals.value = timerValue;
    }

    public void SpeedForBackandClock(float Speed) // For the slider to be in the inspector.
    {
        speed = Speed;
    }
}
