using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCursor : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public Camera mainCamera;
    private int COUNT = 0;
    public int TIME = 300;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Do a raycast into the world based on the user's
        // head position and orientation.
        var headPosition = mainCamera.transform.position;
        var gazeDirection = mainCamera.transform.forward;

        RaycastHit hitInfo;
        Debug.DrawRay(transform.position, gazeDirection, Color.green);
        if(Physics.Raycast(headPosition, gazeDirection, out hitInfo)) //While raycast is hitting an object
        {
            COUNT++;
            //Debug.Log(COUNT);
            if (COUNT >= TIME) {
                Debug.Log("HIT!");
                COUNT = 1;
            }
        }
    }
}