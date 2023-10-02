# Unity Customizeable Interpolation

## What is Interpolation in Unity?

In unity there are Vector3 methods called "Slerp()" and "Lerp()", which is allowing us to interpolate an action in 3D vectoral space.

Lerp, which is Linear interpolation, is allowing us to do curve fitting using linear polynomials
to create new data points within the range of a discrete set of known data points.

For instance, Linear Interpolation between known two points is the straight line between those points:
![2](https://user-images.githubusercontent.com/91648268/204701994-2e5ea2ed-7e49-4ee4-86d0-9074de3513c6.png)

The Calculation:   ![1](https://user-images.githubusercontent.com/91648268/204702199-43f30240-8791-4993-92be-5b02c4aaf88d.png)

Linear Interpolation of a data set (red dots are the data sets and the blue lines are linear interpolants):

![3](https://user-images.githubusercontent.com/91648268/204703093-0aa949ed-7289-4259-9f58-6bb7abda3b3a.png)

Slerp, which is Spherical Linear Interpolation, is allowing us to achieve that behaviour again but in a spherical way.

For instance, if I were to use Spherical Linear Interpolation on the same data set we will have this result:

![4](https://user-images.githubusercontent.com/91648268/204703725-177d63ea-050a-4f1c-96fb-009f84640beb.png)


The Calculation: 
![5](https://user-images.githubusercontent.com/91648268/204703884-bb1a1820-c64a-45e4-93a7-9beb317933aa.png)

![6](https://user-images.githubusercontent.com/91648268/204703911-693d0494-25ef-4f65-8f56-7948b49dbccf.png)

## Why Should I Use This?

System is allowing users to use Slerp() and Lerp() Vectors within a single method utilising a boolean.
When dealing with Linear and Spherical Linear Interpolation, there are times when we need to turn
Spherical Interpolation into Linear Interpolation. In order for users to achieve this within code,
they would need to create different Vectors both for Slerp and Lerp, which would effectively increase 
the space complexity of the overall implementation. However, with this implementation, only thing that we will need is going to be a boolean variable which we can trigger in need.

Simplification: By allowing users to switch between Slerp and Lerp within a single method, it streamlines the process. Rather than having two separate calls in code and managing them separately, you just have one, which can be especially handy if you are often switching between the two or if different parts of the code require different interpolations.

Efficiency: Reducing the need for creating multiple vector objects can save memory, particularly in situations where these interpolations are done frequently or with large sets of data.

Flexibility: With just a boolean switch, developers can easily choose which interpolation they want to use without restructuring or rewriting parts of their code. This encourages experimentation and finding the best fit for a given situation.

Use Cases: The example provided is just one of many. Interpolation is used in many aspects of game development, from animations, character movement, camera motion, transitioning between game states, and so on. Being able to quickly switch between linear and spherical interpolation is a valuable tool.

Learning and Debugging: For beginners or even for debugging purposes, having the ability to quickly switch and visually see the difference between the two interpolations can be insightful.

## How To Use?
Adding the Interpolate.cs into the project is enough. Afterwards, you are going to be able to reach out to the method by calling it.

Standard Slerp and Lerp would take IE.;

Vector3.Slerp(Vector3 x, Vector3 y, Float t).

Vector3.Lerp(Vector3 x, Vector3 y, Float t).

With the implementation; 

Interpolation.INTERP(Vector3 x, Vector3 y, Float t, Bool linear).

## Any Example Use Case?

There are countless possible use cases but as an instance;

We could shoot a guided missile by spherically interpolating to a target destination
and change it to linear interpolation in case of an encounter with an enemy and chase it linearly interpolating.
