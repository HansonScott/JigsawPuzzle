# JigsawPuzzle
After hearing that jigsaw puzzle apps are a rising thing, and the concept of digitizing it is interesting to me.  Starting a project to research and prototype the technology of image manipulation, object organization, random piece generation, etc.

Features:
- parent workspace and puzzle collection
  - keep list of all puzzles that have been created
  - fields at the puzzle level:
    - date created, date started, date completed
    - % complete (% of pieces correctly placed into the final puzzle area), 
    - total piece count
    - 1-sided vs 2 sided puzzle
    - source picture path(s)
    - amount of time spent solving it so far.
- puzzle variables (especially for a new puzzle):
  - upload an image to use as the puzzle content (second pic for 2-sided puzzle).
  - manually set the grid size (number of pieces) (provide a list of common sizes in the UI?)
  - option to start with all pieces face up vs mixed (especially important for 2-sided puzzles)
  - option to start with pieces overlapping in piles vs one-depth only.
  - piece variables
    - x,y piece location in the picture
    - current x, y pixel location on the overal workspace
    - 4 edges
    - current pile it belongs to
  - complex edge variables for the piece generation
    - each piece has 4 edges (North, South, East, West)
    - an 'edge' is the line between two pieces
    - edge has three main areas: upper line, lower line, and middle feature
    - for the lines: angle (big outter slop, little outer slope, straight, little inner slope, big inner slope) (5 & 5)
    - for the middle feature: none (1), bulb, triangle
    - bulb options: small, large & straight, sagging, floating & deep, shallow = 2 x 3 x 2 x 2(in vs out) = 24
    - point options: large, small & central angle, low angle, high angle & deep, shallow = 2 x 3 x 2 x 2 (in vs out) = 24
    - combination should result in 100's of edges or 1000's. (5x5x49 variations on each side)
    - so, for example, the top-left corner piece has N=straight, no feature, straight. W=straight, no feature, straight. E&S - random
  - options and variables to set the parameters of piece generation
    - avoid straight edges on edge pieces - appears to be an internal section of the puzzle as opposed to straight, outer edges.
    - allow for straight edges within the puzzle in addition to the edges.
- playing field variables:
  - subjective piece piles, starting with the main pile
  - final puzzle area
  - zoom ability from the overall workspace area, zoom to view a pile, view some pieces, zoom into a piece, and even zoom into a close view of an edge
- Interaction and playing the puzzle
  - mouse click to select a piece 
  - mouse hold to pick up a piece
  - mouse drag to move a piece
  - mouse double click to 'freeze' a piece's location
  - mouse right click to attempt to connect a piece to another (feedback if wrong match and feedback if correct match)
  - mouse wheel to zoom, or UI slider
  - move a piece to a different pile
  - move a piece to the final puzzle area


class objects:
- workspace - the 'table' on which the puzzle is 'played', contains a puzzle and n piles, and piece locations
- puzzle - the overall image
- final puzzle area - the set location where the puzzle pieces end up and connected to the final picture
- pile - a subset of pieces of a puzzle
- piece - a clipped image with edges, with a link back to the parent puzzle
- edge - a collection of settings that determine the connection to another piece, and drawing parameters
- connection - a theoretical concept between two pieces and their orientation
