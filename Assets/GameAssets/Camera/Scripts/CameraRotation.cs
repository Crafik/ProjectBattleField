using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraRotation : MonoBehaviour
{
    private Controls _controls;

    private bool _isInputActive = false;
    private float _rotValue;

    [SerializeField] private float _mouseSens;

    void Awake(){
        _controls = new Controls();
    }

    void OnEnable(){
        _controls.Enable();

        _controls.Desktop.MouseLMB.performed += OnLMBDown;
        _controls.Desktop.MouseDelta.performed += OnMouseDelta;
    }

    void OnDisable(){
        _controls.Desktop.MouseLMB.performed -= OnLMBDown;
        _controls.Desktop.MouseDelta.performed -= OnMouseDelta;

        _controls.Disable();
    }

    private void OnLMBDown(InputAction.CallbackContext ctx){
        _isInputActive = !_isInputActive;
    }

    private void OnMouseDelta(InputAction.CallbackContext ctx){
        if (_isInputActive){
            _rotValue = ctx.ReadValue<Vector2>().x;
        }
    }

    void Update(){
        if (_isInputActive){
            transform.Rotate(Vector3.up, _rotValue * _mouseSens * Time.deltaTime, Space.World);
        }
    }
}
