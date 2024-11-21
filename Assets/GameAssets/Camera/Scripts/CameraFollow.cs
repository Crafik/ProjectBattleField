using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public static CameraFollow Instance { get; private set; }

    private GameObject _target;

    void Awake(){
        if (Instance != null && Instance != this){
            Destroy(gameObject);
        }
        else{
            Instance = this;
        }
    }

    void Update(){
        if (_target != null){
            transform.position = _target.transform.position;
        }
    }

    public void SetTarget(GameObject target){
        _target = target;
    }
}
