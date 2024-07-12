using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    private Vector2 _targetPosition;
    private Shoot _bullet;
    [SerializeField] private float _time;

    private void Start()
    {
        _bullet = new Shoot();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            PlayerPrefs.SetString("position", _targetPosition.ToString());
            _bullet.ShootBullet(this.transform.position, _targetPosition, _time);


        }

        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
    }
}
