namespace TurnTheGameOn.SimpleTrafficSystem
{
    using UnityEngine;
    using Unity.Collections;
    using Unity.Burst;
    using UnityEngine.Jobs;

    public struct AITrafficCarPositionJob : IJobParallelForTransform
    {
        public NativeArray<Vector3> carTransformPositionArray;
        public NativeArray<Vector3> carTransformPreviousPositionArray;

        public void Execute(int index, TransformAccess carTransformAccessArray)
        {
            carTransformPreviousPositionArray[index] = carTransformPositionArray[index];
            carTransformPositionArray[index] = carTransformAccessArray.position;
        }
    }
}