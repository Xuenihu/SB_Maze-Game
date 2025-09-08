using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionCheck : MonoBehaviour
{
    public Transform Player;
    public Vector3 positionEnd;
    public Vector3 playerPosition;
    public float DistancetoPoint;
    private bool FinishedGame = false;
    // Start is called before the first frame update
    void Start()
    {
        positionEnd = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = Player.position;
        if (FinishedGame) return;

        if (Vector3.Distance(Player.position, positionEnd) < DistancetoPoint)
        {
            Application.Quit();
            Debug.Log("FinishGame");
            FinishedGame = true;
            }   
    }

}
