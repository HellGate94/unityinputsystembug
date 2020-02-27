using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class TestScript : MonoBehaviour {
    public void Test(CallbackContext context) {
        Debug.Log(context.phase);
    }
}
