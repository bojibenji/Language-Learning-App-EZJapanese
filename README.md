# Language Learning App: EZJapanese


## Introduction: 
A language learning app designed for IOS and Android that quizzes you daily. It will prompt the user to set a schedule on their calendar for studying. The user can add new words they would want to remember. It's basically a flash card app, where you can store words you want to quiz, freeze words you already know, and burn words you mastered. There will icons for shuffle, add, import and export. The shuffle icon: shuffles, add icon: allows user to add cards, import: would allow users to add files (usually list of words) and export: would allow users to send the list of words for printing or a different file type.

## Requirements and Features 
**Objective:** <br/> To quiz the user daily, it will prompt user to schedule their calendar for studying. <br/>
class for scheduling. <br/>
class for quizzing. <br/>
class for scoring <br/>
class for accessing which words are learned. <br/> 
class for importing <br/>
class for exporting <br/>
storage database – firebase or SQL <br/> 
--store words you want to quiz <br/>
--freezes words you already know <br/>
--burns words you have mastered <br/>
--establish user level <br/>
--establish what they want to do. <br/>

### Menu:
-Beginner <br/>
-Intermediate <br/>
-Advanced <br/>
-Quiz <br/>

<br/>
**Based on selections of Beginner, Interm., and Advan.:** <br/>
**Lessons:** 1 - 10 when lesson level is selected, it will show appropriate detail.
Each lesson will have a study mode followed by a quiz mode.<br/>
Quiz mode accesses how many words are remembered. <br/>
Beginner is just words, numbers, calendar months, days of the week. <br/> 
Level 1 10 words + Days of the week. <br/>
Level 2 20 words + Calendar months. <br/>
Level 3 30 words. <br/>
Level 4 40 words. <br/>
Level 5 50 words. <br/>
Level 6 60 words. <br/>
Level 7 70 words. <br/>
Level 8 80 words. <br/>
Level 9 90 words. <br/>
Level 10 100 words. <br/>
<br/>
**Quizzing mode:** <br/>
User can cycle through 3 different levels of quiz mode. Easy, Normal and Hard. 

The quiz will automatically start over after completion. <br/>
The quiz consists of 10 words each from the lessons. <br/>
**Icons:** <br/>
(Not added: *Wishlist*)for shuffle (mixes the word order), add (add new words), import (ability to import words from files such as .txt or csv), and export (csv or .txt).
<br/>
<br/>
**optional features:** <br/>
User recording of their speech and compare with actual. (Would need to figure out how to do this?). 
video that will ask user to interpret a scene
answer is selected from multiple choices. <br/>
<br/>
**Code Architecture:** <br/> 
Xamarin is what's used to code this project. 

**Download/ Setup Instructions: 
In order to try the app out or see the code. You would need Visual Studios (Recommended). 
<br/>
Update the nugets if needed. Also download Xamarin.Forms.InputKit (This is for radio buttons). 
<br/> 
Lastly, have Android 9.0 version or higher. 
<br/>
<br/>
**Platform:** IOS and Android <br/>
**Primary IDE Option:** Visual Studio – Xamarin C# <br/> 
**Secondary IDE Option:** Android Studio Java <br/>
**Database:** None 

