# JigsawPuzzle
After hearing that jigsaw puzzle apps are a rising thing, and the concept of digitizing it is interesting to me.  Starting a project to research and prototype the technology of image manipulation, object organization, random piece generation, etc.

Features:
- parent environment and puzzle collection
  - keep list of all puzzles that have been created (uploaded/downloaded)
  - keep status, dates, % complete, etc. of each puzzle
- puzzle variables (especially for a new puzzle):
  - upload an image to use as the puzzle content.
  - manually set the grid size (number of pieces) (have a list of common sizes?)
  - complex edge variables for the piece generation
    - an 'edge' is the line between two pieces
    - edge has three main areas: upper line, lower line, and middle feature
    - for the lines: angle (10, 11, 12, 1, 2 o' clock orientation)
    - for the middle feature: none, bulb, point - bulb and points have variations too (size, slopes, directions, etc.)
    - combination should result in 100's of edges or 1000's.
  - options and variables to set the parameters of piece generation
- playing field variables:
  - piece piles
  - final puzzle area
  - subjective groups
  - zooming from the overall 'table' area, across piles, pieces, and down into a piece, and even to an edge
- Interaction and playing the puzzle
  - mouse move/click to pick up pieces and manipulate
  - move a piece to a different pile
  - move a piece to the final puzzle area
  - confirmation of success?
