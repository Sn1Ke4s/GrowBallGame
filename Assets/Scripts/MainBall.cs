using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainBall : MonoBehaviour
{
    [SerializeField] private Canvas _losePanel;
    [SerializeField] private Button _gameplayButton;
    [SerializeField] private GameObject _gameplay;

    private void Awake()
    {
        _losePanel.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (this.transform.localScale == new Vector3(0, 0, 0))
        {
            _losePanel.gameObject.SetActive(true);
            _gameplayButton.gameObject.SetActive(false);
            _gameplay.SetActive(false);
        }
    }
}
