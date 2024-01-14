using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float moveSpeed;

    [Header("Controls")]
    [SerializeField] private float slideSpeed;
    private Vector3 clickedScreenPosition;
    private Vector3 clickedPlayerPosition;


    // Update is called once per frame
    void Update()
    {
        HandleMoveForward();
        HandleMoveSideways();
    }

    private void HandleMoveForward()
    {
        transform.position += moveSpeed * Time.deltaTime * Vector3.forward;
    }

    private void HandleMoveSideways()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickedScreenPosition = Input.mousePosition;
            clickedPlayerPosition = transform.position;
        }
        else if (Input.GetMouseButton(0))
        {
            float xScreenDifference = Input.mousePosition.x - clickedScreenPosition.x;

            xScreenDifference /= Screen.width;
            xScreenDifference *= slideSpeed;

            Vector3 newPosition = transform.position;
            newPosition.x = clickedPlayerPosition.x + xScreenDifference;
            transform.position = newPosition;
        }
    }
}
