(szép megjelenítésért: https://github.com/RandomByteFF/Logic-Games)
# Logic-games

Collection of 3 logic games for a school project
[![CodeFactor](https://www.codefactor.io/repository/github/randombyteff/logic-games/badge)](https://www.codefactor.io/repository/github/randombyteff/logic-games)

Game | Creator
----------- | -------------
**Snake** | _<a href="https://github.com/RandomByteFF">RandomByteFF_</a>
**Sudoku** | _<a href="https://github.com/Ariadra">Ariadra_</a>
**Battleship**| _<a href="https://github.com/kristof-me">kristof-me_</a>

## Table of contents

  - [Installation](#installation)
  - [Snake](#snake)
  - [Sudoku](#sudoku)
  - [Battleship](#battleship)

## Installation

Download the latest version from the <a href="https://github.com/RandomByteFF/Logic-games/releases">releases page</a>. You don't need additional files, everything comes embed, except for the data saving. You will need a running <a href="https://www.apachefriends.org/download.html">mySql</a> server for that. Just run LogicGames.exe when the server is up and running.

## Snake

Classic snake game, with a little twist
![Snake](https://i.imgur.com/7rKxMcw.png)
You can start the game by pressing the `Start` button, and just like in the original game you move around by arrow keys, and your goal is to pick the apples randomly generated around the map. Hitting your tail or a wall will trigger a game over. The twist is that the playing area is fully resizable at any time, the border will shrink or grow according to your window size.

## Sudoku

![Sudoku](https://i.imgur.com/qvsX7C6.png)
Start the game by clicking on the `Start` button. Click on one of the fields to write in numbers. You can't have the same number in the row, coloumn, or the 3x3 grid. You win the game when you fill in the whole board.

## Battleship

![Battleship1](https://i.imgur.com/HXLnYFi.png)
You have a side by side view. In the preparation phase you have to place down your ships, and rotate them before placing. After that the guessing phase begins. You can make one guess, then the bot will follow. You have to guess where the other player's ships are. You win once every enemy ship has been sunk, and lose when your ships are destroyed. 
