using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualCursorLock : MonoBehaviour
{

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            CursorLock();
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            CursorUnlock();
        }
    }

    void CursorLock()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void CursorUnlock()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
