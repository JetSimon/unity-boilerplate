using UnityEngine;

namespace Boilerplate.Utility
{
    public static class Vector3Utils
    {
        public static Vector3 ClampVectorElementWise(Vector3 vector, Vector3 min, Vector3 max)
        {
            Vector3 output = vector;

            output.x = Mathf.Clamp(output.x, min.x, max.x);
            output.y = Mathf.Clamp(output.y, min.y, max.y);
            output.z = Mathf.Clamp(output.z, min.z, max.z);
            
            return output;
        }
    }
}