using NUnit.Framework;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Knife : MonoBehaviour
{
    // public GameObject KnifePrefab;

    public List<GameObject> KnifePrefab;
    private List<GameObject> knife = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject spawneObject = Instantiate(knife, transform.position, Quaternion.identity);
        knife.Add(spawneObject);
    }
}
