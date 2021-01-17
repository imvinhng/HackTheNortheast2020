using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameMana gm;

    void OnTriggerEnter()
    {

        gm.CompleteLevel ();



    }





}
