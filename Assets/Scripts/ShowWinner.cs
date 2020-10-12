using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowWinner : MonoBehaviour
{
    public GameObject winnerCavas;

    public void Start()
    {
        winnerCavas.SetActive(false);
    }

    public void OnCollisionEnter(Collision col)
    {
        winnerCavas.SetActive(true);
    }
}
