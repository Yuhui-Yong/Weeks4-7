using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Warper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If we click and we are not hovering over UI

        bool shouldMarp = Mouse.current.leftButton.wasPressedThisFrame && !EventSystem.current.IsPointerOverGameObject();

        if (shouldMarp == true)
        {
            Vector3 currentMousePosition = Mouse.current.position.ReadValue();
            transform.position = currentMousePosition;

        }
    }
}
