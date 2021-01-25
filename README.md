Letter: I Implemented an Object pool and a scriptable Object in Unity apart from the rest.

# Future-Games-Design-Patterns-Assessment
					
Tower defense is a subgenre of strategy video game where the goal is to defend a player's territories or possessions by obstructing the enemy attackers, usually achieved by placing defensive structures on or along their path of attack. You have to create a Tower Defense Player on Unity.

Your Tower Defense Player uses the maps as level descriptors. Game units spawn on "start tile" and walk to reach the "end tile", the end. Towers try to avoid units reaching the end by shooting at them. If a unit reaches the end the player will lose one life and the unit is removed from the map. The player starts with 20 lives, and Game Over is triggered when the player loses all lives.
					
The maps have this structure:
A grid of values showing the map structure\
#\
Wave lines with number of enemies by enemy type

This is an example:

0000000200001000001\
0000010300101020001\
9000020300101011101\
0000010300101010101\
0000020001000010108\
0000010300101020001\
0000010300101020001\
0000010300101020001\
0000010300101020001\
0000010300101020001\
'#'\
24 24			

You can find two map files inside the unity project\
Resources/map_1.txt\
Resources/map_2.txt

Map interpretation:				

Each cell in the map file can be interpreted as:

0: Path tile. This tile is walkable by units.\
1: Obstacle tile. This tile is an obstacle and units must avoid them.\
2: Tower defense 1. In this tile a Tower Defense Type 1 must appear. Units treat this tile as an obstacle.\
3: Tower defense 2. In this tile a Tower Defense Type 2 must appear. Units treat this tile as an obstacle.\
8: Start Tile. Units spawn in this point (Or as near as you can)\
9: End Tile. Units target tile.

And every wave line as:
xy\
where\
x is the number of units of type 1\
y is the number of units of type 2
 				 							
Elements behaviours:
 							
This is the behaviour for the elements:
Tower defense 1 is a bombing tower. It throws bombs targeting one unit but the bullet does area damage\
Tower defense 2 is a freezing tower. It targets and affects one unit only. The affected unit will be frozen for 2 seconds reducing its speed by half\
Unit of type 1. Standard unit. Walks default speed and has default resistance\
Unit of type 2. Bigger unit. Walks slower than type 1 but has more resistance and makes bigger damage
 							
Implemented:			 			

Smart use of Scriptable Objects\
Memory management (Intense use of memory pools)\
  Code :
    Readability (Followed code conventions)\
    Architecture\
    Avoidance of antipatterns\
    Object logic Composition (Balance between inheritance and composition)\
    Respect of SOLID principles in general.
