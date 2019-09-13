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
-Test Yourself (takes you directly into quiz mode) (on hold) <br/>
-Settings (import and export features) <br/>
<br/>
**Based on selections of Beginner, Interm., and Advan.:** <br/>
**Lessons:** 1 - 10 when lesson level is selected, it will show appropriate detail.
Each lesson will have a study mode followed by a quiz mode.<br/>
Quiz mode accesses how many words are remembered (freeze, burn). <br/>
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
User will be required to take a Quiz to get clearance for next stage. If you can burn all 10 levels, you move to intermediate. 
Intermediate is words + phrases. Save setup, 10 levels, if burned through all 10 levels, move to advanced. 
Advanced is conversational Japanese. If you passed all 10 levels, you should be able to understand the language and should be able to speak Japanese. <br/> 
<br/>
**Quizzing mode:** <br/>
word is shown in Japanese <br/> 
(Romaji if beginner, Hiragana or Katanan if intermediate, & Kanji if advanced) <br/>
Responses are made from multiple choices. <br/>
Start over or reset button always available the quiz. <br/>
<br/>
**Icons:** <br/>
for shuffle (mixes the word order), add (add new words), import (ability to import words from files such as .txt or csv), and export (csv or .txt).
<br/>
<br/>
**optional features (if time permitting):** <br/>
User recording of their speech and compare with actual. (Would need to figure out how to do this?). 
video that will ask user to interpret a scene
answer is selected from multiple choices. <br/>
<br/>
**Code Architecture:** <br/> 
For this project the goal is to create the app using Xamarin but if there’s too many roadblocks like major errors or limitations. The app will be created using Android Studio and will only feature the app for Android. 
<br/>
<br/>
**Platform:** IOS and Android <br/>
**Primary IDE Option:** Visual Studio – Xamarin C# <br/> 
**Secondary IDE Option:** Android Studio Java <br/>
**Database:** Firebase or SQL 

