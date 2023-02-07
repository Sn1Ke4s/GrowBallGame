using System;
using UnityEngine;

public class ZoomOutMainBallWithBallRoad: MonoBehaviour
{
    [SerializeField] private GameObject _ball;
    [SerializeField] private GameObject _ballRoad;

    private bool _isZoomOut = false;

    private const float _scaleOutRangeForBall = 0.01f;
    private const float _scaleOutRangeForRoad = 0.001f;
    private const float _transformDownRangeForBall = 0.005f;


    private void FixedUpdate()
    {
        ZoomOutRoadAndBall();


    }

    private void ZoomOutRoadAndBall()
    {
        if (_isZoomOut)
        {
            _ball.transform.localScale -= new Vector3(_scaleOutRangeForBall, _scaleOutRangeForBall, _scaleOutRangeForBall);
            _ballRoad.transform.localScale -= new Vector3(_scaleOutRangeForRoad, _scaleOutRangeForRoad, _scaleOutRangeForRoad);
            _ball.transform.localPosition -= new Vector3(0, _transformDownRangeForBall, 0);
        }
    }

    public void OnPressZoomOut()
    {
        _isZoomOut = true;
    }

    public void OnReleaseZoomOut()
    {
        _isZoomOut = false;
    }


}
