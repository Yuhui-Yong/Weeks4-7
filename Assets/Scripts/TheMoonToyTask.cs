using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class TheMoonToyTask : MonoBehaviour
{
    public GameObject Timer; // A varibale that can store the object in the inspector.
    private ClockToyTask clock;
    public Vector2 startPos = new Vector2(0.01f, 2.91f); // StartPos.
    public Vector2 endPos = new Vector2(3.22f, 2.91f); // EndPos.
    public float rotate = 360f; // Rotation.
    public float speed = 1f; // Speed.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clock = Timer.GetComponent<ClockToyTask>(); // To use timerValues for the future like the current and the max.
    }

    // Update is called once per frame
    void Update()
    {
        float currentTime = clock.timerValue; // Call the current time within the ClockToyTask, which I set the value and store it, which is clock script.
        float maxTime = clock.timerMaxValue; // This line gets the "maximum time" of the clock (again, clock is the variable I made ClockToyTask to be stored in it,
                                            // which I set it to 64800. That is, a standard, like one full rotation per day, meaning The standard value
                                           // for a clock to complete one full rotation.

        float t = (currentTime / maxTime) * speed; // This is like really important within this code I personally think,
        // This calculate what percentage of the total has been completed, which has to be like a half like I mean 2.
        // For example,
        // If currentTime is 0, then 0 / 64800 = 0.
        // If currentTime is 32400, then 32400 / 64800 = 0.5.
        // If currentTime is 64800, then 1.
        // So, like you know what I mean. life literally the half of it. Like, the ratio is between 0 and 1.
        // Furthermore, plus * speed, meaning
        // If speed is 2, then t grows twice as fast.
        // If speed is 0.5, then t grows half as fast.
        // I mean the reason why I added the speed of it because I want the speed of it to be modified by slider as well as the others, which is the background and the clock, so that
        // everything can be modified evenly and the same.


        Vector2 pos = Vector2.Lerp(startPos, endPos, t); // Now, I assigned the values here as Lerp.
        transform.position = new Vector3(pos.x, pos.y, transform.position.z); // Now, I assigned the values that I have assigned here, but leave the z value as it is.

        float angle = t * rotate; // This calculates the rotation angle.
        // For example,
        // If rotate is 360, then:
        // When t is 0.5, the angle is 180 degrees.
        // When t is 1, the angle is 360 degrees.
        // In other words, the rotation is equal to the time progression.

        transform.rotation = Quaternion.Euler(0f, 0f, -angle);
        // This rotates the object by angle around the z-axis.
        // A negative angle reverses the rotation direction.
        // A positive angle reverses the rotation direction.
        // because it uses 3D mathematical coordinate system like if you think about it in math in the coordinate plane, it works like that.
    }

    public void SpeedForBackandClock(float Speed) // For the slider to be in the inspector. Basically, from here to the end is just for the slider to have it in the inspector.
    {
        speed = Speed;
    }

}
