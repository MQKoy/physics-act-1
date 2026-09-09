# Results of test

Predicted distance for Cube B: 25 units



| Cube | 30 fps | 60 fps | 144 fps |

|------|--------|--------|---------|

| A    |   730  |  1345  |  2825   |

| B    |125.4142|125.3425| 125.0064|

| C    |139.2882|140.8186|143.1098 |



the test was given a 5 sec timer for each fps







Cube A increments its position by 5 units per frame, not multiplied by Time.deltaTime. As such, the higher the frame rate, the more distance Cube A will travel over the course of 5 seconds, due to the increased number of Update calls.



The distance of Cube C does not depend on the render frame rate since it is controlled by FixedUpdate and not by the render frame directly. The value of Time.fixedDeltaTime sets the frequency of calls to FixedUpdate . The default value of this variable is 0.02 seconds which corresponds to approximately 50 FixedUpdates per second. The size of Cube C is not 25 units since the script adds 5 units to the local position of the cube each fixed update without multiplication by Time.fixedDeltaTime . With a default fixed timestep, there will be approximately 250 FixedUpdates during 5 seconds which means that the cube will move approximately 5 × 250 = 1250 units.



