using UnityEngine;

public static class Interpolation
{
    public static Vector3 Interpolate(Vector3 a, Vector3 b, float t, bool linearlyInterpolate = false)
    {        
        // Dot product - the cosine of the angle between 2 vectors.
            float dot = Vector3.Dot(a, b);

            // Clamp to be in the range of Acos() because its a floating value
            Mathf.Clamp(dot, -1.0f, 1.0f);

            // Acos(dot) returns the angle between a and b and multiplying that by t returns the angle between start and the final result.
            float theta = Mathf.Acos(dot) * t;
            Vector3 RelativeVec = b - a * dot;
            RelativeVec.Normalize();

        // The final result.
        if (linearlyInterpolate)
		{
            Vector3 lerpedVector = a + (b - a) * Mathf.Sin(theta);
            return lerpedVector;
        }
		else
		{
            return ((a * Mathf.Cos(theta)) + (RelativeVec * Mathf.Sin(theta)));
        }
    }
}
