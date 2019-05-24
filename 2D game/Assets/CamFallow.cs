using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFallow : MonoBehaviour
{
    public Transform player;
    public int movementSpeed = 100;
    void Update()
    {
        Vector3 playerPosition = new Vector3(player.position.x, player.position.y, -5);
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, movementSpeed * Time.deltaTime);
    }
}
