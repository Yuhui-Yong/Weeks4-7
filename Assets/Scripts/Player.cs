using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int health;
    public GameObject YuhuiPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            Destroy(gameObject);
        }

        Vector3 spawnPos = new Vector3(6.07f, 0f, 0f);
        if (Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            Instantiate(gameObject, spawnPos, Quaternion.identity);
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
