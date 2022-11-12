using System;
using UnityEditor.UI;
using UnityEngine;

namespace Utilities
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private float rotationSpeed;

        private void Update()
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime, Space.Self);
        }
    }
}