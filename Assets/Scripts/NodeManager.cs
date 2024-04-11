using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeManager : MonoBehaviour
{
    public GameObject nodePrefab;  // Assign your node prefab in the Inspector

    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Get mouse position
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(mousePosition);
            mousePosition.z = 0f; // Ensure the nodes are on the same z-plane

            // Instantiate a new node at the mouse position
            Instantiate(nodePrefab, mousePosition, Quaternion.identity);
        }
    }
}
