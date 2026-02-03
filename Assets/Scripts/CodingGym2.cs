using UnityEngine;

public class CodingGym2 : MonoBehaviour
{

    public float rotationSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z += rotationSpeed * Time.deltaTime;

        transform.eulerAngles = currentRotation;
    }


    public void Click()
    {
        rotationSpeed = 100;
    }    

    public void offClick()
    {
        rotationSpeed = 0;
    }

}
