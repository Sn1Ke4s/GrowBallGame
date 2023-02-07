using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class UnlockDoorSystem : MonoBehaviour
{
    public GameObject _spawnPointAimBall;

    [SerializeField] private GameObject _endPoint;
    [SerializeField] private Animation _animationOpenDoor;
    [SerializeField] private GameObject _mainBall;
    [SerializeField] private Canvas _winPanel;
    [SerializeField] private Button _gameplayButton;

    private void Awake()
    {
        _winPanel.gameObject.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<AimBall>())
        {
            other.gameObject.SetActive(false);
            other.transform.position = _spawnPointAimBall.transform.position;
            other.transform.localScale = new Vector3(0, 0, 0);
            _animationOpenDoor.Play();
            _mainBall.transform.DOJump(_endPoint.transform.position, 2f, 3, 3);
            _winPanel.gameObject.SetActive(true);
            _gameplayButton.gameObject.SetActive(false);


        }
    }
}
