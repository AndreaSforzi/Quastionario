using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float walkSpeed = 1 ;
    [SerializeField] float mouseSensitivity = 1;

    [SerializeField] Animator animator;

    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0, vertical) * walkSpeed * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0, mouseX, 0) * mouseSensitivity);

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Hit");
        }
    }

}
