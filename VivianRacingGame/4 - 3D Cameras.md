**4. 3D Cameras**

In a 3D game the cameras usually have much more prominence than in a 2D one. Not only because of the complexity of the movements and actions they do, but also because of their configuration.

In this section we will go a little deeper into the details that make them up and we will see the two types of camera that we can use in a 3D game.

**4.1. Perspective camera**

The perspective camera is the one used in the vast majority of 3D games. This camera simulates our field of vision in a realistic way, in which distant objects appear smaller than those closer to the camera.

The frustum is the volume of the camera view. In the image it is the entire interior area delimited by white lines. Any object that is inside the frustum will be painted. If an object is left out, it will not be painted. If an object is cut half inside half outside, when it is drawn on the screen, only the part that remains inside will be visible.

![image](https://user-images.githubusercontent.com/110602112/195829114-f1bbbdfb-5509-4735-af93-0d9fec742f7e.png)

The viewing frustum is shaped like a pyramid with the tip cut. The values that configure the frustum are given by:

**Clipping Planes (Near/Far):** the two planes perpendicular to the camera orientation. They mark where it is going to start painting and where it is going to end.

**Field of View:** this value indicates the horizontal viewing angle of the camera. If it is small, it will simulate that we are looking through a gate. If we make it bigger, it will simulate a wide angle.

**4.2. Orthographic camera**

This type of camera is the one that is usually used in 2D games. Using a orthographic projection allows to draw all the elements of the scene evenly, without perspective, just as a picture would be drawn. All distances remain the same even though the elements in the scene are closer or farther from the camera. This type of cameras, in addition to 2D games, is also usually use to generate minimaps.

![image](https://user-images.githubusercontent.com/110602112/195829119-7e10f58b-81b1-4b9f-b3c6-9af5ece018e1.png)

This image shows how the frustum is shaped rectangular and has no Field of View. The values that configure this frustum are given by:

**Clipping Planes (Near/Far):** the two planes perpendicular to the camera orientation. They mark where it is going to start painting and where it is going to end.

**Size:** this value indicates the width that the camera will have. The total width of the frustum will be 2*Size.

**4.3. General properties**
Whichever camera we choose for our game, they all share certain common values. Let's see the most important ones:

**Viewport Rect:** These four values indicate where in the viewport screen the contents of the camera will be painted. Values range from 0 to 1 in proportion to the screen. X and Y indicate the bottom position left where it will be painted, and W and H, its width and height in screen percentage from 0 to 1.

**Depth:** if there are several cameras active at the same time, this value will indicate priority when it comes to painting. The highest value cameras will paint over the lower value ones.

![image](https://user-images.githubusercontent.com/110602112/195829108-1e4655fc-3428-4138-9bc8-ad064412213e.png)

You can find more information about the cameras and how they are used at: https://docs.unity3d.com/es/2020.1/Manual/CamerasOverview.html

[Next - Project: Making a Racing Game](https://github.com/dbanakou/NYU_Games_S25/blob/main/m2-3d-racing-game/5%20-%20Project%20A%20Racing%20Game.md)
