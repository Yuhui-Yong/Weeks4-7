using NUnit.Framework;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Spwaner : MonoBehaviour
{
    // public GameObject KnifePrefab;

    public GameObject knifePrefab;
    public List<GameObject> currentKnives = new List<GameObject>();

    Vector3 pos1 = new Vector3(2.66f, 0.14f, -0.04245063f);
    Vector3 pos2 = new Vector3(-2.6f, -1.64f, -0.04245063f);
    Vector3 pos3 = new Vector3(-2.75f, 0.26f, -0.04245063f);
    Vector3 pos4 = new Vector3(2.4f, -1.18f, -0.04245063f);
    Vector4 pos5 = new Vector3(1.39f, -2.97f, -0.04245063f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        GameObject spawneObject1 = Instantiate(knifePrefab, pos1, Quaternion.identity);
        GameObject spawneObject2 = Instantiate(knifePrefab, pos2, Quaternion.identity);
        GameObject spawneObject3 = Instantiate(knifePrefab, pos3, Quaternion.identity);
        GameObject spawneObject4 = Instantiate(knifePrefab, pos4, Quaternion.identity);
        GameObject spawneObject5 = Instantiate(knifePrefab, pos5, Quaternion.identity);

        currentKnives.Add(spawneObject1);
        currentKnives.Add(spawneObject2);
        currentKnives.Add(spawneObject3);
        currentKnives.Add(spawneObject4);
        currentKnives.Add(spawneObject5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
