**2. Terrain**

Unity's Terrain system is a very powerful tool that allows us to create vast forests, deserts or mountains in an easy and fast way. These are internally optimized for rendering, which makes using Terrain a better option than creating your own assets to build landscapes.

![terrain](https://user-images.githubusercontent.com/110602112/195823738-bd7cdbb0-4526-43db-9553-e120d879aa20.jpg)

Example of terrain created with Unity

To create a terrain you have to go to GameObject > 3D Object > Terrain. This will generate a completely white plane in the scene, which will will serve to start shaping it.

**2.1. The Terrain Editor**

The terrain editor is the Unity tool that will allow us to edit the properties of our land. We can access it from the Inspector once the terrain is selected. This tool consists of a custom editor where we can choose between several options, including brushes (brushes) that will serve us to model and paint our terrains in much the same way as you would work with am image editing tool like Photoshop.

Once the any of the options has been selected, the characteristics and properties of each one will appear at the bottom.

![image](https://user-images.githubusercontent.com/110602112/195826246-83aa64df-89b4-4d48-b786-c785983ca1c1.png)

Except for the configuration option, all other options have the Brush Size and Opacity properties in common. The first three options are used to shape the topography of the terrain, while the next three are used to give it details through the texture and generation of grass, rocks and trees.
| Note |
|------|
| Contrary to how it usually works in Unity, if we press the F key while we have a terrain selected, the focus will not be centered on the entire terrain but on the part of the terrain where we have the mouse placed. |

**2.2. Raise/lower terrain**

The first option that appears is for Raise/Lower Terrain. With this brush, as long as we hold down the mouse and move it over the surface of the terrain, it will begin to grow in height with the shape of the brush that we have selected in the Brushes section. If, on the contrary, we wanted to reduce the height, we should do the same but keeping the Shift key pressed.
The size of the brush defines how much of the terrain surface will be affected by it, and its opacity will mark the "fall" of this intensity. Some of the brush images have a gradient. The lower the opacity, the softer the weight of that gradient will be as it affects the terrain.

**2.3. Paint  heights**

The next option is Paint Height, with which we can define a specific height in the place where we paint.
Within its properties there is an extra option called Height, which will mark the target height. If we click on a point on the terrain with a height lower than this, the terrain will rise. And if, on the contrary, the point of the terrain where we click has a height greater than this, it will go down.

![image](https://user-images.githubusercontent.com/110602112/195826287-f0444412-2f06-4aa1-ae2c-ec8e3f7484e3.png)

| Note |
|------|
|The Flatten button places the entire terrain completely at the selected height.|

**2.4. Smooth height**

The third option is Smooth Height. It will help us to reduce the height difference between several areas, making an average of these and creating a less steep terrain. Something similar to what the Blur tool of an image editor would do.

**2.5. Paint textures**

The fourth option is the Paint Texture. We can paint the surface of the terrain to give the feel that we are on top of stone, ice, grass, mud, etc. Initially the terrain comes in white, without any defined texture, so we will have to add all those with which we want to paint our terrain.

To add the textures we will click on the Edit Textures > Add Texture button. The add terrain texture window allows us to add a diffuse texture Albedo and its Normal for that surface.

We can add several textures to the list, but the first one that we have in our list will be the one that will be applied as the base for the whole terrain.

| Note |
|------|
|Unity comes with several textures and models of trees and grass ready to use in our prototypes. We can install them from Window > AssetStore by downloading the 'Standard Assets' package.|

Every time we want to paint with a specific texture, we will only have to select it and decide the type of brush we want and its opacity. Here a new property will appear, Target Strength, which will mark the intensity that the texture will have when painted.

![image](https://user-images.githubusercontent.com/110602112/195826471-07a0d57c-99a7-4b13-be17-f881ff8b3fbf.png)
Painting grass on the ground

![image](https://user-images.githubusercontent.com/110602112/195826481-56fb2440-92da-412a-859e-9022fb7419ca.png)
Add texture window

**2.6. Trees**

The fifth option is Place Trees, with which we can populate our land with all kinds of vegetation. We will only have to add the 3D models of trees to the list of trees that appears, in a very similar way to how it is done with textures when painting.
If the tree model that we assign has been created with the Unity tree creator, the mesh selection window will show a property called Bend Factor, which will define how affected it will be by the force of the wind.

The operation of this tool is practically identical to that of the previous ones, but in this case we will have many more options, such as the density of trees that we want to be painted within the painting area, if we want them to have different heights/rotations, if we want that they are random or that they maintain the original aspect ratio of the tree.

Pressing the Shift or Control key while clicking will delete the existing trees within the painting area that are of the type selected in the tool.

On the other hand, the Mass place Trees button is used to massively populate the entire terrain with a random mix of trees of the types that we have loaded.

| Note |
|------|
|If you want to create a tree with the Unity tool, remember that you can always do it by accessing GameObject > 3D Object > Tree. You can find more information about its use at: https://docs.unity3d.com/Manual/tree-FirstTree.html.|

**2.7. Wind zones**

Procedurally generated trees with Unity can be affected by wind. To do this, we need to include the WindZone element in our scene by going to Game Object > 3D Object > Wind Zone.

![image](https://user-images.githubusercontent.com/110602112/195826595-a80498a0-d641-43b6-a79a-d48da41e49f9.png)
Wind zone properties

Its main option is the mode that defines whether it will be Directional (the wind will affect the entire scene) or Spherical (the wind will only affect the interior of the sphere marked by the Radius variable).

The Main property indicates the constant force of the wind, but to give it a more realistic behavior there are properties such as Turbulence, which quickly modifies the speed of the wind, and Pulse, with which we can define the frequency of these changes and their intensity.

| Note |
|------|
|You can find more information on how to get the most out of wind zones at: https://docs.unity3d.com/Manual/class-WindZone.html.|

**2.8. Paint details**

The sixth option is Paint Details, with which we can generate grass, flowers, rocks or decorative elements in general within the terrain.

![image](https://user-images.githubusercontent.com/110602112/195826602-aeec7f51-5af6-4392-9766-e3ce88a1efc4.png)
View of the grass on the ground

In this category we will find two options: Add Grass Texture and Add Detail Mesh. The grass can be made with textures applied to billboards that move in the wind or with fixed textures with a certain orientation, so we only need a texture and not a 3D model. In this way, we can use an alpha image of flowers or even barbed wire using the same system.

As the grass will be generated randomly, we will define minimum and maximum values, both for its height and width for each type of "grass texture" that we have. We can also define a color tint on that texture to give it a more "healthy" or "dryer" appearance depending on the "noise" that is generated. We can thus create areas of denser grass along with others that are less populated or dry.

In the case of having detail meshes, the system works exactly the same but selecting meshes that could be, for example, rocks.

| Note |
|------|
|It is a quad painted with a texture that is always facing the camera. This texture modifies its orientation according to the position of the camera in real time.|

**2.9. Terrain Settings**

Finally we have the Settings button, with which all the generic values ​​of the selected terrain are configured.

The most prominent options would be:
- Draw: activates or deactivates the painting of the terrain.
- Cast Shadows: Enable or disable the terrain to cast shadows.
- Tree/Detail Distance: The distance from the camera beyond which detail elements will not be rendered.
- Tree/Tree Distance: the same as the previous one, but for trees.
- Tree/Billboard Start: from what distance the meshes of the trees will be replaced by their billboards.
- Tree/Max Mesh Trees: the maximum number of trees represented by 3D meshes on screen before being replaced by billboards.
- Wind/Speed: the speed of the wind that will move the grass.
- Wind/Size: The size of the wind "waves" on the lawn.
- Wind/Bending – The amount of bending that will be applied to the grass as it moves.
- Resolution/Width-Height-Length: the size of the Terrain object in each of its axes.

The Import Raw and Export Raw buttons allow you to export the height map generated by the terrain as an image. This allows you to generate or modify terrain outside of Unity and then re-import it.

[Next - Vehicles](https://github.com/dbanakou/NYU_Games_S25/blob/main/m2-3d-racing-game/3%20-%20Vehicles.md)
