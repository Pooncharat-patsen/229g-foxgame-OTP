using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotmiss : MonoBehaviour
{
    private Camera mainCamera;
    public GameObject offset;
    void Start()
    {
        
        mainCamera = Camera.main;
    }
    void Update()
    {
        Vector2 mousePosition = GetMouseWorldPosition();
        transform.position = new Vector2(mousePosition.x, mousePosition.y);
        offset.transform.position = new Vector2(mousePosition.x, mousePosition.y);
    }

    private Vector2 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -mainCamera.transform.position.z;
        return mainCamera.ScreenToWorldPoint(mousePosition);
    }
}
