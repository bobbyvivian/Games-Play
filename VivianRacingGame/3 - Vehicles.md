**3. Vehicles**

Here we will work with the vehicles that are included in their asset packages. As with the terrain assets, we can install them both when creating the project and later by accessing Assets > Import Package > Vehicles.

Before we dissect how our vehicle is internally formed, let's insert one into the scene. You can find its prefab in Assets > Standard Assets > Vehicles > Car > Prefabs > Car.prefab.

Objects with dynamic physics need a ground to hold on to, otherwise they would be falling forever, so in the same scene as our car, we should have a terrain or a cube or plane large enough and with colliders to that serves as a floor for our vehicle.

![image](https://user-images.githubusercontent.com/110602112/195828041-dc0d0654-ee44-4aeb-a479-542049f32dfc.png)

The prefab is already prepared so that we can drive it by simply adding it to the scene and pressing Play. Of course, it comes without cameras, some elements that we will add later, but we can already see its movement if we place an overhead camera on our terrain or if we directly follow the car in the scene view.

| Note |
|------|
|Internally, Unity currently uses Nvidia's PhysX3.3 SDK as the 3D physics engine.|

**3.1. Vehicle physics**

Physics in three dimensions are very similar to those in two dimensions. When one is already familiar with the components that Unity offered us for the management of 2D physics, the transition to 3D is very simple.

By moving to 3D we expand the complexity of the mathematical operations that have to be executed in the physics engine and add some components that did not exist before, such as the Character Controller. 

First we have the parent of the whole structure, called Car, which contains the scripts that manage the realistic movement of the vehicle, as well as the rotation of the wheels, its sound effects or the input of the player.

It additionally has an associated rigidbody. A 3D rigidbody works the same as a 2D one. It serves to give the vehicle a physical presence within the physics engine.

The decorative part of the object is found in the SkyCar child, which contains all the geometry of the car divided into parts to be able to use and modify them as we are interested. The three children (Lights, Particles and Helpers) are there to add realism to the car, as we will see later, but they do not affect its physical behavior at all.

The key parts of the car are its colliders and the wheels. The first child in the structure is where its colliders are contained, which will be used to detect collisions with the terrain or with other elements such as cars or dynamic objects placed in the scene.

![image](https://user-images.githubusercontent.com/110602112/195828095-6620bd2f-89ae-4643-abb8-b29bb30c4512.png)

Detail of the complete internal structure of the car

On the other hand we have the wheels. The WheelsHubs object contains four GameObjects, each intended to simulate the behavior of each of the car's wheels.

| Note |
|------|
|If you select one of the wheels with the game running, you will see that its pivot is not in the same place as the center of the wheel. That is because there is a joint from the pivot to the wheel that acts as a suspension.|

**3.2. WheelCollider**

The WheelCollider is a special type of collider created only to be used as a wheel and that contains specific properties to simulate the behavior of a real tire.

Its friction calculations are performed separately from the general physics engine calculations, so when it collides with another object it will not interact with any Physic Material. These calculations, apart from the engine, provide a more realistic behavior, since they allow to simulate the way in which the rubber of the tire absorbs a large part of the forces.

The most important properties of the WheelCollider are these:

- Mass: the mass of the wheel.
- Radius: the radius of the wheel.
- Wheel Damping Rate: is the ratio of the damping drop that there will be between one oscillation of the damper and the next.
- Suspension Distance: the distance from the pivot of the GameObject that contains this collider to the center of the wheel, which will simulate its suspension.
- Force App Point Distance: The height above the ground at which the turning force will be applied to the wheel.

The other values are used to configure the suspension and friction values on the two axles of the wheel.

Unfortunately, this component, as complete as it is, by itself will not do anything. We need to add another script that is in charge of modifying its values and making the wheel work. The usual thing is to apply a twist and a force to the wheel; the latter, depending on the collision with the ground it has and its characteristics, will apply a resultant force to the rigidbody of which it is a part, which will move the car.

Once applied, we look at how much this collider has rotated and apply that twist to the visual mesh that represents it.

![image](https://user-images.githubusercontent.com/110602112/195828112-a4818042-b96e-432b-81e0-1696dd135741.png)


The key variables and functions of this component are the following:

![image](https://user-images.githubusercontent.com/110602112/195828151-3f90c229-02fd-4b0e-b9b3-c88ca0d7702d.png)

**WheelCollider Inspector**
1. steerAngle: defines the steering angle to apply to the wheel.
2. motorTorque: is the amount of force applied at that moment of weather.
3. brakeTorque: the same, but for the brake force.
4. GetWorldPose(): returns by parameters the position and rotation of this Collider with respect to the world.


| Note |
|------|
|Unity recommends that for braking we do not use a negative motor force, but that we apply its brakeTorque correctly.|

[Next - 3D Cameras](https://github.com/dbanakou/NYU_Games_S25/blob/main/m2-3d-racing-game/4%20-%203D%20Cameras.md)


