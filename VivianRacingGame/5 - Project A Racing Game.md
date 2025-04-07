**Introduction**

In this section we are going to describe how to develop a simple 3D racing game. The game will consist of trying to win a race around a circuit against other cars. This project will work mainly with physics, cameras and a very simple version of an AI.

**5.1. Car**

We already have our standard car downloaded in the Unity asset package, but it comes without a diffuse texture and is painted a very dull gray. To give it a little more life and variety, we will change the materials in some areas. The first thing we will do is duplicate the SkyCarBodyGrey material until we create three more, one with the “Albedo” tint in blue, one in red and one in dark gray.

We will assign these new materials to the MeshRenderer component of the meshes of the car that we want to change.

![image](https://user-images.githubusercontent.com/110602112/195831334-f1072a54-48a1-4195-a8d9-1e7eeebdd7f7.png)

The MeshRenderer component is the one in charge of drawing the geometry contained in the mesh assigned to the Mesh Filter component of that same object. Its Materials property contains a list of all the materials that will be used to paint that geometry.

![image](https://user-images.githubusercontent.com/110602112/195831340-3801bdf7-816d-43cd-b5e3-ca6fe429c6bd.png)

**Material inspector**
The materials contain the information needed to paint a geometry triangle. That information usually contains the texture of
diffuse (Albedo) that will define the color and drawing of that triangle, and its normal texture, which serves to give a fictitious volume to that geometry. It also includes other textures that will help us to give it a more realistic result to the painting process or information on how those textures should be tiled.

Now that we have our personalized car, we are going to create a circuit where we can circulate and do the race.

| Challenge 1|
|------|
|Change the default color of the car body, glass, wheels and fenders.|

![image](https://user-images.githubusercontent.com/110602112/195831342-1a925511-69c8-40b3-b089-79ad726472b7.png)

**5.2. The land**

A racing game is not complete, no matter how many cars it has, without a stage and a track to run on. In our exercise we will create a mountainous terrain with a lake, a forest and a large esplanade.

| Challenge 2|
|------|
|Create a 400 x 400 terrain containing mountainous areas, a large grassy esplanade, all terrain with plenty of trees and vegetation, and a populated forest area. There are at least two types of grass and three types of trees. And the mountainous areas do not have the same texture as the ground and their peaks are covered in snow.|

To give that terrain a little more life, we will add a small lake. To do this, we will use the Water component, which comes with the asset package Environment that we will have previously installed.

![image](https://user-images.githubusercontent.com/110602112/195831345-d656ed52-79d2-4e4b-9364-960e62026e74.png)

In this case we will use the prefab found in Assets > Standard Assets > Environment > Water > Water > Prefabs > WaterProDaytime.prefab. For this exercise we will not need to tweak any of its values beyond its scale to adapt it to our terrain and not be seen the cut when it ends.

**5.3. The circuit**

Let's add the circuit. Unity doesn't have a tool for this, and it would normally be the artists or designers in charge of creating the geometry of the circuit. As it is not the objective of this module to model 3D, we will use a free tool to create roads available in the Asset Store.

![image](https://user-images.githubusercontent.com/110602112/195831565-4ab05c7d-27b1-428d-958d-213bccdf4354.png)

| Note|
|------|
|You can download the plugin by searching for its name in Window > Asset Store, or from the following link: https://assetstore.unity.com/packages/3d/characters/easyroads3d-free-v3-987.|


We will insert in our scene the prefab Assets > EasyRoads3D Free > Resources > EasyRoad3DObject.prefab. This object contains a component called Road Object Script that looks quite similar to the terrain editor. The first thing we recommend to do is go to the GameObject> Create menu Other > EasyRoads3D > BackUp > All Terrain Data, to make a copy security of our land, so that we do not lose what we already have if we want to go back later. If that were the case, we would only need to go to the Restore > All Terrain Data option in that same menu.

There are many options of this Unity plugin you can explore, but we will focus on the first button, Add Road Markers, which allows us to create our road pressing Shift while clicking on different points of the terrain. The last point does not automatically close the road; for that, we will have to go to the Settings button and in the Object Settings subcategory
activate Closed Track so that the circuit is closed.

Do not be afraid to go over mountains or between trees, since the circuit will adapt to any surface (except water).

Under Settings we can also change the width of the road with the Road Width option. Unfortunately and since it is a free version, if the circuit created is not to our liking, we will have to delete the object and start from scratch. Once we have a circuit that we like, we will click on the third button, Process Terrain, to generate the circuit.

![image](https://user-images.githubusercontent.com/110602112/195831555-c2a381fa-3cd7-46c1-9772-db9b6b35294f.png)

As you can see, the plug-in has modified the terrain for us to adapt to its topography. At some points you will have to be careful not have very steep ramps or very sharp curves because in those cases the geometry or the terrain does not end up looking good.

| Challenge 3|
|------|
|Create a loop around the terrain, skirting the lake, through the woods, past the esplanade, and around the mountains, but without any steep drops or extremely tight turns.|

**5.4. The camera**

Now that we have the land, the circuit, and a car, we have to place a camera that allows us to take a drive around the
terrain and through our circuit.

As a basic camera we will use the Cameras asset package, which we can import into the project by going to the menu Assets > Import Package > Cameras. Once installed in the project, we will use the prefab that is found under: Assets > StandardAsset > Cameras > Prefabs > MultipurposeCameraRig.prefab.

We will place it behind our car at the desired distance (without making it a child!), and since the car will surely already have the Player tag, the Auto Cam camera script will have selected it as the object to follow.

| Note|
|------|
|Remember that if you have not deleted the main camera from the scene, you will have two cameras at the same time and the one with the highest depth will be painted. It is recommended to have only one camera active at a time.|

![image](https://user-images.githubusercontent.com/110602112/195831563-341212e8-4937-4b3c-b42e-e94cb5636913.png)

| Challenge 4|
|------|
|Modify the values of the Auto Cam component so that the camera follows the car in a realistic way, just as we would expect in a normal car game.|

**5.5. the rivals**
Now that we can go around the circuit by ourselves, we only we have to create our opponents in the race. For the enemy cars we will use a prefab similar to the one in player's car, but is prepared to follow a series of waypoints that mark the layout of the circuit. So we'll start by adding the Waypoint Circuit script to our object Road that contains the geometry of the circuit. And then we'll go creating empty GameObjects as their children that mark the entire circuit layout.

Through all these children, once we have the complete layout, we will create a trajectory through which our AI cars will circulate.

![image](https://user-images.githubusercontent.com/110602112/195831714-351c803f-01be-4cd9-a1ad-2e495665f954.png)

When we have all the children created, we will go to the WayPoint component Circuit of our Road object and click the Assign Using All button Child Objects.

| Note|
|------|
|It seems that the script has an auto-import problem and sorts the waypoints by name and not by the order they were created. So that we don't have problems with that order, rename the first nine GameObjects so that instead of ending in (1) they end in (01) and thus are used before the others.|

Once all the waypoints have been added, if we modify the variable Visualization Substeps Editor, we will see how a yellow line has been created that will be the route along which our AI cars will circulate. The higher the value, the smoother they will go.

| Challenge 5|
|------|
|Create the entire series of waypoints following the route of the road and at the same height so that the AI cars can circulate through the same circuit as us automatically.|

If we now add the enemy car prefabs from the prefab Assets > Standard Asset > Vehicles > Car > Prefabs >
CarWaypointBased.prefab and to your component's Circuit variable Waypoint Progress Tracker we pass our Road object which contains all the waypoints, it will know which route to follow.

| Note|
|------|
|It is important to change the tag from player to artificial intelligence cars so that our camera does not go away.|

Now we can race against different cars on our circuit.

| Challenge 6|
|------|
|Create different artificial intelligences with cars of different colors and each start at a different place on the circuit. Also make sure that by modifying the Car AI Control car script they have a different behavior for each one.|

[Next - Solutions](https://github.com/dbanakou/NYU_Games_S25/blob/main/m2-3d-racing-game/6%20-%20Solutions.md)

