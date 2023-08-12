using UnityEngine;

public static class Interpolation
{
    // Constants to clamp dot product
    private const float MinDotProductValue = -1.0f;
    private const float MaxDotProductValue = 1.0f;

    /// <summary>
    /// Interpolates between two vectors either linearly or spherically based on the specified parameter.
    /// </summary>
    /// <param name="a">Start vector.</param>
    /// <param name="b">End vector.</param>
    /// <param name="t">Interpolation parameter.</param>
    /// <param name="linear">If set to <c>true</c>, use linear interpolation. Otherwise, use spherical interpolation.</param>
    /// <returns>Interpolated vector.</returns>
    public static Vector3 Interpolate(Vector3 a, Vector3 b, float t, bool linear = false)
    {
        return linear ? LinearInterpolate(a, b, t) : SphericalInterpolate(a, b, t);
    }

    private static Vector3 LinearInterpolate(Vector3 a, Vector3 b, float t)
    {
        return Vector3.Lerp(a, b, Mathf.Clamp01(t));
    }

    private static Vector3 SphericalInterpolate(Vector3 a, Vector3 b, float t)
    {
        float dot = Vector3.Dot(a, b);
        dot = Mathf.Clamp(dot, MinDotProductValue, MaxDotProductValue);

        float theta = Mathf.Acos(dot) * t;
        Vector3 relativeVec = (b - a * dot).normalized;

        return (a * Mathf.Cos(theta)) + (relativeVec * Mathf.Sin(theta));
    }
}
