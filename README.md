# Language Learning App: EZJapanese


## Introduction: 
A language learning app designed for IOS and Android that quizzes you daily. It will prompt the user to set a schedule on their calendar for studying. The user can add new words they would want to remember. It's basically a flash card app, where you can store words you want to quiz, freeze words you already know, and burn words you mastered. There will icons for shuffle, add, import and export. The shuffle icon: shuffles, add icon: allows user to add cards, import: would allow users to add files (usually list of words) and export: would allow users to send the list of words for printing or a different file type.

## Requirements and Features
**Objective:** To quiz the user daily, it will prompt user to schedule their calendar for studying.
class for scheduling. 
class for quizzing.
class for scoring
class for accessing which words are learned. 
class for importing 
class for exporting 
storage database – firebase or SQL 
--store words you want to quiz
--freezes words you already know
--burns words you have mastered 
--establish user level
--establish what they want to do.

### Menu:
-Beginner 
-Intermediate
-Advanced
-Test Yourself (takes you directly into quiz mode) (on hold)
-Settings (import and export features)

**Based on selections of Beginner, Interm., and Advan.:**
**Lessons:** 1 - 10 when lesson level is selected, it will show appropriate detail.
Each lesson will have a study mode followed by a quiz mode.
Quiz mode accesses how many words are remembered (freeze, burn). 
Beginner is just words, numbers, calendar months, days of the week. 
Level 1 10 words + Days of the week. 
Level 2 20 words + Calendar months.
Level 3 30 words.
Level 4 40 words.
Level 5 50 words.
Level 6 60 words.
Level 7 70 words.
Level 8 80 words.
Level 9 90 words.
Level 10 100 words. 
User will be required to take a Quiz to get clearance for next stage. If you can burn all 10 levels, you move to intermediate. 
Intermediate is words + phrases. Save setup, 10 levels, if burned through all 10 levels, move to advanced. 
Advanced is conversational Japanese. If you passed all 10 levels, you should be able to understand the language and should be able to speak Japanese. 

**Quizzing mode:**
word is shown in Japanese 
(Romaji if beginner, Hiragana or Katanan if intermediate, & Kanji if advanced)
Responses are made from multiple choices. 
Start over or reset button always available the quiz.
**Icons:**
for shuffle (mixes the word order), add (add new words), import (ability to import words from files such as .txt or csv), and export (csv or .txt).

**optional features (if time permitting):**
User recording of their speech and compare with actual. (Would need to figure out how to do this?). 
video that will ask user to interpret a scene
answer is selected from multiple choices. 
Code Architecture: 
For this project the goal is to create the app using Xamarin but if there’s too many roadblocks like major errors or limitations. The app will be created using Android Studio and will only feature the app for Android. 


**Platform:** IOS and Android 
**Primary IDE Option:** Visual Studio – Xamarin C# 
**Secondary IDE Option:** Android Studio Java 
**Database:** Firebase or SQL 

