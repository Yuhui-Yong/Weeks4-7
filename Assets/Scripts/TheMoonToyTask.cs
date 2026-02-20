using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class TheMoonToyTask : MonoBehaviour
{
    public GameObject Timer; // A varibale that can store the object in the inspector.
    private ClockToyTask clock;
    public Vector2 startPos = new Vector2(0.01f, 4.04f); // StartPos.
    public Vector2 endPos = new Vector2(3.22f, 4.04f); // EndPos.
    public float rotate = 360f; // Rotation.
    public float speed = 1f; // Speed.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clock = Timer.GetComponent<ClockToyTask>(); // To use timerValue for the future.
    }

    // Update is called once per frame
    void Update()
    {
        float currentTime = clock.timerValue; // The currentTime.
        float maxTime = clock.timerMaxValue; // The maxTime that the moon has to reach at the end.
        float t = (currentTime / maxTime) * speed; // This is like half of the distance like has to be 2.

        Vector2 pos2 = Vector2.Lerp(startPos, endPos, t);
        transform.position = new Vector3(pos2.x, pos2.y, transform.position.z);

        float angle = t * rotate;
        transform.rotation = Quaternion.Euler(0f, 0f, -angle);
    }

    public void SpeedForBackandClock(float Speed) // For the slider to be in the inspector.
    {
        speed = Speed;
    }

}
