using UnityEngine;

public class MouseOver2 : MonoBehaviour
{
    public void ToggleTri()
    {
            gameObject.SetActive(!gameObject.activeInHierarchy);

        //if (gameObject.activeInHierarchy == false)
        //{
        //    // If the game object is off, then call .SetActive(true) to turn it on.
        //    gameObject.SetActive(true);
        //}
        //else
        //{
        //    // Otherwise, call .SetActive(false) to turn it off.
        //    gameObject.SetActive(false);
        //}

    }
}
