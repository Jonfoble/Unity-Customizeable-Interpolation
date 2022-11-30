# Unity Customizeable Interpolation

## What is Interpolation?

In unity there are Vector3 methods called "Slerp()" and "Lerp()", which is allowing us to interpolate an action in 3D vectoral space.

Lerp, which is Linear interpolation is allowing us to do curve fitting using linear polynomials
to create new data points within the range of a discrete set of known data points.

For instance, Linear Interpolation between known two points is the straight line between those points.
![2](https://user-images.githubusercontent.com/91648268/204701994-2e5ea2ed-7e49-4ee4-86d0-9074de3513c6.png)

The Calculation:   ![1](https://user-images.githubusercontent.com/91648268/204702199-43f30240-8791-4993-92be-5b02c4aaf88d.png)





## Why Should I Use This?

A system that is allowing users to use Slerp() and Lerp() Vectors within a single method.
When dealing with Linear and Spherical Linear Interpolation, there are times when we need to turn
Spherical Interpolation into Linear Interpolation. In order for users to achieve this within unity,
They would need to create different Vectors both for Slerp and Lerp.

However, with this implementation only thing that we will need is going to be a boolean parameter.

Standard Slerp and Lerp would take IE;

Vector3.Slerp(Vector3 x, Vector3 y, Float t).
Vector3.Lerp(Vector3 x, Vector3 y, Float t).

With the implementation; 

Interpolation.Interpolate(Vector3 x, Vector3 y, Float t, Bool linearlyInterpolate).
