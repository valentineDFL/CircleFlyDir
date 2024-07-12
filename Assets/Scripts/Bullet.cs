using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    internal class Bullet : MonoBehaviour
    {
        private Vector2 _targetPos;
        private float _velocity;

        public void Initialize(Vector2 targetPos, float velocity)
        {
            _targetPos = targetPos;
            _velocity = velocity;
        }
        
        private void Update()
        {
            transform.position = Vector2.MoveTowards(this.transform.position, _targetPos, _velocity * Time.deltaTime);
            print(Time.fixedDeltaTime + " - fixedTime");
            //print(Time.deltaTime + " - time");

            if (this.transform.position == (Vector3)_targetPos)
            {
                Destroy(this.gameObject);
            }

        }

    }
}
