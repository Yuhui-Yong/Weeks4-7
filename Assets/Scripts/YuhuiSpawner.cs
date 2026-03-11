using UnityEngine;
using UnityEngine.InputSystem;

public class YuhuiSpawner : MonoBehaviour
{
    public GameObject YuhuiPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spawnPos = new Vector3(6.07f, 0f, 0f);
        if (Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            GameObject PlsSapwn = Instantiate(YuhuiPrefab, spawnPos, Quaternion.identity);
        }
    }
}
