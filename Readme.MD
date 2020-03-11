# _{Application Name}_

#### _{Brief description of application}, {Date of current version}_

#### By _**{List of contributors}**_

## Description

_ Hangman. _

## Specs

Game class
    - Solution (string)
    - guesses (char list)
    - wrong guesses (char list)
    - correct guesses (char list)
    - max guesses (int)
    - game flag (int(0 = game going, 1 = lose, 2 = win)

* game constructor
 - game has correct answer
 - game has hidden answer

* Remembers all previous checks
    - counts the amount of guesses

* Checks for & filters redundant guesses
* knows letter positions in answer
* Breaks words into individual characters
    - see if you need to do this at all
* Check character vs every letter in answer
    - Check for false
    - Check for true
    - Check if is number

* new Guess moves wrong letter into wrong guess list 
    + Too many wrong guesses (based on difficulty)
* game flag changes if you win

* game flag changes properly if you win or lose
* If unsolved is equal to solution
## Setup/Installation Requirements

* _This is a great place_
* _to list setup instructions_
* _in a simple_
* _easy-to-understand_
* _format_

## Known Bugs



## Support and contact details



## Technologies Used

_{Tell me about the languages and tools you used to create this app. Assume that I know you probably used HTML and CSS. If you did something really cool using only HTML, point that out.}_

### License

CC0

Copyright (c) 2020 **_Robert Smith_**