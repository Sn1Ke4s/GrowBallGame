using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOnAndPushAimBall : MonoBehaviour
{
    [SerializeField] private GameObject _aimBall;
    [SerializeField] private Rigidbody _aimBallRigidbody;
    [SerializeField] private GameObject _unlockDoorPoint;
    [SerializeField] private GameObject _spawnPointPosition;

    private const float _zoomInRangeForAimBall = 0.01f;

    private bool _isZoomInBall;

    private void FixedUpdate()
    {
        if (_isZoomInBall)
        {            
            _aimBall.transform.localScale += new Vector3(_zoomInRangeForAimBall, _zoomInRangeForAimBall, _zoomInRangeForAimBall);
        }
    }

    public void OnPressZoomIn()
    {
        _isZoomInBall = true;
        _aimBall.SetActive(true);
    }

    public void OnReleaseZoomIn()
    {
        _isZoomInBall = false;
        _aimBallRigidbody.AddForce(_unlockDoorPoint.transform.position, ForceMode.Force);
    }

}
