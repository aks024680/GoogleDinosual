using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DinosaurGoogle
{


    public class LoopingMap : MonoBehaviour
    {
        public float scrollSpeed = 500.0f;
        private Renderer mapRenderer;
        private float mapWidth;

        private void Start()
        {
            mapRenderer = GetComponent<Renderer>();
            mapWidth = mapRenderer.bounds.size.x;
        }

        private void Update()
        {
            // 获取地图当前位置
            Vector3 currentPosition = transform.position;

            // 移动地图
            currentPosition.z -= scrollSpeed * Time.deltaTime;

            // 当地图超出边界时，重新定位地图
            if (currentPosition.z < -mapWidth)
            {
                currentPosition.z += mapWidth * 2; // 乘以2以确保地图无缝循环
            }

            // 更新地图位置
            transform.position = currentPosition;
        }
    }
}


