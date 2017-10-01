using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCursorLock : MonoBehaviour
{
    void Start()
    {
        CursorLock();
    }
    void OnDisable()
    {
        CursorUnlock();
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
