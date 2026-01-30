using UnityEngine;

public class Flipper : MonoBehaviour
{
    public float speed;
    public float direction = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * transform.right * speed * Time.deltaTime; 
    }

    public void Right()
    {
        speed += 1f;
    }

    public void Left()
    {
        speed += -1f;
    }

    public void Stop()
    {
        speed = 0f;
    }
}
