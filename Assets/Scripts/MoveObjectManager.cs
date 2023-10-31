using UnityEngine;
using System.Collections.Generic;

public class MoveObjectManager : MonoBehaviour
{
    [SerializeField]
    private List<Transform> moveObjects = new List<Transform>();

    private int index;
    private float end = -20;
    private float moveObjectLength = 30;

    private void Update()
    {
        CheckMoveObject();
    }

    private void CheckMoveObject()
    {
        Vector3 pos = moveObjects[index].position;

        if (pos.z <= end)
        {
            int indexEnd = index + 2;
            if (indexEnd >= moveObjects.Count) indexEnd -= moveObjects.Count;

            Vector3 posEnd = moveObjects[indexEnd].position;
            pos.z = posEnd.z + moveObjectLength;

            moveObjects[index].position = pos;
            index++;
            if (index == moveObjects.Count) index = 0;
        }
    }
}
