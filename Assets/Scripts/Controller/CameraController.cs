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

        private Vector3 mouseStartPosition;
        private Vector3 cameraStartPosition;

        void Start()
        {
            Min = transform.position - new Vector3(xRange, yRange, zRange);
            Max = transform.position + new Vector3(xRange, yRange, zRange);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(2))
            {
                mouseStartPosition = Input.mousePosition;
                cameraStartPosition = transform.position;
            }

            transform.Translate(Vector3.forward * Input.mouseScrollDelta.y * 0.1f);

            if (Input.GetMouseButton(2))
            {
                transform.position = cameraStartPosition + new Vector3(
                    (Input.mousePosition.x - mouseStartPosition.x),
                    (Input.mousePosition.y - mouseStartPosition.y) * -1f,
                    Input.mousePosition.z - mouseStartPosition.z) * 0.0002f;
            }
            ClampPosition();
        }

        private void ClampPosition()
        {
            var fixedPosition = new Vector3(
                Mathf.Clamp(transform.localPosition.x, Min.x, Max.x),
                Mathf.Clamp(transform.localPosition.y, Min.y, Max.y),
                Mathf.Clamp(transform.localPosition.z, Min.z, Max.z));

            transform.localPosition = fixedPosition;
        }
    }
}
