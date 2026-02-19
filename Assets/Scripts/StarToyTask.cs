using UnityEngine;
using UnityEngine.InputSystem;

public class StarToyTask : MonoBehaviour
{
    public GameObject StarPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnStar()
    {
        // What I wanted to do here is that I wanna spawn the stars from the empty object, which is StarSpawner when players click the Star button. So, what I have to do was
        // Set the position of a variable (= spawnPos) randomly to put it in the "Instantiate" to make it spawn but also add the transform.position so that it can spawn from where
        // the object that is holding this script, which is the empty object, which is StarSpawner.

        // So, this is what I did first:
        // Vector2 SpawnPos = transform.position + (Random.insideUnitCircle * 3);
        // Instantiate(StarPrefab, SpawnPos);

        // And, then I realized that this doesn't work because transform.position is Vector3 and the Random.insideUnitCircle is Vector 2, so they cannot be added or together.

        // I tried this way but it didn't work.
        // Vector2 StarPos = transform.position;
        // Vector2 SpawnPos = StarPos + (Random.insideUnitCircle * 3);
        // Instantiate(StarPrefab, SpawnPos);

        // Nevermind, I asked somebody and found the solution, I did not have to make it spawn from the empty game object that I created, I could simply set the x and y values
        // randomly by using "Random.Range" But, I forgot about this code. I thought I could only use "Random.UnitCirlce" and stuff like that.
        float x = Random.Range(0f, 1150f);
        float y = Random.Range(1000f, 2040f);
        Vector2 StarPos = Camera.main.ScreenToWorldPoint(new Vector2(x, y)); // I need to change the MainCamera views from SreenToWorldPoint.

        GameObject AfterStar = Instantiate(StarPrefab, StarPos, Quaternion.identity); // This is for the furure that I will make the stars to be destoried after you spawn.
    }
}