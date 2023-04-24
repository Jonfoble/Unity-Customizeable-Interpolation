using UnityEngine;

public static class Interpolation
{
    public static Vector3 Interpolate(Vector3 a, Vector3 b, float t, bool linear = false)
    {
        if (linear)
        {
            return Vector3.Lerp(a, b, Mathf.Clamp01(t));
        }
        else
        {
            // Dot product - the cosine of the angle between 2 vectors.
            float dot = Vector3.Dot(a, b);

            // Clamp to be in the range of Acos() because its a floating value
            dot = Mathf.Clamp(dot, -1.0f, 1.0f);

            // Acos(dot) returns the angle between a and b and multiplying that by t returns the angle between start and the final result.
            float theta = Mathf.Acos(dot) * t;

            // Calculate the relative vector and normalize it
            Vector3 relativeVec = (b - a * dot).normalized;

            // The final result using spherical linear interpolation (slerp)
            return (a * Mathf.Cos(theta)) + (relativeVec * Mathf.Sin(theta));
        }
    }
}
