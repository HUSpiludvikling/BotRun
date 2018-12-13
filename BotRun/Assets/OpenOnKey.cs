using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOnKey : MonoBehaviour
{
    //Der er en tast der hedder OpenKey, som er sat til esc, men man kan ændre den.
    [SerializeField] KeyCode OpenKey = KeyCode.Escape;
    //Den sørger for at der er en utjekket bool
    bool isOpen = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Hvis man trykker på OpenKey så...
        if (Input.GetKeyDown(OpenKey))
        {
            //...pauser den og sender IsOpen ind.
            Pause(ref  isOpen);
        }
    }

    /// <summary>
    /// Pauses or unpauses the game
    /// </summary>
    /// <param name="isopen">Determines if the game is paused or unpaused</param>
    //Ændrer IsOpen til isopen så det er lovligt at ændre på den.
    private void Pause(ref bool isopen)
    {
        //Kan ikke huske det.
        isopen = !isopen;
        //For hver child af dette object...
        foreach (Transform item in transform)
        {
            //...aktiverer eller deaktiverer isopen
            item.gameObject.SetActive(isopen);
        }
        //Hvis isopen er aktiveret, altså hvis spillet er pauset...
        if (isopen)
        {
            //...sættes tidens hastighed til 0 altså stopper tiden.
            Time.timeScale = 0f;
        }
        //Ellers, hvis spillet ikke er pauset og isopen derfor ikke er aktiveret...
        else
        {
            //...sættes tidens hastighed til 1 som er standart tidshastighed.
            Time.timeScale = 1f;
        }
    }
}