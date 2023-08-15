using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public UDPReceiver udpReceiver;
    public float moveSpeed;
    public GameObject leftPlayer;
    public GameObject rightPlayer;

    void Update()
    {
        var heights = ReadTrackerData();
    }

    private (float leftHeight, float rightHeight) ReadTrackerData()
    {
        string data = udpReceiver.data;
        data = data.Remove(0, 1);
        data = data.Remove(data.Length-1, 1);
        string[] heights = data.Split(',');

        float leftHeight = float.Parse(heights[0]);
        float rightHeight = float.Parse(heights[1]);

        return (leftHeight, rightHeight);
    }

    private void MovePlayer(GameObject player, float height)
    {
        
    }
}
