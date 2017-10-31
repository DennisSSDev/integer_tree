# integer_tree
This is a recursive tree

## How script works

In this program I solved a problem of keeping track of neighbour nodes of a tree. The execution goes through an itirative process where
each member will keep track of its left and right node and will determine when should the left or right neighbour would be null or have a reference to an existing member of the list of nodes. To get the output of values I pass in the nodes value and keep track of the depth level

## How to run it

Launch it in visual studio and run the program with ctrl+F5. You will specify the depth and it will give you an output.

## Organization

The only external .cs file I use is the Node class which will have references to the value, level and right/left nodes.
In the main program I just rin my loop that goes through an itirative process. In there I also output the results.

## Optimization

The results come almost immediately. Large optimiations come from the lambda expression I use with the list (Search for LIst keyword "Where")
