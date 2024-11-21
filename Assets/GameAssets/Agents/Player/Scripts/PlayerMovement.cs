using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidBody;

    private Controls _controls;

    private Vector2 _inputVector;

    [Header("Movement variables")]
    [SerializeField] private float _moveMaxSpeed;
    [SerializeField] private float _moveAcceleration;
    [SerializeField] private float _moveDragForce;
    [SerializeField] private float _moveDragForceOverflow;
    private int _currentMoveGear = 0;
    private float _currentMoveSpeed = 0f;

    [Space(5)]
    [SerializeField] private float _rotMaxSpeed;
    [SerializeField] private float _rotAcceleration;
    [SerializeField] private float _rotDragForce;
    [SerializeField] private float _rotDragForceOverflow;
    private int _currentRotGear = 0;
    private float _currentRotSpeed = 0f;

    void Awake(){
        _controls = new Controls();
    }

    void OnEnable(){
        _controls.Enable();

        _controls.Desktop.Move.performed += OnDesktopMovementPerformed;
    }

    void OnDisable(){
        _controls.Desktop.Move.performed -= OnDesktopMovementPerformed;

        _controls.Disable();
    }

    private void OnDesktopMovementPerformed(InputAction.CallbackContext ctx){
        _inputVector = ctx.ReadValue<Vector2>();
    }

    void FixedUpdate(){
        MovementHandler();
        RotationHandler();
    }

    private void MovementHandler(){
        if (_inputVector.y != 0f){
            if (_currentMoveGear != 0){
                if (_currentMoveGear * _inputVector.y > 0){
                    _currentMoveSpeed += _moveAcceleration;
                }
                else{
                    if (_currentMoveSpeed > _moveMaxSpeed){
                        _currentMoveSpeed -= _moveDragForceOverflow * 1.5f;
                    }
                    if (_currentMoveSpeed > 0f){
                        _currentMoveSpeed -= _moveDragForceOverflow;
                    }
                    else{
                        _currentMoveGear = 0;
                        _currentMoveSpeed = 0f;
                    }
                }
            }
            else{
                _currentMoveGear = _inputVector.y > 0f ? 1 : -1;
            }
        }
        else{
            if (_currentMoveSpeed > 0f){
                _currentMoveSpeed -= _moveDragForce;
            }
            else{
                _currentMoveGear = 0;
                _currentMoveSpeed = 0f;
            }
        }
        if (_currentMoveSpeed > _moveMaxSpeed){
            _currentMoveSpeed -= _moveDragForceOverflow;
        }
        _rigidBody.MovePosition(_rigidBody.position + _currentMoveSpeed * _currentMoveGear * Time.fixedDeltaTime * transform.forward);
    }

    // yeah yeah copied and pasted, live with that
    private void RotationHandler(){
        float currentInfluence = _inputVector.x;
        if (_inputVector.y < 0f){
            currentInfluence *= -1f;
        }
        if (currentInfluence != 0f){
            if (_currentRotGear != 0){
                if (_currentRotGear * currentInfluence > 0){
                    _currentRotSpeed += _rotAcceleration;
                }
                else{
                    if (_currentRotSpeed > _rotMaxSpeed){
                        _currentRotSpeed -= _rotDragForceOverflow * 1.5f;
                    }
                    if (_currentRotSpeed > 0f){
                        _currentRotSpeed -= _rotDragForceOverflow;
                    }
                    else{
                        _currentRotGear = 0;
                        _currentRotSpeed = 0f;
                    }
                }
            }
            else{
                _currentRotGear = currentInfluence > 0f ? 1 : -1;
            }
        }
        else{
            if (_currentRotSpeed > 0f){
                _currentRotSpeed -= _rotDragForce;
            }
            else{
                _currentRotGear = 0;
                _currentRotSpeed = 0f;
            }
        }
        if (_currentRotSpeed > _rotMaxSpeed){
            _currentRotSpeed -= _rotDragForceOverflow;
        }

        _rigidBody.MoveRotation(_rigidBody.rotation * Quaternion.AngleAxis(_currentRotSpeed * _currentRotGear * Time.fixedDeltaTime, Vector3.up));
    }
}
