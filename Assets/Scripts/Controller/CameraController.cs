using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private float xRange;
        [SerializeField] private float yRange;
        [SerializeField] private float zRange;


        private Vector3 Min;
        private Vector3 Max;

        private Vector2 mouseStartPosition;

        void Start()
        {
            Min = transform.position - new Vector3(xRange, yRange, zRange);
            Max = transform.position + new Vector3(xRange, yRange, zRange);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(2))
            {
                mouseStartPosition = Input.mousePosition;
            }

            transform.Translate(Vector3.forward * Input.mouseScrollDelta.y);

            if (Input.GetMouseButtonDown(2))
                transform.Translate((Vector2)Input.mousePosition - mouseStartPosition);
        }

    }
}
